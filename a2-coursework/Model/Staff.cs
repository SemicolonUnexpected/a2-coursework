using a2_coursework.Theming;

namespace a2_coursework.Model;

public class Staff {
    public Staff(int staffID, string username, bool active, PrivilegeLevel? privilegeLevel, string forename, string surname, DateTime? dateOfBirth, string email, string? phoneNumber, string? emergencyContactForename, string? emergencyContactSurname, string? emergencyContactPhoneNumber, string? address, string? position, string? department, Theme theme) {
        StaffID = staffID;
        Username = username;
        Active = active;
        PrivilegeLevel = privilegeLevel;
        Forename = forename;
        Surname = surname;
        DateOfBirth = dateOfBirth;
        Email = email;
        PhoneNumber = phoneNumber;
        EmergencyContactForename = emergencyContactForename;
        EmergencyContactSurname = emergencyContactSurname;
        EmergencyContactPhoneNumber = emergencyContactPhoneNumber;
        Address = address;
        Position = position;
        Department = department;
        Theme = theme;
    }

    public int StaffID { get; private init; }
    public string Username { get; private init; }
    public bool Active { get; init; }
    public PrivilegeLevel? PrivilegeLevel { get; init; }
    public string Forename { get; set; }
    public string Surname { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? EmergencyContactForename { get; set; }
    public string? EmergencyContactSurname { get; set; }
    public string? EmergencyContactPhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? Position { get; set; }
    public string? Department {  get; set; }
    public Theme Theme { get; set; }
}
