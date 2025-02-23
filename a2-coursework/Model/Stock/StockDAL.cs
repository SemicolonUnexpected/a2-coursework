using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model.Stock;
public static class StockDAL {
    private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    public static async Task<List<StockModel>> GetStock() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStock", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<StockModel> stock = [];

        while (await reader.ReadAsync()) {
            int id = reader.GetInt32(reader.GetOrdinal("Id"));
            stock.Add(
                new StockModel(Id: id,
                    name: reader.GetString(reader.GetOrdinal("Name")),
                    description: reader.GetString(reader.GetOrdinal("Description")),
                    SKU: reader.GetString(reader.GetOrdinal("SKU")),
                    quantity: reader.GetInt32(reader.GetOrdinal("Quantity")),
                    archived: reader.GetBoolean(reader.GetOrdinal("Archived")),
                    lowQuantity: reader.GetInt32(reader.GetOrdinal("LowQuantity")),
                    highQuantity: reader.GetInt32(reader.GetOrdinal("HighQuantity"))
                )
            );
        }

        return stock;
    }

    public static async Task<bool> CreateStock(StockModel stock, int staffId, DateTime date, string reasonForQuantityChange) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("CreateStock", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@name", stock.Name);
        command.Parameters.AddWithValue("@description", stock.Description);
        command.Parameters.AddWithValue("@sku", stock.Sku);
        command.Parameters.AddWithValue("@quantity", stock.Quantity);
        command.Parameters.AddWithValue("@staffId", staffId);
        command.Parameters.AddWithValue("@date", date);
        command.Parameters.AddWithValue("@highQuantity", stock.HighQuantity);
        command.Parameters.AddWithValue("@lowQuantity", stock.LowQuantity);
        command.Parameters.AddWithValue("@archived", stock.Archived);
        command.Parameters.AddWithValue("@reasonForQuantityChange", reasonForQuantityChange);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateQuantity(int stockId, int staffId, int quantity, DateTime date, string reasonForQuantityChange) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStockQuantity", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("stockId", stockId);
        command.Parameters.AddWithValue("staffId", staffId);
        command.Parameters.AddWithValue("quantity", quantity);
        command.Parameters.AddWithValue("date", date);
        command.Parameters.AddWithValue("reasonForQuantityChange", reasonForQuantityChange);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateArchived(int id, bool archived) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStockArchived", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("Id", id);
        command.Parameters.AddWithValue("archived", archived);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> SkuExists(string sku) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStockBySKU", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("sku", sku);

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        return reader.HasRows;
    }

    public static async Task<bool> UpdateDetails(int id, string name, string description, string sku, bool archived) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStockDetails", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("id", id);
        command.Parameters.AddWithValue("name", name);
        command.Parameters.AddWithValue("description", description);
        command.Parameters.AddWithValue("sku", sku);
        command.Parameters.AddWithValue("archived", archived);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateWarnings(int id, int highQuantity, int lowQuantity) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStockWarnings", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("id", id);
        command.Parameters.AddWithValue("lowQuantity", lowQuantity);
        command.Parameters.AddWithValue("highQuantity", highQuantity);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<List<StockQuantityChange>> GetStockQuantityChanges() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStockQuantityChanges", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<StockQuantityChange> stockQuantityChanges = [];

        while (await reader.ReadAsync()) {
            stockQuantityChanges.Add(
                new StockQuantityChange(
                    id: reader.GetInt32(reader.GetOrdinal("Id")),
                    quantity: reader.GetInt32(reader.GetOrdinal("Quantity")),
                    reasonForQuantityChange: reader.GetString(reader.GetOrdinal("ReasonForQuantityChange")),
                    date: reader.GetDateTime(reader.GetOrdinal("Date")),
                    stockId: reader.GetInt32(reader.GetOrdinal("StockId")),
                    stockName: reader.GetString(reader.GetOrdinal("StockName")),
                    stockArchived: reader.GetBoolean(reader.GetOrdinal("StockArchived")),
                    staffId: reader.GetInt32(reader.GetOrdinal("EditedByStaff")),
                    staffForename: reader.GetString(reader.GetOrdinal("StaffForename")),
                    staffSurname: reader.GetString(reader.GetOrdinal("StaffSurname")),
                    staffUsername: reader.GetString(reader.GetOrdinal("StaffUsername")),
                    stockSku: reader.GetString(reader.GetOrdinal("StockSKU"))
                )
            );
        }

        return stockQuantityChanges;
    }
}
