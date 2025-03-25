using a2_coursework.Theming;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model.Staff;
internal static class StaffDAL {
    private static readonly string workingDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
    private static readonly string projectDirectoryPath = Directory.GetParent(workingDirectoryPath)!.Parent!.Parent!.Parent!.FullName!;
    private static readonly string _connectionString = string.Format(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, projectDirectoryPath);

    public static async Task<(byte[]? hash, byte[]? salt)> GetStaffCredentials(string username) {
        byte[]? hash;
        byte[]? salt;

        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStaffCredentials", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@username", username);

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

    public static async Task<StaffModel?> GetStaffByUsername(string username) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStaffByUsername", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@username", username);

        await using SqlDataReader reader = command.ExecuteReader();
        if (await reader.ReadAsync()) {
            return new StaffModel(
                id: reader.GetInt32(reader.GetOrdinal("Id")),
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
                theme: reader.IsDBNull("AppearanceSettings") ? new Theme(AppearanceTheme.Dark, true, "Bahnschrift") : Newtonsoft.Json.JsonConvert.DeserializeObject<Theme>(reader.GetString(reader.GetOrdinal("AppearanceSettings")))!
            );
        }
        return null;
    }

    public static async Task<StaffModel?> GetStaffById(int id) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStaffById", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);

        await using SqlDataReader reader = command.ExecuteReader();
        if (await reader.ReadAsync()) {
            // Handle potential null values safely
            return new StaffModel(
                id: reader.GetInt32(reader.GetOrdinal("Id")),
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
                theme: reader.IsDBNull("AppearanceSettings") ? new Theme(AppearanceTheme.Dark, true, "Bahnschrift") : Newtonsoft.Json.JsonConvert.DeserializeObject<Theme>(reader.GetString(reader.GetOrdinal("AppearanceSettings")))!
            );
        }
        return null;
    }

    public static async Task<bool> UpdateStaffPersonalInformation(int id, string forename, string surname, DateTime? dateOfBirth) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffPersonalInformation", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@forename", forename);
        command.Parameters.AddWithValue("@surname", surname);
        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth ?? (object)DBNull.Value);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateStaffContactDetails(int id, string email, string phoneNumber, string address) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffContactDetails", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@staffId", id);
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
        command.Parameters.AddWithValue("@address", address);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateStaffEmergencyContactInformation(int id, string forename, string surname, string phoneNumber) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffEmergencyContact", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@emergencyContactForename", forename);
        command.Parameters.AddWithValue("@emergencyContactSurname", surname);
        command.Parameters.AddWithValue("@emergencyContactPhoneNumber", phoneNumber);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateStaffAppearanceSettings(int id, Theme theme) {
        string jsonTheme = Newtonsoft.Json.JsonConvert.SerializeObject(theme, Theme.JsonSettings);

        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffAppearanceSettings", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@appearanceSettings", jsonTheme);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdatePassword(int id, string hashedPassword, string salt) {

        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffPassword", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@hashedPassword", hashedPassword);
        command.Parameters.AddWithValue("@salt", salt);
        command.Parameters.AddWithValue("@lastPasswordChange", DateTime.Now);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<List<StaffModel>> GetStaff() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStaff", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<StaffModel> staff = [];

        while (await reader.ReadAsync()) {
            staff.Add(new StaffModel(
                id: reader.GetInt32(reader.GetOrdinal("Id")),
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
                theme: reader.IsDBNull("AppearanceSettings") ? new Theme(AppearanceTheme.Dark, true, "Bahnschrift") : Newtonsoft.Json.JsonConvert.DeserializeObject<Theme>(reader.GetString(reader.GetOrdinal("AppearanceSettings")))!
            ));
        }

        return staff;
    }

    public static async Task<bool> UpdateStaffArchived(int id, bool archived) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffArchived", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@archived", archived);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateStaffCredentials(int id, string username, PrivilegeLevel privilegeLevel) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateStaffCredentials", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@username", username);
        command.Parameters.AddWithValue("@privilegeLevel", (int)privilegeLevel);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> CreateStaff(string username, string hashedPassword, string salt, string forename, string surname, DateTime? dateOfBirth, string email, string phoneNumber, string address, string emergencyContactForename, string emergencyContactSurname, string emergencyContactPhoneNumber, int privilegeLevelId) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("CreateStaff", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@username", username);
        command.Parameters.AddWithValue("@hashedPassword", hashedPassword);
        command.Parameters.AddWithValue("@salt", salt);
        command.Parameters.AddWithValue("@forename", forename);
        command.Parameters.AddWithValue("@surname", surname);
        command.Parameters.AddWithValue("@dateOfBirth", (object?)dateOfBirth ?? DBNull.Value);
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
        command.Parameters.AddWithValue("@address", address);
        command.Parameters.AddWithValue("@emergencyContactForename", emergencyContactForename);
        command.Parameters.AddWithValue("@emergencyContactSurname", emergencyContactSurname);
        command.Parameters.AddWithValue("@emergencyContactPhoneNumber", emergencyContactPhoneNumber);
        command.Parameters.AddWithValue("@privilegeLevelId", privilegeLevelId);

        int rowsAffected = await command.ExecuteNonQueryAsync();
        return rowsAffected > 0;
    }

    public static async Task<List<StaffModel>> GetCleaningStaff() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetStaffByPrivilege", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@privilegeLevelId", (int)PrivilegeLevel.Cleaner);

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<StaffModel> staff = [];

        while (await reader.ReadAsync()) {
            staff.Add(new StaffModel(
                id: reader.GetInt32(reader.GetOrdinal("Id")),
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
                privilegeLevel: (PrivilegeLevel)reader.GetInt32(reader.GetOrdinal("PrivilegeLevelId")),
                theme: reader.IsDBNull("AppearanceSettings") ? new Theme(AppearanceTheme.Dark, true, "Bahnschrift") : Newtonsoft.Json.JsonConvert.DeserializeObject<Theme>(reader.GetString(reader.GetOrdinal("AppearanceSettings")))!
            ));
        }

        return staff;
    }


    private static PrivilegeLevel ConvertToPrivilegeLevel(string value) => value switch {
        "admin" => PrivilegeLevel.Admin,
        "office" => PrivilegeLevel.Office,
        "manager" => PrivilegeLevel.Manager,
        "cleaner" => PrivilegeLevel.Cleaner,
        "cleaningmanager" => PrivilegeLevel.CleaningManager,
        _ => throw new NotImplementedException("Not a valid user privilege level"),
    };
}
