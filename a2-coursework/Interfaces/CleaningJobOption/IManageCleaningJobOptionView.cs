namespace a2_coursework.Interfaces.CleaningJobOption; 
public interface IManageCleaningJobOptionView : IChildView {
    public event EventHandler? NameChanged;
    public event EventHandler? DescriptionChanged;
    public event EventHandler? UnitCostChanged;

    public string CleaningJobName { get; set; }
    public string Description { get ; set; }
    public decimal UnitCost { get; set; }

    public void SetCharacterCount(int number);

    public string NameError { get; set; }
    public void SetNameBorderError(bool isError);
}
