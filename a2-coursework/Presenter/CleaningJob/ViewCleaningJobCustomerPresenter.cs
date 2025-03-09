using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Model.Customer;

namespace a2_coursework.Presenter.CleaningJob;

public class ViewCleaningJobCustomerPresenter : BasePresenter<IViewCleaningJobCustomerView>, IChildPresenter {
    public ViewCleaningJobCustomerPresenter(IViewCleaningJobCustomerView view, int id) : base(view) {
        LoadInformation(id);
    }

    private async void LoadInformation(int id) {
        CustomerModel? model = await CustomerDAL.GetCustomerById(id);

        if (model is not null) {
            CustomerName = $"{model.Forename} {model.Surname}";
            CustomerEmail = model.Email;
            CustomerPhoneNumber = model.PhoneNumber;
        }
    }

    public bool CanExit() => true;

    public string CustomerName {
        get => _view.CustomerName;
        set => _view.CustomerName = value;
    }

    public string CustomerEmail {
        get => _view.CustomerEmail;
        set => _view.CustomerEmail = value;
    }

    public string CustomerPhoneNumber {
        get => _view.CustomerPhoneNumber;
        set => _view.CustomerPhoneNumber = value;
    }
}
