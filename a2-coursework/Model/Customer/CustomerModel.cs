namespace a2_coursework.Model.Customer; 
public class CustomerModel(int id, string forename, string surname, string email, string phoneNumber, bool archived){
    public int Id { get; set; } = id;
    public string Forename { get; set; } = forename;
    public string Surname { get; set; } = surname;
    public string Email { get; set; } = email;
    public string PhoneNumber { get; set; } = phoneNumber;
    public bool Archived { get; set; } = archived;
}
