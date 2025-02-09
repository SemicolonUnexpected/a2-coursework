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

        throw new NotImplementedException("Need an inner join ");

        if (await reader.ReadAsync()) {
            stock.Add(new StockItem(
                stockId: reader.GetInt32(reader.GetOrdinal("")),
                name: reader.GetString(reader.GetOrdinal("")),
                description: reader.GetString(reader.GetOrdinal("")),
                quantity: reader.GetInt32(reader.GetOrdinal("")),
                lowQuantity: reader.GetInt32(reader.GetOrdinal("")),
                highQuantity: reader.GetInt32(reader.GetOrdinal(""))));
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
