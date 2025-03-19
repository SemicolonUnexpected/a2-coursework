using a2_coursework.Model.Customer;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace a2_coursework.View.Customer; 
public class DisplayCustomerModel : INotifyPropertyChanged {
    private int _id;
    public int Id {
        get => _id;
        set {
            _id = value;
            NotifyPropertyChanged();
        }
    }

    private string _name = "";
    public string Names {
        get => _name;
        set {
            _name = value;
            NotifyPropertyChanged();
        }
    }


    private string _email = "";
    public string Email {
        get => _email;
        set {
            _email = value;
            NotifyPropertyChanged();
        }
    }

    private string _phoneNumber = "";
    public string PhoneNumber {
        get => _phoneNumber;
        set {
            _phoneNumber = value;
            NotifyPropertyChanged();
        }
    }

    public bool _archived;
    public bool Archived {
        get => _archived;
        set {
            _archived = value;
            NotifyPropertyChanged();
        }
    }

    public DisplayCustomerModel(CustomerModel model) {
        Id = model.Id;
        Names = $"{model.Forename} {model.Surname}";
        Email = model.Email;
        PhoneNumber = model.PhoneNumber;
        Archived = model.Archived;
    }

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
