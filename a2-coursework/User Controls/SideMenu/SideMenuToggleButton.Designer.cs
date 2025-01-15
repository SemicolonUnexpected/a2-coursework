namespace a2_coursework.UserControls.SideMenu {
    partial class SideMenuToggleButton {
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
            btn = new UserControls.ToggleButton();
            SuspendLayout();
            // 
            // btn
            // 
            btn.BackColor = Color.FromArgb(9, 9, 10);
            btn.BorderColor = Color.Empty;
            btn.BorderThickness = 0F;
            btn.CornerRadii = new CustomControls.CornerRadiiF(5F, 5F, 5F, 5F);
            btn.Dock = DockStyle.Fill;
            btn.Font = new Font("Bahnschrift", 10F);
            btn.ForeColor = Color.White;
            btn.HoverColor = Color.FromArgb(39, 39, 42);
            btn.Location = new Point(2, 2);
            btn.Margin = new Padding(3, 3, 3, 0);
            btn.Name = "btn";
            btn.Padding = new Padding(5);
            btn.Size = new Size(279, 36);
            btn.TabIndex = 3;
            btn.Text = "Dashboard";
            btn.Toggled = false;
            btn.ToggledColor = Color.FromArgb(39, 39, 42);
            btn.ToggleChanged += this.btn_ToggleChanged;
            // 
            // SideMenuItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(btn);
            Name = "SideMenuItem";
            Padding = new Padding(2);
            Size = new Size(283, 40);
            ResumeLayout(false);
        }

        #endregion

        private UserControls.ToggleButton btn;
    }
}
