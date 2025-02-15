using a2_coursework.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace a2_coursework.View.Stock; 
public class DisplayStockItem : INotifyPropertyChanged {
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
    public string SKU {
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

    private bool _isArchived;
    public bool IsArchived {
        get => _isArchived;
        set {
            _isArchived = value;
            NotifyPropertyChanged();
        }
    }

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public DisplayStockItem(StockItem stockItem) {
        Id = stockItem.Id;
        Name = stockItem.Name;
        SKU = stockItem.SKU;
        Quantity = stockItem.Quantity;
        QuantityLevel = stockItem.Quantity >= stockItem.HighQuantity ? "High" : stockItem.Quantity <= stockItem.LowQuantity ? "Low" : "Medium"; 
        IsArchived = stockItem.IsArchived;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
