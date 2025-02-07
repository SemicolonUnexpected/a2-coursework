using System.Text;

namespace a2_coursework.Model;
public class Stock(string name, string description, int stockId, int quantity, int lowQuantity, int mediumQuantity, int highQuantity) {
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public int StockId { get; set; } = stockId;
    public int Quantity {get; set; } = quantity;
    public int LowQuantity { get; set; } = lowQuantity;
    public int MediumQuantity { get; set; } = mediumQuantity;
    public int HighQuantity { get; set; } = highQuantity;

    public string GetSKU() {
        StringBuilder namePart = new();

        foreach (char c in Name) {
            if (char.IsAsciiLetter(char.ToUpper(c))) namePart.Append(c);
            if (namePart.Length >= 3) break;
        }

        return $"{namePart}-{StockId.ToString("D3")}";
    }
}
