using a2_coursework.Model.Stock;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace a2_coursework.View.Stock.StockManagement;
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

    private bool _archived;
    public bool Archived {
        get => _archived;
        set {
            _archived = value;
            NotifyPropertyChanged();
        }
    }

    public DisplayStockItem(StockModel stockItem) {
        Id = stockItem.Id;
        Name = stockItem.Name;
        SKU = stockItem.SKU;
        Quantity = stockItem.Quantity;
        QuantityLevel = stockItem.Quantity >= stockItem.HighQuantity ? "High" : stockItem.Quantity <= stockItem.LowQuantity ? "Low" : "Medium";
        Archived = stockItem.Archived;
    }

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
