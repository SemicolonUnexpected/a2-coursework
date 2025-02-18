namespace a2_coursework.Model.StockModel;

public class StockQuantityChange(int id, int quantity, string reasonForQuantityChange, DateTime date, int stockId, string stockName, bool stockArchived,int staffId, string staffForename, string staffSurname, string staffUsername, string stockSku) {
    public int Id { get; init; } = id;
    public int Quantity { get; init; } = quantity;
    public string ReasonForQuantityChange { get; init; } = reasonForQuantityChange;
    public DateTime Date { get; init; } = date;

    public int StockId { get; init; } = stockId;
    public string StockName { get; init; } = stockName;
    public string StockSKU { get; init; } = stockSku;
    public bool StockArchived { get; init; } = stockArchived;

    public int StaffId { get; init; } = staffId;
    public string StaffForename { get; init; } = staffForename;
    public string StaffSurname { get; init; } = staffSurname;
    public string StaffUsername { get; init; } = staffUsername;
}