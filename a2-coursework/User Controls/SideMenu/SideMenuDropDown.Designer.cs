namespace a2_coursework.UserControls.SideMenu {
    partial class SideMenuDropDown {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btn = new SideMenuButton();
            btnToggle = new SideMenuToggleButton();
            pnlDropDown = new Panel();
            pnlSpacer = new Panel();
            pnlDecor = new Panel();
            pnlDropDown.SuspendLayout();
            pnlSpacer.SuspendLayout();
            SuspendLayout();
            // 
            // btn
            // 
            btn.BackColor = Color.FromArgb(9, 9, 10);
            btn.Dock = DockStyle.Top;
            btn.IconImage = null;
            btn.Location = new Point(0, 0);
            btn.Name = "btn";
            btn.Padding = new Padding(2);
            btn.Size = new Size(373, 40);
            btn.TabIndex = 9;
            btn.Text = "qa";
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.FromArgb(9, 9, 10);
            btnToggle.Dock = DockStyle.Top;
            btnToggle.Location = new Point(0, 40);
            btnToggle.Name = "btnToggle";
            btnToggle.Padding = new Padding(2);
            btnToggle.Size = new Size(373, 40);
            btnToggle.TabIndex = 10;
            btnToggle.Text = "toggle";
            btnToggle.Toggled = false;
            // 
            // pnlDropDown
            // 
            pnlDropDown.Controls.Add(pnlSpacer);
            pnlDropDown.Dock = DockStyle.Top;
            pnlDropDown.Location = new Point(0, 80);
            pnlDropDown.Name = "pnlDropDown";
            pnlDropDown.Size = new Size(373, 110);
            pnlDropDown.TabIndex = 11;
            // 
            // pnlSpacer
            // 
            pnlSpacer.Controls.Add(pnlDecor);
            pnlSpacer.Dock = DockStyle.Left;
            pnlSpacer.Location = new Point(0, 0);
            pnlSpacer.Name = "pnlSpacer";
            pnlSpacer.Padding = new Padding(5, 5, 5, 10);
            pnlSpacer.Size = new Size(30, 110);
            pnlSpacer.TabIndex = 8;
            // 
            // pnlDecor
            // 
            pnlDecor.BackColor = Color.FromArgb(39, 39, 42);
            pnlDecor.Dock = DockStyle.Right;
            pnlDecor.Location = new Point(24, 5);
            pnlDecor.Name = "pnlDecor";
            pnlDecor.Size = new Size(1, 95);
            pnlDecor.TabIndex = 3;
            // 
            // SideMenuDropDown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(pnlDropDown);
            Controls.Add(btnToggle);
            Controls.Add(btn);
            Name = "SideMenuDropDown";
            Size = new Size(373, 337);
            pnlDropDown.ResumeLayout(false);
            pnlSpacer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SideMenuButton btn;
        private SideMenuToggleButton btnToggle;
        private Panel pnlDropDown;
        private Panel pnlSpacer;
        private Panel pnlDecor;
    }
}
