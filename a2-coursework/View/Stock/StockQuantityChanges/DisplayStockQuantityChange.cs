using a2_coursework.Model.Stock;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace a2_coursework.View.Stock.StockQuantityChanges;
public class DisplayStockQuantityChange : INotifyPropertyChanged {

    private string _username = "";
    public string Username {
        get => _username;
        set {
            _username = value;
            NotifyPropertyChanged();
        }
    }

    private string _staffName = "";
    public string StaffName {
        get => _staffName;
        set {
            _staffName = value;
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

    private DateTime _date;
    public DateTime Date {
        get => _date;
        set {
            _date = value;
            NotifyPropertyChanged();
        }
    }

    private string _reasonForQuantityChange = "";
    public string ReasonForQuantityChange {
        get => _reasonForQuantityChange;
        set {
            _reasonForQuantityChange = value;
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

    private string _stockName = "";
    public string StockName {
        get => _stockName;
        set {
            _stockName = value;
            NotifyPropertyChanged();
        }
    }

    private string _stockSku = "";
    public string StockSKU {
        get => _stockSku;
        set {
            _stockSku = value;
            NotifyPropertyChanged();
        }
    }

    public DisplayStockQuantityChange(StockQuantityChange stockQuantityChange) {
        Username = stockQuantityChange.StaffUsername;
        StaffName = $"{stockQuantityChange.StaffForename} {stockQuantityChange.StaffSurname}";
        Quantity = stockQuantityChange.Quantity;
        Date = stockQuantityChange.Date;
        ReasonForQuantityChange = stockQuantityChange.ReasonForQuantityChange;
        Archived = stockQuantityChange.StockArchived;
        StockName = stockQuantityChange.StockName;
        StockSKU = stockQuantityChange.StockSKU;
    }

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
