
using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.CleaningJobOption;
using a2_coursework.Model.JobOption;

namespace a2_coursework.Presenter.CleaningJobOption;
public class AddCleaningJobOptionPresenter : AddPresenter<IAddCleaningJobOptionView, CleaningJobOptionModel>, IChildPresenter, INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public AddCleaningJobOptionPresenter(IAddCleaningJobOptionView view) : base(view, new CleaningJobOptionModel(-1, "", "", 0, false)) {

        _viewFactories.Add(GetDetails);

        _view.Back += OnBack;

        NavigateToCurrentView();
    }

    private void OnBack(object? sender, EventArgs e) {
        if (CanExit()) NavigateBack();
    }
    private void OnValidateNameRequest(object? sender, ValidationRequestEventArgs<string> e) => IsValidName(e);

    private void NavigateBack() {
        (IChildView view, IChildPresenter presenter) = CleaningJobOptionFactory.CreateDisplayCleaningJobOption();
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation(ICleanable presenter) {
        if (presenter is ManageJobCleaningOptionPresenter manageJobOptionPresenter) manageJobOptionPresenter.ValidateNameRequest += OnValidateNameRequest;
    }

    protected override void UnBindValidation(ICleanable presenter) {
        if (presenter is ManageJobCleaningOptionPresenter manageJobOptionPresenter) manageJobOptionPresenter.ValidateNameRequest -= OnValidateNameRequest;
    }

    protected override Task<bool> UpdateDatabase() => CleaningJobOptionDAL.CreateJobOption(_model);

    #region Details
    private (IChildView childView, ICleanable childPresenter) GetDetails() {
        (View.ManageCleaningJobOptionView view, ManageJobCleaningOptionPresenter presenter) = CleaningJobOptionFactory.CreateManageCleaningJobOption();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesDetails(presenter);
        ValidateCurrent = () => ValidateInputsDetails(presenter);
        UpdateModelCurrent = () => UpdateModelDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesDetails(ManageJobCleaningOptionPresenter presenter) {
        presenter.Name = _model.Name;
        presenter.Description = _model.Description;
        presenter.UnitCost = _model.UnitCost;
    }

    private bool ValidateInputsDetails(ManageJobCleaningOptionPresenter presenter) => presenter.NameValid;

    private void UpdateModelDetails(ManageJobCleaningOptionPresenter presenter) {
        _model.Name = presenter.Name;
        _model.Description = presenter.Description;
        _model.UnitCost = presenter.UnitCost;
    }

    private void IsValidName(ValidationRequestEventArgs<string> validateUsernameRequest) {
        string username = validateUsernameRequest.Value;

        if (string.IsNullOrWhiteSpace(username)) validateUsernameRequest.SetValidation(false, "Please fill in a name");
        else validateUsernameRequest.SetValidation(CleaningJobOptionDAL.GetJobOptionByName(username).ContinueWith(x => x.Result is null), "This name already exists. Please pick a different one");
    }
    #endregion

    protected override void OnAddSuccessful() => NavigateBack();

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
