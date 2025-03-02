namespace a2_coursework.Model.CleaningJob;
public class CleaningJobModel(int id, DateTime startDate, DateTime endDate, string address, int customerId, int staffId, string extraInformation) {
    public int Id { get; set; } = id;
    public DateTime StartDate { get; set; } = startDate;
    public DateTime EndDate { get; set; } = endDate;
    public string Address { get; set; } = address;
    public int CustomerId { get; set; } = customerId;
    public int StaffId { get; set; } = staffId;
    public string ExtraInformation { get; set; } = extraInformation;
}
