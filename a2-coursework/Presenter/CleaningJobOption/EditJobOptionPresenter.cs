using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.CleaningJobOption;
using a2_coursework.Model.Customer;
using a2_coursework.Model.JobOption;

namespace a2_coursework.Presenter.CleaningJobOption;
internal class EditJobOptionPresenter : ParentEditPresenter<IEditCleaningJobOptionView, CleaningJobOptionModel>, IChildPresenter, INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public EditJobOptionPresenter(IEditCleaningJobOptionView view, CleaningJobOptionModel model) : base(view, model) {
        _view.Back += OnBack;

        Navigate(GetDetails());
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();
    private void OnValidateNameRequest(object? sender, ValidationRequestEventArgs<string> e) => ValidateName(e);
    

    private void NavigateBack() {
        if (!CanExit()) return;
        (IChildView view, IChildPresenter presenter) = CleaningJobOptionFactory.CreateDisplayCleaningJobOption();
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation() {
        if (_childPresenter is ManageJobOptionPresenter manageJobOptionPresenter) manageJobOptionPresenter.ValidateNameRequest += OnValidateNameRequest;
    }

    protected override void UnBindValidation() {
        if (_childPresenter is ManageJobOptionPresenter manageJobOptionPresenter) manageJobOptionPresenter.ValidateNameRequest -= OnValidateNameRequest;
    }

    protected override (IChildView childView, INotifyingChildPresenter childPresenter) GetView(string selectedItem) => GetDetails();

    #region Details
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetDetails() {
        (View.ManageCleaningJobOptionView view, ManageJobOptionPresenter presenter) = CleaningJobOptionFactory.CreateManageCleaningJobOption();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesContactDetails(presenter);
        AnyChangesCurrent = () => AnyChangesContactDetails(presenter);
        ValidateCurrent = () => ValidateInputsContactDetails(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseContactDetails(presenter);
        UpdateModelCurrent = () => UpdateModelContactDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesContactDetails(ManageJobOptionPresenter presenter) {
        presenter.Name = _model.Name;
        presenter.Description = _model.Description;
        presenter.UnitCost = _model.UnitCost;
    }

    private bool AnyChangesContactDetails(ManageJobOptionPresenter presenter) => presenter.Email != _model.Email || presenter.PhoneNumber != _model.PhoneNumber || presenter.Address != _model.Address;

    private bool ValidateInputsContactDetails(ManageJobOptionPresenter presenter) => presenter.EmailValid && presenter.PhoneNumberValid;

    private Task<bool> UpdateDatabaseContactDetails(ManageJobOptionPresenter presenter) => CleaningJobOptionDAL.UpdateJobOptionDetails(_model.Id, presenter.Name, presenter.Description, presenter.UnitCost, presenter.Archived);

    private void UpdateModelContactDetails(ManageJobOptionPresenter presenter) {
        _model.Name = presenter.Name;
        _model.Description = presenter.Description;
        _model.UnitCost = presenter.UnitCost;
    }
    #endregion

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
