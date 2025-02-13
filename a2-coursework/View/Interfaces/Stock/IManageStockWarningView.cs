using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Stock; 
public interface IManageStockWarningView : IThemeable, IChildView {
    public int LowQuantity { get; set; }
    public int HighQuantity { get; set; }
}
