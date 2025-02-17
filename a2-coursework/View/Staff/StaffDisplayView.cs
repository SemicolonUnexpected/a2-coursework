using a2_coursework.Interfaces.Users;

namespace a2_coursework.View.Users;
public partial class StaffDisplayView : Form, IDisplayStaffView {
    public StaffDisplayView() {
        InitializeComponent();
    }

    public string SearchText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DataGridText { set => throw new NotImplementedException(); }

    public bool ShowArchivedItems => throw new NotImplementedException();

    public bool SelectedItemArchived { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public void CleanUp() {
        throw new NotImplementedException();
    }

    public void DisableAll() {
        throw new NotImplementedException();
    }

    public void EnableAll() {
        throw new NotImplementedException();
    }
}
