﻿using a2_coursework._Helpers;
using a2_coursework.Theming;

namespace a2_coursework.User_Controls.DataGrid;
public partial class ViewEditSearchBar : UserControl, IThemeable {
    public event EventHandler? SearchTextChanged;
    public event EventHandler? Search;
    public event EventHandler? View;
    public event EventHandler? Edit;

    public ViewEditSearchBar() {
        InitializeComponent();

        Theme();
        SetToolTipVisibility();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        tbSearch.Theme();

        btn.ThemeWeak();
        btn.Image = _viewMode ? IconTheme.Current.Eye : IconTheme.Current.Edit;
        btnClear.ThemeWeak();
        btnClear.Image = IconTheme.Current.Cross;
        pbSearchBtn.Image = IconTheme.Current.Search;
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        toolTip.Active = showToolTips;
        tbSearch.ToolTipsActive = showToolTips;
    }

    public string SearchText {
        get => tbSearch.Text;
        set => tbSearch.Text = value;
    }

    private void btnView_Click(object sender, EventArgs e) {
        if (_viewMode) View?.Invoke(this, EventArgs.Empty);
        else Edit?.Invoke(this, EventArgs.Empty);
    }

    private void tbSearch_TextChanged(object sender, EventArgs e) {
        SearchTextChanged?.Invoke(this, EventArgs.Empty);

        if (tbSearch.Text.Length > 0) {
            btnClear.Location = new Point(tbSearch.Width + Padding.Left - btnClear.Width - btnClear.Margin.Right, (Height - btnClear.Height) / 2);
            btnClear.Visible = true;
        }
        else btnClear.Visible = false;
    }

    private bool _viewMode = true;
    public bool ViewMode {
        get => _viewMode;
        set {
            _viewMode = value;
            btn.Image = _viewMode ? IconTheme.Current.Eye : IconTheme.Current.Edit;
            toolTip.SetToolTip(btn, _viewMode ? "View" : "Edit");
        }
    }

    private void btnClear_Click(object sender, EventArgs e) => tbSearch.Text = "";

    private void pbSearchBtn_Click(object sender, EventArgs e) => Search?.Invoke(this, EventArgs.Empty);

    private void tbSearch_KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar == 13) {
            e.Handled = true;
            Search?.Invoke(this, EventArgs.Empty);
        }
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        tbSearch.SetFontName(fontName);
    }
}
