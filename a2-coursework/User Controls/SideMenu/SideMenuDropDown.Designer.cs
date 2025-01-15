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
            pnlDropDown = new Panel();
            pnlSpacer1 = new Panel();
            pnlSideDecor2 = new Panel();
            sideMenuToggleButton1 = new SideMenuToggleButton();
            sideMenuButton1 = new SideMenuButton();
            pnlDropDown.SuspendLayout();
            pnlSpacer1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDropDown
            // 
            pnlDropDown.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlDropDown.Controls.Add(pnlSpacer1);
            pnlDropDown.Location = new Point(0, 116);
            pnlDropDown.Name = "pnlDropDown";
            pnlDropDown.Size = new Size(373, 105);
            pnlDropDown.TabIndex = 8;
            // 
            // pnlSpacer1
            // 
            pnlSpacer1.Controls.Add(pnlSideDecor2);
            pnlSpacer1.Dock = DockStyle.Left;
            pnlSpacer1.Location = new Point(0, 0);
            pnlSpacer1.Name = "pnlSpacer1";
            pnlSpacer1.Padding = new Padding(5, 5, 5, 10);
            pnlSpacer1.Size = new Size(33, 105);
            pnlSpacer1.TabIndex = 7;
            // 
            // pnlSideDecor2
            // 
            pnlSideDecor2.BackColor = Color.FromArgb(39, 39, 42);
            pnlSideDecor2.Dock = DockStyle.Right;
            pnlSideDecor2.Location = new Point(27, 5);
            pnlSideDecor2.Name = "pnlSideDecor2";
            pnlSideDecor2.Size = new Size(1, 90);
            pnlSideDecor2.TabIndex = 3;
            // 
            // sideMenuToggleButton1
            // 
            sideMenuToggleButton1.BackColor = Color.FromArgb(9, 9, 10);
            sideMenuToggleButton1.Dock = DockStyle.Top;
            sideMenuToggleButton1.Location = new Point(0, 0);
            sideMenuToggleButton1.Name = "sideMenuToggleButton1";
            sideMenuToggleButton1.Padding = new Padding(2);
            sideMenuToggleButton1.Size = new Size(373, 40);
            sideMenuToggleButton1.TabIndex = 9;
            sideMenuToggleButton1.Toggled = false;
            // 
            // sideMenuButton1
            // 
            sideMenuButton1.BackColor = Color.FromArgb(9, 9, 10);
            sideMenuButton1.Dock = DockStyle.Top;
            sideMenuButton1.IconImage = null;
            sideMenuButton1.Location = new Point(0, 40);
            sideMenuButton1.Name = "sideMenuButton1";
            sideMenuButton1.Padding = new Padding(2);
            sideMenuButton1.Size = new Size(373, 40);
            sideMenuButton1.TabIndex = 10;
            // 
            // SideMenuDropDown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sideMenuButton1);
            Controls.Add(sideMenuToggleButton1);
            Controls.Add(pnlDropDown);
            Name = "SideMenuDropDown";
            Size = new Size(373, 337);
            pnlDropDown.ResumeLayout(false);
            pnlSpacer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlDropDown;
        private Panel pnlSpacer1;
        private Panel pnlSideDecor2;
        private SideMenuToggleButton sideMenuToggleButton1;
        private SideMenuButton sideMenuButton1;
    }
}
