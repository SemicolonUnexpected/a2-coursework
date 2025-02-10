using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model;
public static class StockDAL {
    private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    public static async Task<List<StockItem>> GetStock() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStock", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<StockItem> stock = [];

        while (await reader.ReadAsync()) {
            stock.Add(new StockItem(
                Id: reader.GetInt32(reader.GetOrdinal("Id")),
                name: reader.GetString(reader.GetOrdinal("Name")),
                description: reader.GetString(reader.GetOrdinal("Description")),
                SKU: reader.GetString(reader.GetOrdinal("SKU")),
                quantity: reader.GetInt32(reader.GetOrdinal("Quantity")),
                archived: reader.GetBoolean(reader.GetOrdinal("Archived")),
                lowQuantity: reader.GetInt32(reader.GetOrdinal("LowQuantity")),
                highQuantity: reader.GetInt32(reader.GetOrdinal("HighQuantity"))));
        }

        return stock;
    }

    public static async Task<bool> AddStock(StockItem stock) {
        throw new NotImplementedException();
    }

    public static async Task<bool> EditQuantity() {
        throw new NotImplementedException();
    }
}
