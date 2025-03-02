namespace a2_coursework.Interfaces.CleaningJob;
public interface IManageCleaningJobDuration : IChildView {
    public event EventHandler? DateChanged;
    public event EventHandler? StartTimeChanged;
    public event EventHandler? EndTimeChanged;

    public TimeOnly StartTime { get; set; }
    public bool StartTimeValid { get; }
    public TimeOnly EndTime { get; set; }
    public bool EndTimeValid { get; }
    public DateTime? Date { get; set; }
    public bool DateValid { get; }
    public bool ReadOnly { get; set; }

    public string DateError { get; set; }
    public string TimeError { get; set; }
}