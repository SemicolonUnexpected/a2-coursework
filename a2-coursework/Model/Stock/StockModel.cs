namespace a2_coursework.Model.Stock;
public class StockModel(string name, string description, int id, string sku, int quantity, int lowQuantity, int highQuantity, bool archived, decimal unitCost) {
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public int Id { get; set; } = id;
    public int Quantity { get; set; } = quantity;
    public int LowQuantity { get; set; } = lowQuantity;
    public int HighQuantity { get; set; } = highQuantity;
    public bool Archived { get; set; } = archived;
    public string Sku { get; set; } = sku;
    public decimal UnitCost { get; set; } = unitCost;
    public decimal CostAtTime { get; set; }
}
