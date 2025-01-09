using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model; 
internal static class DAL {
    private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    public static bool GetUserCredentials(string username, out byte[]? hash, out byte[]? salt) {
        using SqlConnection connection = new(_connectionString);

        try {
            connection.Open();

            using SqlCommand command = new("GetUserCredentials", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("username", username);

            using SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read()) {
                hash = null;
                salt = null;
                return false;
            }
            else {
                hash = Convert.FromHexString(reader["HashedPassword"].ToString()!);
                salt = Convert.FromHexString(reader["Salt"].ToString()!);
                return true;
            }
        }
        catch (SqlException e) {
            MessageBox.Show($"Error connecting to database: {e.Message}");

            hash = null;
            salt = null;
            return false;
        }
    }
}
