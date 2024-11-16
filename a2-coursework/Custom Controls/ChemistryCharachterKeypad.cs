namespace AS_Coursework.Custom_Controls; 
public partial class ChemistryCharachterKeypad : UserControl {
    public ChemistryCharachterKeypad() {
        InitializeComponent();
    }

    public event EventHandler<string>? CharacterClicked;

    private void btnClick(object sender, EventArgs e) {
        CustomButton button = (CustomButton)sender;

        CharacterClicked?.Invoke(this, button.Text);
    }
}
