using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model.Customer; 
public static class CustomerDAL {
    private static readonly string workingDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
    private static readonly string projectDirectoryPath = Directory.GetParent(workingDirectoryPath)!.Parent!.Parent!.Parent!.FullName!;
    private static readonly string _connectionString = string.Format(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, projectDirectoryPath);

    public static async Task<List<CustomerModel>> GetCustomers() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetCustomers", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<CustomerModel> customers = [];

        while (await reader.ReadAsync()) {
            customers.Add(
                new CustomerModel(
                    id: reader.GetInt32(reader.GetOrdinal("Id")),
                    forename: reader.GetString(reader.GetOrdinal("Forename")),
                    surname: reader.GetString(reader.GetOrdinal("Surname")),
                    email: reader.GetString(reader.GetOrdinal("Email")),
                    phoneNumber: reader.GetString(reader.GetOrdinal("PhoneNumber")),
                    address: reader.GetString(reader.GetOrdinal("Address")),
                    archived: reader.GetBoolean(reader.GetOrdinal("Archived"))
                )
            );
        }

        return customers;
    }

    public static async Task<CustomerModel?> GetCustomerById(int id) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetCustomerById", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        if (await reader.ReadAsync()) {
            return new CustomerModel(
                id: reader.GetInt32(reader.GetOrdinal("Id")),
                forename: reader.GetString(reader.GetOrdinal("Forename")),
                surname: reader.GetString(reader.GetOrdinal("Surname")),
                email: reader.GetString(reader.GetOrdinal("Email")),
                phoneNumber: reader.GetString(reader.GetOrdinal("PhoneNumber")),
                address: reader.GetString(reader.GetOrdinal("Address")),
                archived: reader.GetBoolean(reader.GetOrdinal("Archived"))
            );
        }

        return null;
    }

    public static async Task<List<CustomerModel>> GetNonArchivedCustomers() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetNonArchivedCustomers", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<CustomerModel> customers = [];

        while (await reader.ReadAsync()) {
            customers.Add(
                new CustomerModel(
                    id: reader.GetInt32(reader.GetOrdinal("Id")),
                    forename: reader.GetString(reader.GetOrdinal("Forename")),
                    surname: reader.GetString(reader.GetOrdinal("Surname")),
                    email: reader.GetString(reader.GetOrdinal("Email")),
                    phoneNumber: reader.GetString(reader.GetOrdinal("PhoneNumber")),
                    address: reader.GetString(reader.GetOrdinal("Address")),
                    archived: reader.GetBoolean(reader.GetOrdinal("Archived"))
                )
            );
        }

        return customers;
    }
    public static async Task<bool> AddCustomer(CustomerModel customer) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("AddCustomer", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@forename", customer.Forename);
        command.Parameters.AddWithValue("@surname", customer.Surname);
        command.Parameters.AddWithValue("@email", customer.Email);
        command.Parameters.AddWithValue("@phoneNumber", customer.PhoneNumber);
        command.Parameters.AddWithValue("@archived", customer.Archived);
        command.Parameters.AddWithValue("@address", customer.Address);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateCustomerArchived(int id, bool archived) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateCustomerArchived", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@archived", archived);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateCustomerPersonalDetails(int id, string forename, string surname, bool archived) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateCustomerPersonalDetails", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@forename", forename);
        command.Parameters.AddWithValue("@surname", surname);
        command.Parameters.AddWithValue("@archived", archived);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateCustomerContactDetails(int id, string phoneNumber, string email, string address) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateCustomerContactDetails", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@address", address);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> CustomerInFutureJob(int id) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("CountCustomersInFutureJobs", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@customerId", id);

        using SqlDataReader reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync()) {
            int numberOfReferences = reader.GetInt32(reader.GetOrdinal("Count"));

            return numberOfReferences > 0;
        }

        return false;
    }
}
