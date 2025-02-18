using a2_coursework.Theming;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model.Staff;
internal static class StaffDAL {
    private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    public static async Task<(byte[]? hash, byte[]? salt)> GetStaffCredentials(string username) {
        byte[]? hash;
        byte[]? salt;

        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStaffCredentials", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("username", username);

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        if (await reader.ReadAsync()) {
            hash = Convert.FromHexString(reader.GetString(reader.GetOrdinal("HashedPassword")));
            salt = Convert.FromHexString(reader.GetString(reader.GetOrdinal("Salt")));
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

    public static async Task<StaffModel?> GetStaffByUsername(string username) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStaffByUsername", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("username", username);

        await using SqlDataReader reader = command.ExecuteReader();
        if (await reader.ReadAsync()) {
            // Handle potential null values safely
            return new StaffModel(
                staffID: reader.GetInt32(reader.GetOrdinal("StaffID")),
                hashedPassword: Convert.FromHexString(reader.GetString(reader.GetOrdinal("HashedPassword"))),
                salt: Convert.FromHexString(reader["Salt"].ToString()!),
                lastPasswordChange: reader.GetDateTime(reader.GetOrdinal("LastPasswordChange")),
                username: reader.GetString(reader.GetOrdinal("Username")),
                archived: reader.GetBoolean(reader.GetOrdinal("Archived")),
                forename: reader.GetString(reader.GetOrdinal("Forename")),
                surname: reader.GetString(reader.GetOrdinal("Surname")),
                dateOfBirth: reader.IsDBNull("DateOfBirth") ? null : reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                email: reader.GetString(reader.GetOrdinal("Email")),
                phoneNumber: reader.GetString(reader.GetOrdinal("PhoneNumber")),
                address: reader.GetString(reader.GetOrdinal("Address")),
                emergencyContactForename: reader.GetString(reader.GetOrdinal("EmergencyContactForename")),
                emergencyContactSurname: reader.GetString(reader.GetOrdinal("EmergencyContactSurname")),
                emergencyContactPhoneNumber: reader.GetString(reader.GetOrdinal("EmergencyContactPhoneNumber")),
                privilegeLevel: ConvertToPrivilegeLevel(reader.GetString(reader.GetOrdinal("PrivilegeLevel"))),
                theme: reader.IsDBNull("AppearanceSettings") ? new Theme(AppearanceTheme.Dark, true, "Bahnshrift") : Newtonsoft.Json.JsonConvert.DeserializeObject<Theme>(reader.GetString(reader.GetOrdinal("AppearanceSettings")))!
            );
        }
        return null;
    }

    public static async Task<bool> UpdatePersonalDetails(int staffId, string forename, string surname, DateTime? dateOfBirth) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffPersonalInformation", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("staffId", staffId);
        command.Parameters.AddWithValue("forename", forename);
        command.Parameters.AddWithValue("surname", surname);
        command.Parameters.AddWithValue("dateOfBirth", dateOfBirth ?? (object)DBNull.Value);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateContactDetails(int staffId, string email, string phoneNumber, string address) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffContactDetails", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("staffId", staffId);
        command.Parameters.AddWithValue("email", email);
        command.Parameters.AddWithValue("phoneNumber", phoneNumber);
        command.Parameters.AddWithValue("address", address);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateEmergencyContact(int staffId, string forename, string surname, string phoneNumber) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffEmergencyContact", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("staffId", staffId);
        command.Parameters.AddWithValue("emergencyContactForename", forename);
        command.Parameters.AddWithValue("emergencyContactSurname", surname);
        command.Parameters.AddWithValue("emergencyContactPhoneNumber", phoneNumber);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateAppearanceSettings(int staffId, Theme theme) {
        string jsonTheme = Newtonsoft.Json.JsonConvert.SerializeObject(theme, Theme.JsonSettings);

        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffAppearanceSettings", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("staffId", staffId);
        command.Parameters.AddWithValue("appearanceSettings", jsonTheme);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdatePassword(int staffId, string hashedPassword, string salt) {

        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffPassword", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("staffId", staffId);
        command.Parameters.AddWithValue("hashedPassword", hashedPassword);
        command.Parameters.AddWithValue("salt", salt);
        command.Parameters.AddWithValue("lastPasswordChange", DateTime.Now);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<List<StaffModel>> GetStaff() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStaff", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        var staffList = new List<StaffModel>();

        while (await reader.ReadAsync()) {
            staffList.Add(new StaffModel(
                staffID: reader.GetInt32(reader.GetOrdinal("StaffID")),
                hashedPassword: Convert.FromHexString(reader.GetString(reader.GetOrdinal("HashedPassword"))),
                salt: Convert.FromHexString(reader.GetString(reader.GetOrdinal("Salt"))),
                lastPasswordChange: reader.GetDateTime(reader.GetOrdinal("LastPasswordChange")),
                username: reader.GetString(reader.GetOrdinal("Username")),
                archived: reader.GetBoolean(reader.GetOrdinal("Archived")),
                forename: reader.GetString(reader.GetOrdinal("Forename")),
                surname: reader.GetString(reader.GetOrdinal("Surname")),
                dateOfBirth: reader.IsDBNull("DateOfBirth") ? null : reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                email: reader.GetString(reader.GetOrdinal("Email")),
                phoneNumber: reader.GetString(reader.GetOrdinal("PhoneNumber")),
                address: reader.GetString(reader.GetOrdinal("Address")),
                emergencyContactForename: reader.GetString(reader.GetOrdinal("EmergencyContactForename")),
                emergencyContactSurname: reader.GetString(reader.GetOrdinal("EmergencyContactSurname")),
                emergencyContactPhoneNumber: reader.GetString(reader.GetOrdinal("EmergencyContactPhoneNumber")),
                privilegeLevel: ConvertToPrivilegeLevel(reader.GetString(reader.GetOrdinal("PrivilegeLevel"))),
                theme: reader.IsDBNull("AppearanceSettings") ? new Theme(AppearanceTheme.Dark, true, "Bahnshrift") : Newtonsoft.Json.JsonConvert.DeserializeObject<Theme>(reader.GetString(reader.GetOrdinal("AppearanceSettings")))!
            ));
        }

        return staffList;
    }

    public static async Task<bool> UpdateArchived(int staffId, bool archived) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffArchived", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("staffId", staffId);
        command.Parameters.AddWithValue("archived", archived);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    private static PrivilegeLevel ConvertToPrivilegeLevel(string value) => value switch {
        "admin" => PrivilegeLevel.Admin,
        "office" => PrivilegeLevel.Office,
        "manager" => PrivilegeLevel.Manager,
        "cleaner" => PrivilegeLevel.Cleaner,
        "cleaningmanager" => PrivilegeLevel.CleaningManager,
        _ => throw new NotImplementedException("Not a valid user priviledge level"),
    };
}
