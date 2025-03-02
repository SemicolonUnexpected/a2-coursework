using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.CleaningJobOption;
using a2_coursework.Model.CleaningJobOption;

namespace a2_coursework.Presenter.CleaningJobOption;
public class EditCleaningJobOptionPresenter : ParentEditPresenter<IEditCleaningJobOptionView, CleaningJobOptionModel>, IChildPresenter, INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public EditCleaningJobOptionPresenter(IEditCleaningJobOptionView view, CleaningJobOptionModel model) : base(view, model) {
        _view.Back += OnBack;

        Navigate(GetDetails());
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();
    private void OnValidateNameRequest(object? sender, ValidationRequestEventArgs<string> e) => IsValidName(e);
    

    private void NavigateBack() {
        if (!CanExit()) return;
        (IChildView view, IChildPresenter presenter) = CleaningJobOptionFactory.CreateDisplayCleaningJobOption();
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation() {
        if (_childPresenter is ManageJobCleaningOptionPresenter manageJobOptionPresenter) manageJobOptionPresenter.ValidateNameRequest += OnValidateNameRequest;
    }

    protected override void UnBindValidation() {
        if (_childPresenter is ManageJobCleaningOptionPresenter manageJobOptionPresenter) manageJobOptionPresenter.ValidateNameRequest -= OnValidateNameRequest;
    }

    protected override (IChildView childView, INotifyingChildPresenter childPresenter) GetView(string selectedItem) => GetDetails();

    #region Details
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetDetails() {
        (View.ManageCleaningJobOptionView view, ManageJobCleaningOptionPresenter presenter) = CleaningJobOptionFactory.CreateManageCleaningJobOption();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesContactDetails(presenter);
        AnyChangesCurrent = () => AnyChangesContactDetails(presenter);
        ValidateCurrent = () => ValidateInputsContactDetails(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseContactDetails(presenter);
        UpdateModelCurrent = () => UpdateModelContactDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesContactDetails(ManageJobCleaningOptionPresenter presenter) {
        presenter.Name = _model.Name;
        presenter.Description = _model.Description;
        presenter.UnitCost = _model.UnitCost;
    }

    private bool AnyChangesContactDetails(ManageJobCleaningOptionPresenter presenter) => presenter.Name != _model.Name || presenter.Description != _model.Description || presenter.UnitCost != _model.UnitCost;

    private bool ValidateInputsContactDetails(ManageJobCleaningOptionPresenter presenter) => presenter.NameValid;

    private Task<bool> UpdateDatabaseContactDetails(ManageJobCleaningOptionPresenter presenter) => CleaningJobOptionDAL.UpdateJobOptionDetails(_model.Id, presenter.Name, presenter.Description, presenter.UnitCost);

    private void UpdateModelContactDetails(ManageJobCleaningOptionPresenter presenter) {
        _model.Name = presenter.Name;
        _model.Description = presenter.Description;
        _model.UnitCost = presenter.UnitCost;
    }

    private void IsValidName(ValidationRequestEventArgs<string> validateUsernameRequest) {
        string username = validateUsernameRequest.Value;

        if (username == _model.Name) {
            validateUsernameRequest.SetValidation(true);
            return;
        }

        if (string.IsNullOrWhiteSpace(username)) validateUsernameRequest.SetValidation(false, "Please fill in a name");
        else validateUsernameRequest.SetValidation(CleaningJobOptionDAL.GetJobOptionByName(username).ContinueWith(x => x.Result is null), "This name already exists. Please pick a different one");
    }
    #endregion

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
