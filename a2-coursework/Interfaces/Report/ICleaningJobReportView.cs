using a2_coursework.Interfaces;

namespace a2_coursework.Interfaces.Report; 
public interface ICleaningJobReportView : IChildView {
    public event EventHandler? GenerateReport;

    public string Id { get; set; }
    public string ErrorMessage {get; set; }
}