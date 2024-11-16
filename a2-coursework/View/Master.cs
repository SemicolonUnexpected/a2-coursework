using a2_coursework.View.Interfaces;
using System.Diagnostics.Contracts;

namespace a2_coursework.View;
public partial class Master : Form, IMaster {
    public Master() {
        InitializeComponent();
    }

    private void Master_FormClosing(object sender, FormClosingEventArgs e) {
        Application.Exit();
    }
}
