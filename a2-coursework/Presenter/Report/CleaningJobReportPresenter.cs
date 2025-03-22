using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Report;
using a2_coursework.Model.CleaningJob;
using a2_coursework.Model.Reports;
using a2_coursework.Model.Staff;

namespace a2_coursework.Presenter.Report; 
public class CleaningJobReportPresenter : BasePresenter<ICleaningJobReportView>, IChildPresenter, INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public CleaningJobReportPresenter(ICleaningJobReportView view) : base(view) {
        _view.GenerateReport += OnGenerateReport;
    }

    private void OnGenerateReport(object? sender, EventArgs e) => GenerateReport();

    private async void GenerateReport() {
        if (int.TryParse(_view.Id, out int id)) {
            CleaningJobModel? model = await CleaningJobDAL.GetCleaningJobById(id);

            if (model is null) {
                _view.ErrorMessage = "Invalid ID";
                return;
            }

            (IChildView view, IChildPresenter presenter) = ReportFactory.CreateReport("Cleaning Job Report", CleaningJobReportGenerator.CleaningJobItemsReport(model), () => ReportFactory.CreateCleaningJobReport());
            NavigationEventArgs? navigationEventArgs = new(view, presenter);
            NavigationRequest?.Invoke(this, navigationEventArgs);
        }
        else {
            _view.ErrorMessage = "Invalid ID";
        }
    }

    public bool CanExit() => true;

    public override void CleanUp() {
        _view.GenerateReport -= OnGenerateReport;

        base.CleanUp();
    }
}
