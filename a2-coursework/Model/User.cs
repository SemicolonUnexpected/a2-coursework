namespace a2_coursework.Model;

internal class User {
    public User(int staffID, string username, bool active, PrivilegeLevel priviledgeLevel, string forename, string surname, string email, string phoneNumber, string emergencyContactForename, string emergencyContactSurname, string emergencyContactPhoneNumber, string address, string position, string department) {
        StaffID = staffID;
        Username = username;
        Active = active;
        PriviledgeLevel = priviledgeLevel;
        Forename = forename;
        Surname = surname;
        Email = email;
        PhoneNumber = phoneNumber;
        EmergencyContactForename = emergencyContactForename;
        EmergencyContactSurname = emergencyContactSurname;
        EmergencyContactPhoneNumber = emergencyContactPhoneNumber;
        Address = address;
        Position = position;
        Department = department;
    }

    public int StaffID { get; private init; }
    public string Username { get; private init; }
    public bool Active { get; init; }
    public PrivilegeLevel PriviledgeLevel { get; init; }
    public string Forename { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string EmergencyContactForename { get; set; }
    public string EmergencyContactSurname { get; set; }
    public string EmergencyContactPhoneNumber { get; set; }
    public string Address { get; set; }
    public string Position { get; set; }
    public string Department {  get; set; }
}
