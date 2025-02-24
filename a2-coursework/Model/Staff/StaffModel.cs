using a2_coursework.Theming;

namespace a2_coursework.Model.Staff;

public class StaffModel(int id, byte[] hashedPassword, byte[] salt, DateTime lastPasswordChange, string username, bool archived, PrivilegeLevel privilegeLevel, string forename, string surname, DateTime? dateOfBirth, string email, string phoneNumber, string emergencyContactForename, string emergencyContactSurname, string emergencyContactPhoneNumber, string address, Theme theme) {
    public int Id { get; set; } = id;
    public byte[] HashedPassword { get; set; } = hashedPassword;
    public byte[] Salt { get; set; } = salt;
    public DateTime LastPasswordChange { get; set; } = lastPasswordChange;
    public string Username { get; set; } = username;
    public bool Archived { get; set; } = archived;
    public PrivilegeLevel PrivilegeLevel { get; set; } = privilegeLevel;
    public string Forename { get; set; } = forename;
    public string Surname { get; set; } = surname;
    public DateTime? DateOfBirth { get; set; } = dateOfBirth;
    public string Email { get; set; } = email;
    public string PhoneNumber { get; set; } = phoneNumber;
    public string Address { get; set; } = address;
    public string EmergencyContactForename { get; set; } = emergencyContactForename;
    public string EmergencyContactSurname { get; set; } = emergencyContactSurname;
    public string EmergencyContactPhoneNumber { get; set; } = emergencyContactPhoneNumber;
    public Theme Theme { get; set; } = theme;
}
