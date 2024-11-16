using System.ComponentModel;

namespace AS_Coursework.Custom_Controls; 
public partial class Ranking : UserControl {

    private string _experience = "";

    public Ranking() {
        InitializeComponent();

        OnResize(EventArgs.Empty);
    }


    [Category("Ranking")]
    public string UsernameText {
        get => lblUsername.Text;
        set => lblUsername.Text = value;
    }

    [Category("Ranking")]
    public string ExperienceText {
        get => _experience;
        set {
            _experience = value;
            lblExperience.Text = value;
        }
    }

    [Category("Ranking")]
    public override Font Font {
        get => base.Font;
        set {
            base.Font = value;
            lblExperience.Font = value;
            lblUsername.Font = value;
        }
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // This sets the username label to the maximum size, assuming the experience label is of constant size
        lblUsername.MaximumSize = new Size(Width - lblExperience.Width, lblUsername.Height);
        // Positions the labels relative to the margins on the controls
        lblUsername.Location = new Point(lblUsername.Margin.Left, lblUsername.Location.Y);
        lblExperience.Location = new Point(Width - lblExperience.Width - lblExperience.Margin.Right, (Height - lblExperience.Height) / 2);
    }
}
