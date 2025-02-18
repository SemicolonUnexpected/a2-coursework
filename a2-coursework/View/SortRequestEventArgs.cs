namespace a2_coursework.View;
public class SortRequestEventArgs : EventArgs {
    public string ColumnName { get; init; }
    public bool SortAscending { get; init; }

    public SortRequestEventArgs(string columnName, bool sortAscending) {
        ColumnName = columnName;
        SortAscending = sortAscending;
    }
}