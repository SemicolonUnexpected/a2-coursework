namespace a2_coursework.Model; 
public class StockQuantityChange(int id, int stockQuantity, string reasonForQuantityChange, StockItem stockItem, Staff staff, DateTime date) {
    public int Id { get; set; } = id;
    public int StockQuantity { get; set; } = stockQuantity;
    public string ReasonForQuantityChange { get; set; } = reasonForQuantityChange;
    public DateTime Date { get; set; } = date;
    public StockItem StockItem { get; set; } = stockItem;
    public Staff Staff { get; set; } = staff;
}
