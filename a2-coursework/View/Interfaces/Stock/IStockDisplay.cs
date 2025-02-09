using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Stock;
public interface IStockDisplay : IThemeable {
    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;

    public string SearchText { get; set; }
    public bool ShowArchived { get; set; }
    public int SelectedRow { get; set; }

    public void DisplayStock(List<object[]> data);
}
