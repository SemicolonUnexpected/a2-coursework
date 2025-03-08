using a2_coursework.Model.Order;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace a2_coursework.View.Order;

public class DisplayOrderModel : INotifyPropertyChanged {
    private int _id;
    public int Id {
        get => _id;
        set {
            _id = value;
            NotifyPropertyChanged(nameof(Id));
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

    private string _status = "";
    public string Status {
        get => _status;
        set {
            _status = value;
            NotifyPropertyChanged(nameof(Status));
        }
    }

    private string _staffName = "";
    public string StaffName {
        get => _staffName;
        set {
            _staffName = value;
            NotifyPropertyChanged(nameof(StaffName));
        }
    }

    public DisplayOrderModel(OrderModel order) {
        Id = order.Id;
        StaffName = $"{order.Staff.Forename} {order.Staff.Surname}";
        Status = order.Status;
    }

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
