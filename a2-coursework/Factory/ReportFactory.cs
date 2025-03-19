using a2_coursework.Interfaces;
using a2_coursework.Presenter;
using a2_coursework.Presenter.Report;
using a2_coursework.View;

namespace a2_coursework.Factory; 
public static class ReportFactory {
    public static (ReportView view, ReportPresenter presenter) CreateReport(string reportName, Task<MemoryStream> getPdf, Func<(IChildView view, IChildPresenter presenter)>? back = null) {
        ReportView view = new();
        ReportPresenter presenter = new(view, reportName, getPdf, back);

        return (view, presenter);
    }

}
