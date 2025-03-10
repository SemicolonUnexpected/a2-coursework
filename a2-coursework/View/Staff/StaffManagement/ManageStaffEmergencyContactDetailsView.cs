﻿using a2_coursework._Helpers;
using a2_coursework.Theming;

namespace a2_coursework.View.StaffView;
public partial class ManageStaffEmergencyContactDetailsView : Form, Interfaces.Staff.StaffManagement.IManageStaffEmergencyContactDetailsView, IThemeable {
    public event EventHandler? EmergencyContactForenameChanged;
    public event EventHandler? EmergencyContactSurnameChanged;
    public event EventHandler? EmergencyContactPhoneNumberChanged;

    public ManageStaffEmergencyContactDetailsView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        tbEmergencyContactForename.TextChanged += (s, e) => EmergencyContactForenameChanged?.Invoke(this, EventArgs.Empty);
        tbEmergencyContactSurname.TextChanged += (s, e) => EmergencyContactSurnameChanged?.Invoke(this, EventArgs.Empty);
        tbEmergencyContactPhoneNumber.TextChanged += (s, e) => EmergencyContactPhoneNumberChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblEmergencyContactForenameTitle.ThemeTitle();
        tbEmergencyContactForename.Theme();
        lblEmergencyContactSurnameTitle.ThemeTitle();
        tbEmergencyContactSurname.Theme();
        lblEmergencyContactPhoneNumberTitle.ThemeTitle();
        tbEmergencyContactPhoneNumber.Theme();
        lblEmergencyContactPhoneNumberError.ThemeError();

        tbEmergencyContactPhoneNumber.BorderColor = _emergencyContactPhoneNumberBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblEmergencyContactForenameTitle.SetFontName(fontName);
        tbEmergencyContactForename.SetFontName(fontName);
        lblEmergencyContactSurnameTitle.SetFontName(fontName);
        tbEmergencyContactForename.SetFontName(fontName);
        lblEmergencyContactPhoneNumberTitle.SetFontName(fontName);
        tbEmergencyContactPhoneNumber.SetFontName(fontName);
        lblEmergencyContactPhoneNumberError.SetFontName(fontName);
    }

    public string EmergencyContactForename {
        get => tbEmergencyContactForename.Text;
        set => tbEmergencyContactForename.Text = value;
    }

    public string EmergencyContactSurname {
        get => tbEmergencyContactSurname.Text;
        set => tbEmergencyContactSurname.Text = value;
    }

    public string EmergencyContactPhoneNumber {
        get => tbEmergencyContactPhoneNumber.Text;
        set => tbEmergencyContactPhoneNumber.Text = value;
    }

    public string EmergencyContactPhoneNumberError {
        get => lblEmergencyContactPhoneNumberError.Text;
        set => lblEmergencyContactPhoneNumberError.Text = value;
    }

    private bool _emergencyContactPhoneNumberBorderError = false;
    public void SetEmergencyContactPhoneNumberBorderError(bool isError) {
        _emergencyContactPhoneNumberBorderError = isError;
        tbEmergencyContactPhoneNumber.BorderColor = _emergencyContactPhoneNumberBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
