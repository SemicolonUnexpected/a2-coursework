using a2_coursework.Presenter.Report;
using a2_coursework.View;

namespace a2_coursework.Factory; 
public static class ReportFactory {
    public static (ReportView view, ReportPresenter presenter) CreateReport(string reportName, Task<MemoryStream> getPdf) {
        ReportView view = new();
        ReportPresenter presenter = new(view, reportName, getPdf);

        return (view, presenter);
    }

}
