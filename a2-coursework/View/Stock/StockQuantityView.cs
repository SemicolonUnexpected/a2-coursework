using a2_coursework.Theming;
using a2_coursework.View.Interfaces.Stock;

namespace a2_coursework.View.Stock;
public partial class StockQuantityView : Form, IStockQuantity {
    //private StockQuantityPresenter? _presenter;

    public event EventHandler? BulkAdd;
    public event EventHandler? BulkRemove;
    public event EventHandler? ReasonForQuantityChangeChanged;
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public StockQuantityView() {
        InitializeComponent();
    }

    //public void SetPresenter(StockQuantityPresenter presenter) {
    //    _presenter = presenter;
    //}

    public int Quantity {
        get => nudQuantity.Value;
        set => nudQuantity.Value = value;
    }

    public int BulkAddQuantity {
        get {
            int.TryParse(tbBulkAdd.Text, out int value);
            return value;
        }
    }

    public int BulkRemoveQuantity {
        get {
            int.TryParse(tbBulkRemove.Text, out int value);
            return value;
        }
    }

    public string ReasonForQuantityChange {
        get => tbReasonForChange.Text;
        set => tbReasonForChange.Text = value;
    }

    private bool _isLoading = false;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            nudQuantity.Enabled = !_isLoading;
            tbBulkAdd.Enabled = !_isLoading;
            tbBulkRemove.Enabled = !_isLoading;
            btnAdd.Enabled = !_isLoading;
            btnRemove.Enabled = !_isLoading;
            tbReasonForChange.Enabled = false;

            approveChangesBar.IsLoading = _isLoading;
        }
    }

    public bool SaveVisible {
        get => approveChangesBar.Visible;
        set => approveChangesBar.Visible = value;
    }

    public void SetCharacterCount(int number) {
        lblCharacterLimit.Text = $"{number}/{tbReasonForChange.MaxLength}";
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        lblQuantity.ThemeTitle();
        lblBulkAdd.ThemeTitle();
        lblBulkRemove.ThemeTitle();
        lblReasonForChange.ThemeTitle();
        lblCharacterLimit.ThemeSubtitle();
        lblStaffLink.ThemeSubtitle();

        tbBulkAdd.Theme();
        tbBulkRemove.Theme();
        tbReasonForChange.Theme();

        btnAdd.ThemeStrong();
        btnRemove.ThemeStrong();

        approveChangesBar.Theme();
    }

    private void tbBulkAdd_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsControl(e.KeyChar) && !char.IsAsciiDigit(e.KeyChar)) e.Handled = true;
    }

    private void tbBulkRemove_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsControl(e.KeyChar) && !char.IsAsciiDigit(e.KeyChar)) e.Handled = true;
    }
}
