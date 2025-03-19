using a2_coursework.View;
using a2_coursework.View.CleaningJobOptions;

namespace a2_coursework.Interfaces;

public interface IManageCleaningJobOptionsView : IDisplayView<DisplayCleaningJobOptionModel>, IChildView {
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler? QuantityChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public string SearchText { get; set; }
    public DisplayCleaningJobOptionModel? SelectedItem { get; }
    public string DataGridText { get; set; }

    public string CleaningOptionName { get; set; }
    public string CleaningOptionDescription { get; set; }
    public int Quantity { get; set; }
    public decimal Subtotal { set; }
    public decimal Total { set; }
    public bool Editable { get; set; }

    public void DisableAll();
    public void EnableAll();
}
