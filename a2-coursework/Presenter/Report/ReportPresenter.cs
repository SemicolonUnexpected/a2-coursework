using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Report;
using PdfiumViewer;

namespace a2_coursework.Presenter.Report;
public class ReportPresenter : BasePresenter<IReportView>, IChildPresenter, INavigatingPresenter {
    private MemoryStream? _pdfMemoryStream;
    private PdfDocument? _pdf;
    private readonly Task<MemoryStream> _getPdf;
    private readonly Func<(IChildView view, IChildPresenter presenter)>? _back;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public ReportPresenter(IReportView view, string reportName, Task<MemoryStream> getPdf, Func<(IChildView view, IChildPresenter presenter)>? back = null) : base(view) {
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
    private void OnShown(object? sender, EventArgs e) => Task.Run(ShowReport);

    private void NavigateBack() {
        if (_back is null) return;

        (IChildView view, IChildPresenter presenter) = _back();
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private async void ShowReport() {
        try {
            _pdfMemoryStream = await _getPdf;
            _pdf = PdfDocument.Load(_pdfMemoryStream);
            _view.Invoke(() => {
                try {
                    _view.Pdf = _pdf;
                }
                catch { }
            });
        }
        catch { }
    }

    private void Download() {
        if (_pdf is null) return;

        try {
            if (_view.GetFileName(out string name)) {
                File.WriteAllBytes(name, _pdfMemoryStream!.ToArray());
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

        _pdfMemoryStream?.Dispose();

        base.CleanUp();
    }
}
