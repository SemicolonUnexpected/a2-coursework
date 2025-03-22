using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model.LoginAttempt;
public static class LoginAttemptDAL {
    private static readonly string workingDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
    private static readonly string projectDirectoryPath = Directory.GetParent(workingDirectoryPath)!.Parent!.Parent!.Parent!.FullName!;
    private static readonly string _connectionString = string.Format(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, projectDirectoryPath);

    public static async Task<bool> LogLoginAttempt(string username, DateTime attemptTime, bool success) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("LogLoginAttempt", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@username", username);
        command.Parameters.AddWithValue("@attemptTime", attemptTime);
        command.Parameters.AddWithValue("@success", success);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<List<LoginAttemptModel>> GetLoginAttempts() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetLoginAttempts", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<LoginAttemptModel> loginAttempts = [];

        while (await reader.ReadAsync()) {
            loginAttempts.Add(new LoginAttemptModel(
                reader.GetString(reader.GetOrdinal("Username")),
                reader.GetDateTime(reader.GetOrdinal("AttemptTime")),
                reader.GetBoolean(reader.GetOrdinal("Successful"))
                ));
        }

        return loginAttempts;
    }
}