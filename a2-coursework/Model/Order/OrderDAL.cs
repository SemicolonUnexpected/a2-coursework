using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model.Order;

public static class OrderDAL {
    private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    public static async Task<List<OrderModel>> GetOrders() {
        var orders = new List<OrderModel>();

        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetOrders", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync()) {
            int id = reader.GetInt32(reader.GetOrdinal("Id"));
            string status = reader.GetString(reader.GetOrdinal("Status"));
            string discrepancies = reader.GetString(reader.GetOrdinal("Discrepancies"));
            string description = reader.GetString(reader.GetOrdinal("Description"));

            var order = new OrderModel(id, status, discrepancies, description) {
                Staff = await StaffDAL.GetStaffById(id),
                StockItems = await GetStockItemsForOrder(id)
            };

            orders.Add(order);
        }

        return orders;
    }

    private static async Task<List<StockModel>> GetStockItemsForOrder(int orderId) {
        List<StockModel> stockModels = [];
        List<StockModel> stockItems = stockModels;

        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetOrderStockItems", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@orderId", orderId);

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync()) {
            StockModel stockItem = new(
                reader.GetString(reader.GetOrdinal("Name")),
                reader.GetString(reader.GetOrdinal("Description")),
                reader.GetInt32(reader.GetOrdinal("Id")),
                reader.GetString(reader.GetOrdinal("Sku")),
                reader.GetInt32(reader.GetOrdinal("Quantity")),
                reader.GetInt32(reader.GetOrdinal("LowQuantity")),
                reader.GetInt32(reader.GetOrdinal("HighQuantity")),
                reader.GetBoolean(reader.GetOrdinal("Archived"))
            ) {
                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                CostAtTime = reader.GetDecimal(reader.GetOrdinal("CostAtTime"))
            };

            stockItems.Add(stockItem);
        }

        return stockItems;
    }
}
