namespace a2_coursework.View.StaffView {
    partial class ManageStaffAppearanceSettingsView {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pnlFont = new CustomControls.CustomPanel();
            rbComicSans = new CustomControls.CustomRadioButton();
            rbCentury = new CustomControls.CustomRadioButton();
            rbBahnschrift = new CustomControls.CustomRadioButton();
            lblComicSans = new Label();
            lblCentury = new Label();
            lblBahnschrift = new Label();
            lblFont = new Label();
            pnlDarkMode = new CustomControls.CustomPanel();
            rbDarkMode = new CustomControls.CustomRadioButton();
            lblDarkMode = new Label();
            customPanel2 = new CustomControls.CustomPanel();
            rbShowToolTips = new CustomControls.CustomRadioButton();
            lblToolTips = new Label();
            pnlFont.SuspendLayout();
            pnlDarkMode.SuspendLayout();
            customPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFont
            // 
            pnlFont.Anchor = AnchorStyles.None;
            pnlFont.BorderColor = Color.FromArgb(39, 39, 42);
            pnlFont.BorderThickness = 1F;
            pnlFont.Controls.Add(rbComicSans);
            pnlFont.Controls.Add(rbCentury);
            pnlFont.Controls.Add(rbBahnschrift);
            pnlFont.Controls.Add(lblComicSans);
            pnlFont.Controls.Add(lblCentury);
            pnlFont.Controls.Add(lblBahnschrift);
            pnlFont.Controls.Add(lblFont);
            pnlFont.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlFont.Location = new Point(158, 123);
            pnlFont.Margin = new Padding(5);
            pnlFont.Name = "pnlFont";
            pnlFont.Padding = new Padding(5);
            pnlFont.Size = new Size(339, 122);
            pnlFont.TabIndex = 22;
            // 
            // rbComicSans
            // 
            rbComicSans.Anchor = AnchorStyles.Right;
            rbComicSans.BorderThickness = 1.7F;
            rbComicSans.CheckColor = Color.White;
            rbComicSans.CheckRadius = 5F;
            rbComicSans.ForeColor = Color.White;
            rbComicSans.Location = new Point(10, 95);
            rbComicSans.Margin = new Padding(5);
            rbComicSans.Name = "rbComicSans";
            rbComicSans.Size = new Size(17, 17);
            rbComicSans.TabIndex = 28;
            rbComicSans.Text = "customRadioButton1";
            rbComicSans.CheckChanged += rbFontName_CheckChanged;
            // 
            // rbCentury
            // 
            rbCentury.Anchor = AnchorStyles.Right;
            rbCentury.BorderThickness = 1.7F;
            rbCentury.CheckColor = Color.White;
            rbCentury.CheckRadius = 5F;
            rbCentury.ForeColor = Color.White;
            rbCentury.Location = new Point(10, 68);
            rbCentury.Margin = new Padding(5);
            rbCentury.Name = "rbCentury";
            rbCentury.Size = new Size(17, 17);
            rbCentury.TabIndex = 27;
            rbCentury.Text = "customRadioButton1";
            rbCentury.CheckChanged += rbFontName_CheckChanged;
            // 
            // rbBahnschrift
            // 
            rbBahnschrift.Anchor = AnchorStyles.Right;
            rbBahnschrift.BorderThickness = 1.7F;
            rbBahnschrift.CheckColor = Color.White;
            rbBahnschrift.Checked = true;
            rbBahnschrift.CheckRadius = 5F;
            rbBahnschrift.ForeColor = Color.White;
            rbBahnschrift.Location = new Point(10, 43);
            rbBahnschrift.Margin = new Padding(5);
            rbBahnschrift.Name = "rbBahnschrift";
            rbBahnschrift.Size = new Size(17, 17);
            rbBahnschrift.TabIndex = 26;
            rbBahnschrift.Text = "customRadioButton1";
            rbBahnschrift.CheckChanged += rbFontName_CheckChanged;
            // 
            // lblComicSans
            // 
            lblComicSans.Anchor = AnchorStyles.Left;
            lblComicSans.AutoSize = true;
            lblComicSans.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComicSans.ForeColor = Color.White;
            lblComicSans.Location = new Point(37, 92);
            lblComicSans.Margin = new Padding(5);
            lblComicSans.Name = "lblComicSans";
            lblComicSans.Size = new Size(233, 23);
            lblComicSans.TabIndex = 25;
            lblComicSans.Text = "Comic Sans (dyslexia friendly)";
            // 
            // lblCentury
            // 
            lblCentury.Anchor = AnchorStyles.Left;
            lblCentury.AutoSize = true;
            lblCentury.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCentury.ForeColor = Color.White;
            lblCentury.Location = new Point(37, 66);
            lblCentury.Margin = new Padding(5);
            lblCentury.Name = "lblCentury";
            lblCentury.Size = new Size(71, 20);
            lblCentury.TabIndex = 24;
            lblCentury.Text = "Century";
            // 
            // lblBahnschrift
            // 
            lblBahnschrift.Anchor = AnchorStyles.Left;
            lblBahnschrift.AutoSize = true;
            lblBahnschrift.Font = new Font("Bahnschrift", 12F);
            lblBahnschrift.ForeColor = Color.White;
            lblBahnschrift.Location = new Point(37, 42);
            lblBahnschrift.Margin = new Padding(5);
            lblBahnschrift.Name = "lblBahnschrift";
            lblBahnschrift.Size = new Size(157, 19);
            lblBahnschrift.TabIndex = 23;
            lblBahnschrift.Text = "Bahnschrift (default)";
            // 
            // lblFont
            // 
            lblFont.Anchor = AnchorStyles.Left;
            lblFont.AutoSize = true;
            lblFont.Font = new Font("Bahnschrift", 14F);
            lblFont.ForeColor = Color.White;
            lblFont.Location = new Point(10, 10);
            lblFont.Margin = new Padding(5);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(48, 23);
            lblFont.TabIndex = 18;
            lblFont.Text = "Font";
            // 
            // pnlDarkMode
            // 
            pnlDarkMode.Anchor = AnchorStyles.None;
            pnlDarkMode.BorderColor = Color.FromArgb(39, 39, 42);
            pnlDarkMode.BorderThickness = 1F;
            pnlDarkMode.Controls.Add(rbDarkMode);
            pnlDarkMode.Controls.Add(lblDarkMode);
            pnlDarkMode.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlDarkMode.Location = new Point(158, 14);
            pnlDarkMode.Margin = new Padding(5);
            pnlDarkMode.Name = "pnlDarkMode";
            pnlDarkMode.Padding = new Padding(5);
            pnlDarkMode.Size = new Size(339, 40);
            pnlDarkMode.TabIndex = 21;
            // 
            // rbDarkMode
            // 
            rbDarkMode.Anchor = AnchorStyles.Right;
            rbDarkMode.BorderThickness = 1.7F;
            rbDarkMode.CheckColor = Color.White;
            rbDarkMode.Checked = true;
            rbDarkMode.CheckRadius = 5F;
            rbDarkMode.ForeColor = Color.White;
            rbDarkMode.Location = new Point(312, 12);
            rbDarkMode.Margin = new Padding(5);
            rbDarkMode.Name = "rbDarkMode";
            rbDarkMode.Size = new Size(17, 17);
            rbDarkMode.TabIndex = 0;
            rbDarkMode.Text = "customRadioButton1";
            // 
            // lblDarkMode
            // 
            lblDarkMode.Anchor = AnchorStyles.Left;
            lblDarkMode.AutoSize = true;
            lblDarkMode.Font = new Font("Bahnschrift", 14F);
            lblDarkMode.ForeColor = Color.White;
            lblDarkMode.Location = new Point(10, 9);
            lblDarkMode.Margin = new Padding(5);
            lblDarkMode.Name = "lblDarkMode";
            lblDarkMode.Size = new Size(100, 23);
            lblDarkMode.TabIndex = 18;
            lblDarkMode.Text = "Dark Mode";
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.None;
            customPanel2.BorderColor = Color.FromArgb(39, 39, 42);
            customPanel2.BorderThickness = 1F;
            customPanel2.Controls.Add(rbShowToolTips);
            customPanel2.Controls.Add(lblToolTips);
            customPanel2.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customPanel2.Location = new Point(158, 64);
            customPanel2.Margin = new Padding(5);
            customPanel2.Name = "customPanel2";
            customPanel2.Padding = new Padding(5);
            customPanel2.Size = new Size(339, 40);
            customPanel2.TabIndex = 21;
            // 
            // rbShowToolTips
            // 
            rbShowToolTips.Anchor = AnchorStyles.Right;
            rbShowToolTips.BorderThickness = 1.7F;
            rbShowToolTips.CheckColor = Color.White;
            rbShowToolTips.Checked = true;
            rbShowToolTips.CheckRadius = 5F;
            rbShowToolTips.ForeColor = Color.White;
            rbShowToolTips.Location = new Point(312, 12);
            rbShowToolTips.Margin = new Padding(5);
            rbShowToolTips.Name = "rbShowToolTips";
            rbShowToolTips.Size = new Size(17, 17);
            rbShowToolTips.TabIndex = 0;
            rbShowToolTips.Text = "customRadioButton1";
            // 
            // lblToolTips
            // 
            lblToolTips.Anchor = AnchorStyles.Left;
            lblToolTips.AutoSize = true;
            lblToolTips.Font = new Font("Bahnschrift", 14F);
            lblToolTips.ForeColor = Color.White;
            lblToolTips.Location = new Point(10, 9);
            lblToolTips.Margin = new Padding(5);
            lblToolTips.Name = "lblToolTips";
            lblToolTips.Size = new Size(83, 23);
            lblToolTips.TabIndex = 18;
            lblToolTips.Text = "Tool Tips";
            // 
            // ManageStaffAppearanceSettingsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(pnlFont);
            Controls.Add(customPanel2);
            Controls.Add(pnlDarkMode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStaffAppearanceSettingsView";
            Text = "ManageStaffAppearanceSettingsView";
            pnlFont.ResumeLayout(false);
            pnlFont.PerformLayout();
            pnlDarkMode.ResumeLayout(false);
            pnlDarkMode.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomPanel pnlFont;
        private Label lblComicSans;
        private Label lblCentury;
        private Label lblBahnschrift;
        private Label lblFont;
        private CustomControls.CustomPanel pnlDarkMode;
        private CustomControls.CustomRadioButton rbDarkMode;
        private Label lblDarkMode;
        private CustomControls.CustomPanel customPanel2;
        private CustomControls.CustomRadioButton rbShowToolTips;
        private Label lblToolTips;
        private CustomControls.CustomRadioButton rbComicSans;
        private CustomControls.CustomRadioButton rbCentury;
        private CustomControls.CustomRadioButton rbBahnschrift;
    }
}