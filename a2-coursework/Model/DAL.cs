using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model;
internal static class DAL {
    private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    public static async Task<(byte[]? hash, byte[]? salt)> GetUserCredentialsAsync(string username) {
        await using SqlConnection connection = new(_connectionString);

        byte[]? hash;
        byte[]? salt;
        await connection.OpenAsync();

        await using SqlCommand command = new("GetUserCredentials", connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.AddWithValue("username", username);

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        if (await reader.ReadAsync()) {
            hash = reader.IsDBNull(reader.GetOrdinal("HashedPassword")) ? null : Convert.FromHexString(reader["HashedPassword"].ToString()!);
            salt = reader.IsDBNull(reader.GetOrdinal("Salt")) ? null : Convert.FromHexString(reader["Salt"].ToString()!);
        }
        else {
            hash = null;
            salt = null;
        }

        return (hash, salt);
    }
}
