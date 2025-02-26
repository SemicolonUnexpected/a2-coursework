using a2_coursework.Interfaces.Report;

namespace a2_coursework.Presenter.Report;
public class ReportPresenter : BasePresenter<IReportView>, IChildPresenter {
    private byte[]? _pdf;
    public ReportPresenter(IReportView view, string reportName, Task<byte[]> getPdf) : base(view) {
        Task.Run(async () => {
            byte[] pdf = await getPdf;
            _view.Invoke(() => PopulatePdf(pdf));
        });

        _view.ReportName = reportName;

        _view.Download += OnDownload;
    }

    private void OnDownload(object? sender, EventArgs e) => Download();

    private void PopulatePdf(byte[] pdf) {
        _pdf = pdf;
        _view.Pdf = _pdf;
    }

    private void Download() {
        try {
            if (_view.GetFileName(out string name)) {
                File.WriteAllBytes(name, _pdf!);
                MessageBox.Show("Saved the report file successfully", "Success");
            }
        }
        catch {
            MessageBox.Show("Error saving the report file", "Error");
        }
    }

    public bool CanExit() => true;
}
