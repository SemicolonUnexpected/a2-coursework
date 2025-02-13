﻿namespace a2_coursework.View.Interfaces.Users.Settings;
public interface ISettingsView : IChildView {
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public bool SaveVisible { set; }
    public bool IsLoading { get; set; }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
