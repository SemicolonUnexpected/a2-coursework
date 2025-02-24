using a2_coursework.Model.LoginAttempt;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace a2_coursework.View.LoginAttempt;

public class DisplayLoginAttemptModel : INotifyPropertyChanged {
    private string _username = "";
    public string Username {
        get => _username;
        set {
            _username = value;
            NotifyPropertyChanged(nameof(Username));
        }
    }

    private DateTime _attemptTime;
    public DateTime AttemptTime {
        get => _attemptTime;
        set {
            _attemptTime = value;
            NotifyPropertyChanged(nameof(AttemptTime));
        }
    }

    private bool _successful;
    public bool Successful {
        get => _successful;
        set {
            _successful = value;
            NotifyPropertyChanged(nameof(Successful));
        }
    }

    public DisplayLoginAttemptModel(LoginAttemptModel loginAttempt) {
        Username = loginAttempt.Username;
        AttemptTime = loginAttempt.AttemptTime;
        Successful = loginAttempt.Successful;
    }

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
