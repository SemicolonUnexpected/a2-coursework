using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Stock;
public interface IStockDisplay : IThemeable, IChildView {
    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;

    public string SearchText { get; set; }
    public string DataGridText { set; }
    public bool ShowArchived { get; }
    public int? SelectedId { get; set; }

    public void DisplayData(List<object[]> data);
    public void ClearData();
    public void DisableAll();
}
