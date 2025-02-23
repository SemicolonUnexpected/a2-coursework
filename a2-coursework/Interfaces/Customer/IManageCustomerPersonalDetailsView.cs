namespace a2_coursework.Interfaces.Customer;
public interface IManageCustomerPersonalDetailsView : IChildView {
    public event EventHandler? ForenameChanged;
    public event EventHandler? SurnameChanged;
    public event EventHandler? ArchivedChanged;

    public string Forename {get; set;}
    public string Surname { get; set;}
    public bool Archived { get; set;}

    public string NameError { get   ; set;}
    public void SetForenameBorderError(bool isError);
    public void SetSurnameBorderError(bool isError);
}