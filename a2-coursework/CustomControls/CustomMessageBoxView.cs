﻿using a2_coursework._Helpers;
using a2_coursework.Interfaces;
using a2_coursework.Theming;

namespace a2_coursework.CustomControls;
public partial class CustomMessageBoxView : Form, IThemeable, IView {
    public CustomMessageBoxView(string text, string caption, MessageBoxButtons buttons) {
        InitializeComponent();

        lblText.Text = text;
        lblTitle.Text = caption;

        SetupButtons(buttons);

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblTitle.ThemeTitle();
        lblText.ThemeSubtitle();

        pnlBottom.BackColor = ColorScheme.Current.Background;
        flp.BackColor = ColorScheme.Current.Background;
        pnlDecor.BackColor = ColorScheme.Current.Primary;

        btnOk.ThemeStrong();
        btnCancel.ThemeStrong();
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblTitle.SetFontName(fontName);
        lblText.SetFontName(fontName);
        btnCancel.SetFontName(fontName);
        btnOk.SetFontName(fontName);
    }

    private void SetupButtons(MessageBoxButtons buttons) {
        switch (buttons) {
            case MessageBoxButtons.OK:
                btnCancel?.Hide();
                break;
            case MessageBoxButtons.OKCancel:
                break;
            default:
                throw new NotImplementedException();
        }
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.Cancel;

        Close();
    }

    private void btnOk_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.OK;

        Close();
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
