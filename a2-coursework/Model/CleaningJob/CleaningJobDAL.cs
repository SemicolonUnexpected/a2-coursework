using a2_coursework.Model.CleaningJobOption;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace a2_coursework.Model.CleaningJob; 
public class CleaningJobDAL {
    private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    public static async Task<List<CleaningJobModel>> GetCleaningJobs() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetCleaningJobs", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<CleaningJobModel> cleaningJobModels = [];

        while (await reader.ReadAsync()) {
            cleaningJobModels.Add(new CleaningJobModel(
                id: reader.GetInt32(reader.GetOrdinal("Id")),
                startDate: reader.GetDateTime(reader.GetOrdinal("Date")),
                endDate: reader.GetDateTime(reader.GetOrdinal("Duration")),
                address: reader.GetString(reader.GetOrdinal("Address")),
                customerId: reader.GetInt32(reader.GetOrdinal("CustomerId")),
                staffId: reader.GetInt32(reader.GetOrdinal("StaffId")),
                extraInformation: reader.GetString(reader.GetOrdinal("ExtraInformation"))));
        }

        return cleaningJobModels;
    }

    public static async Task<List<CleaningJobModel>> GetCleaningJobsByDate(DateTime date) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetCleaningJobsByDate", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@date", date);

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<CleaningJobModel> cleaningJobModels = [];

        while (await reader.ReadAsync()) {
            int id = reader.GetInt32(reader.GetOrdinal("Id"));

            cleaningJobModels.Add(new CleaningJobModel(
                id: reader.GetInt32(reader.GetOrdinal("Id")),
                startDate: reader.GetDateTime(reader.GetOrdinal("StartDate")),
                endDate: reader.GetDateTime(reader.GetOrdinal("EndDate")),
                address: reader.GetString(reader.GetOrdinal("Address")),
                customerId: reader.GetInt32(reader.GetOrdinal("CustomerId")),
                staffId: reader.GetInt32(reader.GetOrdinal("StaffId")),
                extraInformation: reader.GetString(reader.GetOrdinal("ExtraInformation"))));
        }

        return cleaningJobModels;
    }

    public static async Task<bool> DeleteCleaningJob(int id) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("DeleteCleaningJob", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<List<CleaningJobOptionModel>> GetCleaningJobCleaningOptions(int id) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetCleaningJobCleaningOptions", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<CleaningJobOptionModel> cleaningJobModels = [];

        while (await reader.ReadAsync()) {
            cleaningJobModels.Add(new CleaningJobOptionModel(
                id: reader.GetInt32(reader.GetOrdinal("Id")),
                name: reader.GetString(reader.GetOrdinal("Name")),
                description: reader.GetString(reader.GetOrdinal("Description")),
                unitCost: reader.GetDecimal(reader.GetOrdinal("UnitCost")),
                archived: reader.GetBoolean(reader.GetOrdinal("Archived"))) { 
                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                CostAtTime = reader.GetDecimal(reader.GetOrdinal("CostAtTime")),
            });
        }

        return cleaningJobModels;
    }
}
