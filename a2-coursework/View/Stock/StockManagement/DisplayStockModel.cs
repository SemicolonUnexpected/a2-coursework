using a2_coursework.Model.Stock;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace a2_coursework.View.Stock.StockManagement;
public class DisplayStockModel : INotifyPropertyChanged {
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

    private string _sku = "";
    public string Sku {
        get => _sku;
        set {
            _sku = value;
            NotifyPropertyChanged();
        }
    }

    private int _quantity;
    public int Quantity {
        get => _quantity;
        set {
            _quantity = value;
            NotifyPropertyChanged();
        }
    }

    private string _quantityLevel = "";
    public string QuantityLevel {
        get => _quantityLevel;
        set {
            _quantityLevel = value;
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

    private decimal _unitCost;
    public decimal UnitCost {
        get => _unitCost;
        set {
            _unitCost = value;
            NotifyPropertyChanged();
        }
    }

    private decimal _unitCostAtTime;
    public decimal UnitCostAtTime {
        get => _unitCostAtTime;
        set {
            _unitCostAtTime = value;
            NotifyPropertyChanged();
        }
    }

    public DisplayStockModel(StockModel model) {
        Id = model.Id;
        Name = model.Name;
        Sku = model.Sku;
        Quantity = model.Quantity;
        QuantityLevel = model.Quantity >= model.HighQuantity ? "High" : model.Quantity <= model.LowQuantity ? "Low" : "Medium";
        Archived = model.Archived;
        UnitCost = model.UnitCost;
        UnitCostAtTime = model.CostAtTime;
    }

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public event PropertyChangedEventHandler? PropertyChanged;
}
