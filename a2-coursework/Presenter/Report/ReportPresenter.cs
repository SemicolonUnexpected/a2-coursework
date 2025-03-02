using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Report;

namespace a2_coursework.Presenter.Report;
public class ReportPresenter : BasePresenter<IReportView>, IChildPresenter, INavigatingPresenter {
    private byte[]? _pdf;
    private readonly Task<byte[]> _getPdf;
    private Func<(IChildView view, IChildPresenter presenter)>? _back;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public ReportPresenter(IReportView view, string reportName, Task<byte[]> getPdf, Func<(IChildView view, IChildPresenter presenter)>? back = null) : base(view) {
        _getPdf = getPdf;
        if (back is not null) _view.BackVisible = true;

        _back = back;
        _view.ReportName = reportName;

        _view.Download += OnDownload;
        _view.Back += OnBack;
        _view.Shown += OnShown;
    }

    private void OnDownload(object? sender, EventArgs e) => Download();
    private void OnBack(object? sender, EventArgs e) => NavigateBack();
    private void OnShown(object? sender, EventArgs e) => ShowReport();

    private void NavigateBack() {
        if (_back is null) return;

        (IChildView view, IChildPresenter presenter) = _back();
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private async void ShowReport() {
        _pdf = await _getPdf;
        PopulatePdf(_pdf);
    }


    private void PopulatePdf(byte[] pdf) {
        _pdf = pdf;
        _view.Pdf = _pdf;
    }

    private void Download() {
        if (_pdf is null) return;

        try {
            if (_view.GetFileName(out string name)) {
                File.WriteAllBytes(name, _pdf);
                MessageBox.Show("Saved the report file successfully", "Success");
            }
        }
        catch {
            MessageBox.Show("Error saving the report file", "Error");
        }
    }

    public bool CanExit() => true;

    public override void CleanUp() {
        _view.Download -= OnDownload;
        _view.Back -= OnBack;
        _view.Shown -= OnShown;

        base.CleanUp();
    }
}
