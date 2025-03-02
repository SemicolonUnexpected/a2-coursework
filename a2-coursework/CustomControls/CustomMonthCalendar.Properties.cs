namespace a2_coursework.CustomControls; 
public partial class CustomMonthCalendar {
    private DateTime _date;
    public DateTime Date {
        get => _date;
        set {
            if (value == _date) return;
            
            _date = value;
            OnDateChanged();
            DateChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    private DateTime _displayedDate = DateTime.Today;
    public DateTime DisplayedDate {
        get => _displayedDate;
        set {
            _displayedDate = value;
            OnDateChanged();
        }
    }

    private Color _disabledForeColor;
    public Color DisabledForeColor {
        get => _disabledForeColor;
        set {
            _disabledForeColor = value;
            AssignDays();
        }
    }

    private Color _selectedDateBackColor;
    public Color SelectedDateBackColor {
        get => _selectedDateBackColor;
        set {
            _selectedDateBackColor = value;
            AssignDays();
        }
    }

    public CustomButton this[int column, int row] {
        get {
            if (column < 0 || column > 6) throw new ArgumentOutOfRangeException(nameof(column));
            if (row < 0 || row > 5) throw new ArgumentOutOfRangeException(nameof(row));

            return (CustomButton)tableLayoutPanel.GetControlFromPosition(column, row + 1)!;
        }
    }

    public CustomButton NextButton => btnNext;
    public CustomButton PreviousButton => btnPrevious;

    private Color _hoverColor;
    public Color HoverColor {
        get => _hoverColor;
        set {
            _hoverColor = value;
            AssignDays();
        }
    }

    private Color _clickedColor;
    public Color ClickedColor {
        get => _clickedColor;
        set {
            _clickedColor = value;
            AssignDays();
        }
    }

    private CornerRadiiF _dateCornerRadii;
    public CornerRadiiF DateCornerRadii {
        get => _dateCornerRadii;
        set {
            _dateCornerRadii = value;

            for (int i = 1; i < 7; i++) {
                for (int j = 0; j < 7; j++) {
                    CustomButton button = (CustomButton)tableLayoutPanel.GetControlFromPosition(j, i)!;
                    button.CornerRadii = _dateCornerRadii;
                }
            }
        }
    }
}
