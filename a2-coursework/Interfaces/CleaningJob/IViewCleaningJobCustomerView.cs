namespace a2_coursework.Interfaces.CleaningJob; 
public interface IViewCleaningJobCustomerView : IChildView {
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhoneNumber { get; set; }
}