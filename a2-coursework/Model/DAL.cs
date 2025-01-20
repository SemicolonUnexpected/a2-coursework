using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model;
internal static class DAL {
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

    public static async Task LoginAttempt(string username, DateTime dateTime, bool success) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("LoginAttempt", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("username", username);
        command.Parameters.AddWithValue("attemptTime", dateTime);
        command.Parameters.AddWithValue("success", success);

        await command.ExecuteNonQueryAsync();
    }

    public static async Task<User?> GetUser(string username) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetUser", connection);
        command.Parameters.AddWithValue("username", username);
        
        await using SqlDataReader reader = command.ExecuteReader();
        if (await reader.ReadAsync()) {
            try {
                return new User(
                    staffID: (int)reader["StaffID"],
                    username: (string)reader["Username"],
                    forename: (string)reader["Forename"],
                    surname: (string)reader["Surname"],
                    email: (string)reader["Email"],
                    phoneNumber: (string)reader["PhoneNumber"],
                    emergencyContactForename: (string)reader["EmergencyContactForename"],
                    emergencyContactSurname: (string)reader["EmergencyContactSurname"],
                    emergencyContactPhoneNumber: (string)reader["EmergencyContactPhoneNumber"],
                    address: (string)reader["Address"],
                    position: (string)reader["Position"],
                    department: (string)reader["Department"],
                    active: (bool)reader["Active"],
                    priviledgeLevel: ConvertToPrivilegeLevel(reader["PrivildegeLevel"].ToString()!)
                    );
            }
            catch {
                return null;
            }
        }
        return null;
    }

    public static async Task GetDepartment() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = connection.CreateCommand("GetDeparment", connection);
        command.CommandType = CommandType.StoredProcedure;

        using SqlDataReader reader = command.ExecuteReader();
        while (await reader.ReadAsync()) {

        }
    }

    private static PriviledgeLevel ConvertToPrivilegeLevel(string value) => value switch {
        "admin" => PriviledgeLevel.Admin,
        "user" => PriviledgeLevel.User,
        "manager" => PriviledgeLevel.Manager,
        _ => throw new NotImplementedException("Not a valid user priviledge level"),
    };

}
