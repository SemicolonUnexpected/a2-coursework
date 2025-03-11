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
            int staffId = reader.GetInt32(reader.GetOrdinal("StaffId"));

            var order = new OrderModel(id, status, discrepancies, description) {
                Staff = await StaffDAL.GetStaffById(staffId),
                StockItems = await GetStockItemsForOrder(id)
            };

            orders.Add(order);
        }

        return orders;
    }

    public static async Task<List<StockModel>> GetStockItemsForOrder(int orderId) {
        var stockItems = new List<StockModel>();

        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetOrderStockItems", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Id", orderId);

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync()) {
            var stockItem = new StockModel(
                reader.GetString(reader.GetOrdinal("Name")),
                reader.GetString(reader.GetOrdinal("Description")),
                reader.GetInt32(reader.GetOrdinal("Id")),
                reader.GetString(reader.GetOrdinal("Sku")),
                reader.GetInt32(reader.GetOrdinal("Quantity")),
                reader.GetInt32(reader.GetOrdinal("LowQuantity")),
                reader.GetInt32(reader.GetOrdinal("HighQuantity")),
                reader.GetBoolean(reader.GetOrdinal("Archived")),
                reader.GetDecimal(reader.GetOrdinal("UnitCost"))
            ) {
                CostAtTime = reader.GetDecimal(reader.GetOrdinal("UnitCostAtTime"))
            };

            stockItems.Add(stockItem);
        }

        return stockItems;
    }

    private static async Task DeleteAllOrderStock(int orderId) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("DeleteAllOrderStock", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Id", orderId);

        await command.ExecuteNonQueryAsync();
    }

    public static async Task<bool> UpdateOrderStock(int orderId, List<StockModel> stockItems) {
        await DeleteAllOrderStock(orderId);

        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        bool success = true;

        foreach (var stockItem in stockItems) {
            await using SqlCommand command = new("AddOrderStock", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@orderId", orderId);
            command.Parameters.AddWithValue("@stockId", stockItem.Id);

            success &= (await command.ExecuteNonQueryAsync()) > 0;
        }

        return success;
    }

    public static async Task<bool> UpdateOrderStockQuantities(int orderId, IEnumerable<(int stockId, int quantity)> stockIdQuantities) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        bool success = true;

        foreach (var (stockId, quantity) in stockIdQuantities) {
            success &= await UpdateOrderStockQuantity(orderId, stockId, quantity);
        }

        return success;
    }

    public static async Task<bool> UpdateOrderStockQuantity(int orderId, int stockId, int quantity) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateOrderStockQuantity", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@orderId", orderId);
        command.Parameters.AddWithValue("@stockId", stockId);
        command.Parameters.AddWithValue("@quantity", quantity);

        return await command.ExecuteNonQueryAsync() > 0;
    }

    public static async Task<bool> UpdateOrderDescription(int orderId, string description) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateOrderDescription", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", orderId);
        command.Parameters.AddWithValue("@description", description);

        return await command.ExecuteNonQueryAsync() > 0;
    }

    public static async Task<bool> SubmitOrder(int orderId) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateOrderStatus", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", orderId);
        command.Parameters.AddWithValue("@status", "Submitted");

        return await command.ExecuteNonQueryAsync() > 0;
    }

    public static async Task<bool> CreateOrder(OrderModel model) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("CreateOrder", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@status", model.Status);
        command.Parameters.AddWithValue("@discrepancies", model.Discrepancies);
        command.Parameters.AddWithValue("@description", model.Description);
        command.Parameters.AddWithValue("@staffId", model.Staff?.Id);

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        if (!await reader.ReadAsync()) return false;

        int id = reader.GetInt32(reader.GetOrdinal("Id"));

        bool success = true;

        success &= await UpdateOrderStock(id, model.StockItems);
        success &= await UpdateOrderStockQuantities(id, model.StockItems.Select(x => (x.Id, x.Quantity)));

        return success;
    }
}
