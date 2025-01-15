namespace a2_coursework.User_Controls.SideMenu {
    partial class MainSideMenu {
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
            sideMenuToggleButton1 = new UserControls.SideMenu.SideMenuToggleButton();
            SuspendLayout();
            // 
            // sideMenuToggleButton1
            // 
            sideMenuToggleButton1.BackColor = Color.FromArgb(9, 9, 10);
            sideMenuToggleButton1.Location = new Point(0, 0);
            sideMenuToggleButton1.Name = "sideMenuToggleButton1";
            sideMenuToggleButton1.Padding = new Padding(2);
            sideMenuToggleButton1.Size = new Size(283, 40);
            sideMenuToggleButton1.TabIndex = 0;
            sideMenuToggleButton1.Text = "sideMenuToggleButton1";
            sideMenuToggleButton1.Toggled = false;
            // 
            // MainSideMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(sideMenuToggleButton1);
            Name = "MainSideMenu";
            Size = new Size(198, 416);
            ResumeLayout(false);
        }

        #endregion

        private UserControls.SideMenu.SideMenuToggleButton sideMenuToggleButton1;
    }
}
