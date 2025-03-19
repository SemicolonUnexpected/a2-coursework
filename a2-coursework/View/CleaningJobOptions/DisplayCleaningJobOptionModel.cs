using a2_coursework.Model.CleaningJobOption;
using System.ComponentModel;

namespace a2_coursework.View.CleaningJobOptions;

public class DisplayCleaningJobOptionModel : INotifyPropertyChanged {
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

    private decimal _costAtTime;
    public decimal CostAtTime {
        get => _costAtTime;
        set {
            _costAtTime = value;
            NotifyPropertyChanged();
        }
    }

    public DisplayCleaningJobOptionModel(CleaningJobOptionModel model) {
        Id = model.Id;
        Name = model.Name;
        Description = model.Description;
        UnitCost = model.UnitCost;
        Archived = model.Archived;
        CostAtTime = model.CostAtTime;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
