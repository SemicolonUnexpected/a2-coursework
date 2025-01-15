namespace a2_coursework.UserControls.SideMenu {
    partial class SideMenuButton {
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
            btn = new CustomControls.CustomButton();
            SuspendLayout();
            // 
            // btn
            // 
            btn.BackColor = Color.FromArgb(9, 9, 10);
            btn.BorderColor = Color.Empty;
            btn.BorderThickness = 0F;
            btn.ClickedBorderColor = Color.Empty;
            btn.ClickedColor = Color.FromArgb(39, 39, 42);
            btn.CornerRadii = new CustomControls.CornerRadiiF(5F, 5F, 5F, 5F);
            btn.DisabledBorderColor = Color.Empty;
            btn.DisabledColor = Color.Empty;
            btn.Dock = DockStyle.Fill;
            btn.Font = new Font("Bahnschrift", 10F);
            btn.ForeColor = Color.White;
            btn.HoverBorderColor = Color.Empty;
            btn.HoverColor = Color.FromArgb(39, 39, 42);
            btn.ImageRectangle = new Rectangle(264, 8, 16, 16);
            btn.Location = new Point(2, 2);
            btn.Name = "btn";
            btn.Padding = new Padding(5);
            btn.Size = new Size(196, 36);
            btn.TabIndex = 1;
            btn.Text = "Bookings";
            btn.TextAlign = CustomControls.CustomButtonAlign.TopCenter | CustomControls.CustomButtonAlign.TopRight;
            btn.TextPosition = new Point(5, 9);
            btn.Click += btn_Click;
            // 
            // SideMenuButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(btn);
            Name = "SideMenuButton";
            Padding = new Padding(2);
            Size = new Size(200, 40);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomButton btn;
    }
}
