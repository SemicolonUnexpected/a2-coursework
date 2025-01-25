using a2_coursework.Theming;

namespace a2_coursework.Model;
internal interface IStaff {
    public int StaffID { get; }
    public string? Username { get; }
    public bool? Active { get; }
    public PrivilegeLevel? PrivilegeLevel { get; }
    public string? Forename { get; }
    public string? Surname { get; }
    public DateTime? DateOfBirth { get; }
    public string? Email { get; }
    public string? PhoneNumber { get; }
    public string? EmergencyContactForename { get; }
    public string? EmergencyContactSurname { get; }
    public string? EmergencyContactPhoneNumber { get; }
    public string? Address { get; }
    public string? Position { get; }
    public string? Department { get; }
    public Theme? Theme { get; }
}
