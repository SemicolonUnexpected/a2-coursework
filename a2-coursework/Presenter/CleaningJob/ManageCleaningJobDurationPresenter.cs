using a2_coursework.Interfaces.CleaningJob;

namespace a2_coursework.Presenter.CleaningJob;

public class ManageCleaningJobDurationPresenter : BasePresenter<IManageCleaningJobDuration>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageCleaningJobDurationPresenter(IManageCleaningJobDuration view) : base(view) {
        _view.DateChanged += OnDateChanged;
        _view.StartTimeChanged += OnStartTimeChanged;
        _view.EndTimeChanged += OnEndTimeChanged;
    }

    private void OnEndTimeChanged(object? sender, EventArgs e) {
        DisplayTimeError();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private void OnStartTimeChanged(object? sender, EventArgs e) {
        DisplayTimeError();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private void OnDateChanged(object? sender, EventArgs e) {
        DisplayDateError();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private bool _startTimeValid;
    private bool _endTimeValid;
    private void DisplayTimeError() {
        if (!_view.StartTimeValid || !_view.EndTimeValid) {
            _view.TimeError = (_view.StartTimeValid, _view.EndTimeValid) switch {
                (true, false) => "End time invalid",
                (false, true) => "Start time invalid",
                (false, false) => "Start and end times invalid",
                _ => throw new NotImplementedException(),
            };

            _startTimeValid = _view.StartTimeValid;
            _endTimeValid = _view.EndTimeValid;
            return;
        }
        else if (_view.StartTime >= _view.EndTime) {
            _view.TimeError = "Ensure the end time is after the start time";

            _startTimeValid = false;
            _endTimeValid = false;
        }
        else {
            _view.TimeError = "";

            _startTimeValid = true;
            _endTimeValid = true;
        }
    }

    private bool _dateValid;
    private void DisplayDateError() {
        if (!_view.DateValid) {
            _view.DateError = "Date is invalid";
            _dateValid = false;
        }
        else if (DateOnly.FromDateTime((DateTime)_view.Date!) != DateOnly.FromDateTime((DateTime)_setDate!) && _view.Date < DateTime.Today + new TimeSpan(14, 0, 0, 0)) {
            _view.DateError = "Bookings must be made at least two weeks in advance";
            _dateValid = false;
        }
        else {
            _view.DateError = "";
            _dateValid = true;
        }
    }

    public bool DatesValid => _dateValid && _startTimeValid && _endTimeValid;

    private DateTime? _setDate;
    public DateTime? StartDate {
        get {
            if (_view.Date is null || _view.StartTime is null) return null;

            return DateOnly.FromDateTime((DateTime)_view.Date).ToDateTime((TimeOnly)_view.StartTime);
        }
        set {
            _setDate = value;
            _view.Date = value;
            if (value is not null) _view.StartTime = TimeOnly.FromDateTime((DateTime)value);
        }
    }

    public DateTime? EndDate {
        get {
            if (_view.Date is null || _view.EndTime is null) return null;

            return DateOnly.FromDateTime((DateTime)_view.Date).ToDateTime((TimeOnly)_view.EndTime);
        }
        set {
            _setDate = value;
            _view.Date = value;
            if (value is not null) _view.EndTime = TimeOnly.FromDateTime((DateTime)value);
        }
    }
    
    public override void CleanUp() {
        _view.DateChanged -= OnDateChanged;
        _view.StartTimeChanged -= OnStartTimeChanged;
        _view.EndTimeChanged -= OnEndTimeChanged;

        base.CleanUp();
    }
}
