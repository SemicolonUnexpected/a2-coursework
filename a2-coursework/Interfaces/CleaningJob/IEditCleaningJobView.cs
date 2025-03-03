using a2_coursework.Interfaces;

namespace a2_coursework.Interfaces.CleaningJob;
public interface IEditCleaningJobView : IChildView, IEditView {
    public event EventHandler? Back;
}