using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;

namespace a2_coursework.Model.Order;

public class OrderModel(int id, string status, string discrepancies, string description) {
    public int Id { get; set; } = id;
    public StaffModel? Staff { get; set; }
    public string Status { get; set; } = status;
    public string Discrepancies { get; set; } = discrepancies;
    public string Description { get; set; } = description;
    public List<StockModel> StockItems { get; set; } = [];
}
