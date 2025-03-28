﻿using a2_coursework.View;
using a2_coursework.View.Customer;

namespace a2_coursework.Interfaces.Customer; 
public interface IDisplayCustomerView : IDisplayView<DisplayCustomerModel>, IChildView {
    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public string SearchText { get; set; }
    public string DataGridText { set; }
    public bool ShowArchivedItems { get; }
    public bool SelectedItemArchived { set; get; }
    public DisplayCustomerModel? SelectedItem { get; }

    public void DisableAll();
    public void EnableAll();

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
