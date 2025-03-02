namespace a2_coursework.Interfaces.CleaningJob;
public interface IManageCleaningJobOptionDetails : IView {
    public event EventHandler? AddressChanged;
    public event EventHandler? ExtraInformationChanged;

    public string ExtraInformation { get; set; }
    public string Address { get; set; }
    public bool ReadOnly { get; set; }

    public void SetExtraInformtionCharacterCount(int number);
    public void SetAddressCharacterCount(int number);

    public void SetAddressBorderError(bool isError);
}