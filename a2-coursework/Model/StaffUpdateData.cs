using a2_coursework.Theming;

namespace a2_coursework.Model;
public struct StaffUpdateData : IStaff {
    public StaffUpdateData() {
    }

    public int StaffID { get; init; }
    public string? Username { get; init; } = null;
    public bool? Active { get; init; } = null;
    public PrivilegeLevel? PrivilegeLevel { get; init; } = null;
    public string? Forename { get; init; } = null;
    public string? Surname { get; init; } = null;
    public DateTime? DateOfBirth { get; init; } = null;
    public string? Email { get; init; } = null;
    public string? PhoneNumber { get; init; } = null;
    public string? EmergencyContactForename { get; init; } = null;
    public string? EmergencyContactSurname { get; init; } = null;
    public string? EmergencyContactPhoneNumber { get; init; } = null;
    public string? Address { get; init; } = null;
    public string? Position { get; init; } = null;
    public string? Department { get; init; } = null;
    public Theme? Theme { get; init; } = null;
}
