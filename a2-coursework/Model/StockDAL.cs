using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model; 
public static class StockDAL {
    private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    public async Task<List<Stock>> GetStock() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStock", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<Stock> stock = new();

        if (await reader.ReadAsync()) {
            stock.Add(new Stock(
                stockId: reader.GetInt32(reader.GetOrdinal(""));
                );
        }
        else {
            hash = null;
            salt = null;
        }

        return (hash, salt);
    }
}
