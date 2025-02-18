using System.Text;

namespace a2_coursework.Model.Stock;
public class StockModel(string name, string description, int Id, string SKU, int quantity, int lowQuantity, int highQuantity, bool archived) {
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public int Id { get; set; } = Id;
    public int Quantity { get; set; } = quantity;
    public int LowQuantity { get; set; } = lowQuantity;
    public int HighQuantity { get; set; } = highQuantity;
    public bool Archived { get; set; } = archived;
    public string SKU { get; set; } = SKU;

    public string GetSKU() {
        StringBuilder namePart = new();

        foreach (char c in Name) {
            if (char.IsAsciiLetter(char.ToUpper(c))) namePart.Append(c);
            if (namePart.Length >= 3) break;
        }

        return $"{namePart}-{Id.ToString("D3")}";
    }
}
