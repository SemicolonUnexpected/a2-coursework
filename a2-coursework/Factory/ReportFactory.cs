using a2_coursework.Interfaces;
using a2_coursework.Presenter;
using a2_coursework.Presenter.Report;
using a2_coursework.View;
using a2_coursework.View.Reports;

namespace a2_coursework.Factory; 
public static class ReportFactory {
    public static (ReportView view, ReportPresenter presenter) CreateReport(string reportName, Task<MemoryStream> getPdf, Func<(IChildView view, IChildPresenter presenter)>? back = null) {
        ReportView view = new();
        ReportPresenter presenter = new(view, reportName, getPdf, back);

        return (view, presenter);
    }

    public static (CleaningJobReportView view, CleaningJobReportPresenter presenter) CreateCleaningJobReport() {
        CleaningJobReportView view = new();
        CleaningJobReportPresenter presenter = new(view);

        return (view, presenter);
    }
}
