using a2_coursework.Factory;
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

            List<StaffModel> cleaningStaff = [];
            foreach(int staffId in model.StaffIds) {
                StaffModel? staff = await StaffDAL.GetStaffById(staffId);
                if (staff is not null) cleaningStaff.Add(staff);
                else {
                    _view.ErrorMessage = "Invalid ID";
                    return;
                }
            }
            var viewPresenter = ReportFactory.CreateReport("Cleaning Job Report", ReportGenerator.GenerateCleaningJobReport(model, cleaningStaff), Task.FromResult((this, _view));

            NavigateEventArgs args = new();
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
