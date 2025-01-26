using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model;
internal static class StaffDAL {
    private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    public static async Task<(byte[]? hash, byte[]? salt)> GetUserCredentialsAsync(string username) {
        byte[]? hash;
        byte[]? salt;

        await using SqlConnection connection = new(_connectionString);
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

    public static async Task<bool> LogLoginAttempt(string username, DateTime attemptTime, bool success) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("LogLoginAttempt", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("username", username);
        command.Parameters.AddWithValue("attemptTime", attemptTime);
        command.Parameters.AddWithValue("success", success);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<Staff?> GetUser(string username) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetUser", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("username", username);

        await using SqlDataReader reader = command.ExecuteReader();
        if (await reader.ReadAsync()) {
            // Handle potential null values safely
            return new Staff(
                staffID: reader.GetInt32(reader.GetOrdinal("StaffID")),
                username: reader.GetString(reader.GetOrdinal("Username")),
                active: reader.GetBoolean(reader.GetOrdinal("Active")),
                forename: reader.GetString(reader.GetOrdinal("Forename")),
                surname: reader.GetString(reader.GetOrdinal("Surname")),
                dateOfBirth: reader.IsDBNull("DateOfBirth") ? null : reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                email: reader.GetString(reader.GetOrdinal("Email")),
                phoneNumber: reader.GetString(reader.GetOrdinal("PhoneNumber")),
                address: reader.GetString(reader.GetOrdinal("Address")),
                emergencyContactForename: reader.IsDBNull("EmergencyContactForename") ? null : reader.GetString(reader.GetOrdinal("EmergencyContactForename")),
                emergencyContactSurname: reader.IsDBNull("EmergencyContactSurname") ? null : reader.GetString(reader.GetOrdinal("EmergencyContactSurname")),
                emergencyContactPhoneNumber: reader.IsDBNull("EmergencyContactPhoneNumber") ? null : reader.GetString(reader.GetOrdinal("EmergencyContactPhoneNumber")),
                department: reader.GetString(reader.GetOrdinal("DepartmentName")),
                privilegeLevel: ConvertToPrivilegeLevel(reader.GetString(reader.GetOrdinal("PrivilegeLevel"))),
                theme: reader.IsDBNull("UserAppearanceSettings") ? new Theming.Theme(Theming.AppearanceTheme.Dark, true) : Newtonsoft.Json.JsonConvert.DeserializeObject<Theming.Theme>(reader.GetString(reader.GetOrdinal("UserAppearanceSettings")))!
            );
        }
        return null;
    }

    public static async Task<bool> UpdateDateOfBirth(int staffId, DateTime dateOfBirth) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffDateOfBirth", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("staffId", staffId);
        command.Parameters.AddWithValue("dateOfBirth", dateOfBirth);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }
    
    public static async Task<bool> UpdateForename(int staffId, DateTime forename) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffDateOfBirth", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("staffId", staffId);
        command.Parameters.AddWithValue("forename", forename);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateSurname(int staffId, string surname) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffDateOfBirth", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("staffId", staffId);
        command.Parameters.AddWithValue("surname", surname);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<string[]> GetDepartment() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetDepartment", connection);
        command.CommandType = CommandType.StoredProcedure;

        using SqlDataReader reader = command.ExecuteReader();

        List<string> rows = new();
        while (await reader.ReadAsync()) {
            rows.Add(reader["Departments"].ToString()!);
        }

        return [.. rows];
    }

    private static PrivilegeLevel ConvertToPrivilegeLevel(string value) => value switch {
        "admin" => PrivilegeLevel.Admin,
        "user" => PrivilegeLevel.User,
        "manager" => PrivilegeLevel.Manager,
        _ => throw new NotImplementedException("Not a valid user priviledge level"),
    };
}
