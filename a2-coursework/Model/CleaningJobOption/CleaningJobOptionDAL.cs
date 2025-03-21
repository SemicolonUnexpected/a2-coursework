﻿namespace a2_coursework.Model.CleaningJobOption;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

public static class CleaningJobOptionDAL {
    private static readonly string workingDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
    private static readonly string projectDirectoryPath = Directory.GetParent(workingDirectoryPath)!.Parent!.Parent!.Parent!.FullName!;
    private static readonly string _connectionString = string.Format(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, projectDirectoryPath);

    public static async Task<List<CleaningJobOptionModel>> GetCleaningJobOptions() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetCleaningJobOptions", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<CleaningJobOptionModel> jobOptions = [];

        while (await reader.ReadAsync()) {
            jobOptions.Add(
                new CleaningJobOptionModel(
                    id: reader.GetInt32(reader.GetOrdinal("Id")),
                    name: reader.GetString(reader.GetOrdinal("Name")),
                    description: reader.GetString(reader.GetOrdinal("Description")),
                    unitCost: reader.GetDecimal(reader.GetOrdinal("UnitCost")),
                    archived: reader.GetBoolean(reader.GetOrdinal("Archived"))
                )
            );
        }

        return jobOptions;
    }

    public static async Task<List<CleaningJobOptionModel>> GetNonArchivedCleaningJobOptions() {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetNonArchivedCleaningJobOptions", connection);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        List<CleaningJobOptionModel> jobOptions = [];

        while (await reader.ReadAsync()) {
            jobOptions.Add(
                new CleaningJobOptionModel(
                    id: reader.GetInt32(reader.GetOrdinal("Id")),
                    name: reader.GetString(reader.GetOrdinal("Name")),
                    description: reader.GetString(reader.GetOrdinal("Description")),
                    unitCost: reader.GetDecimal(reader.GetOrdinal("UnitCost")),
                    archived: reader.GetBoolean(reader.GetOrdinal("Archived"))
                )
            );
        }

        return jobOptions;
    }

    public static async Task<CleaningJobOptionModel?> GetJobOptionByName(string name) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("GetJobOptionByName", connection);
        command.Parameters.AddWithValue("@name", name);
        command.CommandType = CommandType.StoredProcedure;

        await using SqlDataReader reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync()) {
            return new CleaningJobOptionModel(
                id: reader.GetInt32(reader.GetOrdinal("Id")),
                name: reader.GetString(reader.GetOrdinal("Name")),
                description: reader.GetString(reader.GetOrdinal("Description")),
                unitCost: reader.GetDecimal(reader.GetOrdinal("UnitCost")),
                archived: reader.GetBoolean(reader.GetOrdinal("Archived"))
            );
        }

        return null;
    }

    public static async Task<bool> CreateJobOption(CleaningJobOptionModel jobOption) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("CreateCleaningJobOption", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@name", jobOption.Name);
        command.Parameters.AddWithValue("@description", jobOption.Description);
        command.Parameters.AddWithValue("@unitCost", jobOption.UnitCost);
        command.Parameters.AddWithValue("@archived", jobOption.Archived);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateJobOptionArchived(int id, bool archived) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateCleaningJobOptionArchived", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@archived", archived);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }

    public static async Task<bool> UpdateJobOptionDetails(int id, string name, string description, decimal unitCost) {
        await using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        await using SqlCommand command = new("UpdateCleaningJobOptionDetails", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@name", name);
        command.Parameters.AddWithValue("@description", description);
        command.Parameters.AddWithValue("@unitCost", unitCost);

        int rowsAffected = await command.ExecuteNonQueryAsync();

        return rowsAffected > 0;
    }
}
