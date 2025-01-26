using a2_coursework.Theming;

namespace a2_coursework.Model;

public class Staff(int staffID, string username, bool active, PrivilegeLevel privilegeLevel, string forename, string surname, DateTime? dateOfBirth, string email, string phoneNumber, string? emergencyContactForename, string? emergencyContactSurname, string? emergencyContactPhoneNumber, string address, string department, Theme theme) {
    public int StaffID { get; private init; } = staffID;
    public string Username { get; private init; } = username;
    public bool Active { get; init; } = active;
    public PrivilegeLevel PrivilegeLevel { get; init; } = privilegeLevel;
    public string Forename { get; set; } = forename;
    public string Surname { get; set; } = surname;
    public DateTime? DateOfBirth { get; set; } = dateOfBirth;
    public string Email { get; set; } = email;
    public string PhoneNumber { get; set; } = phoneNumber;
    public string Address { get; set; } = address;
    public string? EmergencyContactForename { get; set; } = emergencyContactForename;
    public string? EmergencyContactSurname { get; set; } = emergencyContactSurname;
    public string? EmergencyContactPhoneNumber { get; set; } = emergencyContactPhoneNumber;
    public string Department { get; set; } = department;
    public Theme Theme { get; set; } = theme;
}
