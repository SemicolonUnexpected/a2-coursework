using a2_coursework.Model.StaffModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace a2_coursework.View.StaffView.StaffManagement;
public class DisplayStaff : INotifyPropertyChanged {
    private int _id;
    public int Id {
        get => _id;
        set {
            _id = value;
            NotifyPropertyChanged(nameof(Id));
        }
    }

    private string _username = "";
    public string Username {
        get => _username;
        set {
            _username = value;
            NotifyPropertyChanged(nameof(Username));
        }
    }

    private string _names = "";
    public string Names {
        get => _names;
        set {
            _names = value;
            NotifyPropertyChanged(nameof(Names));
        }
    }

    private string _phoneNumber = "";
    public string PhoneNumber {
        get => _phoneNumber;
        set {
            _phoneNumber = value;
            NotifyPropertyChanged(nameof(PhoneNumber));
        }
    }

    private string _email = "";
    public string Email {
        get => _email;
        set {
            _email = value;
            NotifyPropertyChanged(nameof(Email));
        }
    }

    private bool _active;
    public bool Archived {
        get => _active;
        set {
            _active = value;
            NotifyPropertyChanged(nameof(Archived));
        }
    }

    public DisplayStaff(Staff staff) {
        Id = staff.Id;
        Username = staff.Username;
        Names = $"{staff.Forename} {staff.Surname}";
        PhoneNumber = staff.PhoneNumber;
        Email = staff.Email;
        Archived = staff.Archived;
    }

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
