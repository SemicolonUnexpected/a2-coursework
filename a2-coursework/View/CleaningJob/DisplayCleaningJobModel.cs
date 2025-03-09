using a2_coursework.Model.CleaningJob;
using System.ComponentModel;

namespace a2_coursework.View.Order; 
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

    public DisplayCleaningJobModel(CleaningJobModel model) {
        Id = model.Id;
        Times = model.StartDate.ToString("HH:mm") + " - " + model.EndDate.ToString("HH:mm");
        Address = model.Address.Replace('\n', ' ');
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
