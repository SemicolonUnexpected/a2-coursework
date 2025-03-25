using a2_coursework.Model.CleaningJob;
using System.ComponentModel;

namespace a2_coursework.View.CleaningJob; 
public class DisplayCleaningJobModel : INotifyPropertyChanged {
    private int _id;
    public int Id {
        get => _id;
        set {
            _id = value;
            NotifyPropertyChanged(nameof(Id)); 
        }
    }

    private string _times = "";
    public string Times {
        get => _times;
        set {
            _times = value;
            NotifyPropertyChanged(nameof(Times));
        }
    }

    private string _address = "";
    public string Address {
        get => _address;
        set {
            _address = value;
            NotifyPropertyChanged();
        }
    }

    private string _date = "";
    public string Date {
        get => _date;
        set {
            _date = value;
            NotifyPropertyChanged(nameof(Date));
        }
    }

    public DisplayCleaningJobModel(CleaningJobModel model) {
        Id = model.Id;
        Times = model.StartDate.ToString("HH:mm") + " - " + model.EndDate.ToString("HH:mm");
        Address = model.Address.Replace('\n', ' ');
        Date = model.StartDate.ToString("dd/MM/yyyy");
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
