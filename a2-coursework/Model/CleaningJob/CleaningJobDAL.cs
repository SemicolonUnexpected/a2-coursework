using a2_coursework.Model.CleaningJobOption;
using a2_coursework.Model.Staff;
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

        foreach (CleaningJobModel model in cleaningJobModels) {
            model.StaffIds = await GetCleaningJobStaffIds(model.Id);
            model.CleaningJobOptions = await GetCleaningJobCleaningOptions(model.Id);
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

        foreach (CleaningJobModel model in cleaningJobModels) {
            model.StaffIds = await GetCleaningJobStaffIds(model.Id);
            model.CleaningJobOptions = await GetCleaningJobCleaningOptions(model.Id);
        }

        return cleaningJobModels;
    }

    public static async Task<List<int>> GetCleaningJobStaffIds(int id) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetCleaningJobStaffIds", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<int> cleaningJobStaffIds = [];

        while (await reader.ReadAsync()) {
            cleaningJobStaffIds.Add(reader.GetInt32(reader.GetOrdinal("StaffId")));
        }

        return cleaningJobStaffIds;
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

        List<CleaningJobOptionModel> cleaningJobOptionModels = [];

        while (await reader.ReadAsync()) {
            cleaningJobOptionModels.Add(new CleaningJobOptionModel(
                id: reader.GetInt32(reader.GetOrdinal("Id")),
                name: reader.GetString(reader.GetOrdinal("Name")),
                description: reader.GetString(reader.GetOrdinal("Description")),
                unitCost: reader.GetDecimal(reader.GetOrdinal("UnitCost")),
                archived: reader.GetBoolean(reader.GetOrdinal("Archived"))) {
                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                CostAtTime = reader.GetDecimal(reader.GetOrdinal("UnitCostAtTime")),
            });
        }

        return cleaningJobOptionModels;
    }

    public static async Task<bool> UpdateCleaningJobDetails(int id, string address, string extraInformation) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateCleaningJobDetails", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@address", address);
        command.Parameters.AddWithValue("@extraInformation", extraInformation);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateCleaningJobTimes(int id, DateTime startDate, DateTime endDate) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateCleaningJobTimes", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@startDate", startDate);
        command.Parameters.AddWithValue("@endDate", endDate);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateCleaningJobCustomer(int id, int customerId) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateCleaningJobCustomer", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@customerId", customerId);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    private static async Task DeleteAllCleaningJobCleaningJobOptions(int id) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("DeleteAllCleaningJobCleaningJobOptions", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);

        int rowsAffected = await command.ExecuteNonQueryAsync();
    }

    public static async Task<bool> UpdateCleaningJobCleaningOptions(int id, List<int> cleaningJobOptionIds) {
        await DeleteAllCleaningJobCleaningJobOptions(id);

        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        bool success = false;

        foreach (int cleaningJobOptionId in cleaningJobOptionIds) {
            await using SqlCommand command = new("AddCleaningJobCleaningOption", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cleaningJobId", id);
            command.Parameters.AddWithValue("@cleaningJobOptionId", cleaningJobOptionId);

            success &= (await command.ExecuteNonQueryAsync()) > 0;
        }

        return success;
    }

    public static async Task<List<StaffModel>> GetAvailableCleaners(CleaningJobModel cleaningJob) {
        List<StaffModel> cleaningStaff = await StaffDAL.GetCleaningStaff();
        List<CleaningJobModel> cleaningJobsOnDay = await GetCleaningJobsByDate(cleaningJob.StartDate);

        foreach (CleaningJobModel model in cleaningJobsOnDay) {
            if (model.Id == cleaningJob.Id) continue;

            if (model.StartDate >= cleaningJob.EndDate && model.StartDate <= cleaningJob.EndDate) {
                foreach (int staffId in model.StaffIds) {
                    cleaningStaff.RemoveAll(x => x.Id == staffId);
                }
            }
        }

        return cleaningStaff;
    }
}
