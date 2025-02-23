using System.ComponentModel;

namespace a2_coursework.Model.JobOption;

public class DisplayJobOptionModel: INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

    private int _id;
    public int Id {
        get => _id;
        set {
            _id = value;
            NotifyPropertyChanged();
        }
    }

    private string _name = "";
    public string Name {
        get => _name;
        set {
            _name = value;
            NotifyPropertyChanged();
        }
    }

    private string _description = "";
    public string Description {
        get => _description;
        set {
            _description = value;
            NotifyPropertyChanged();
        }
    }

    private decimal _unitCost;
    public decimal UnitCost {
        get => _unitCost;
        set {
            _unitCost = value;
            NotifyPropertyChanged();
        }
    }

    private bool _archived;
    public bool Archived {
        get => _archived;
        set {
            _archived = value;
            NotifyPropertyChanged();
        }
    }

    public DisplayJobOptionModel(CleaningJobOptionModel model) {
        Id = model.Id;
        Name = model.Name;
        Description = model.Description;
        UnitCost = model.UnitCost;
        Archived = model.Archived;
    }

    private void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
