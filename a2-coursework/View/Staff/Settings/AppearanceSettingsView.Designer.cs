namespace a2_coursework.View.Settings {
    partial class AppearanceSettingsView {
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
            lblAppearance = new Label();
            lblEditPromt = new Label();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            pnlDarkMode = new CustomControls.CustomPanel();
            lblDarkModeDescription = new Label();
            rbDarkMode = new CustomControls.CustomRadioButton();
            lblDarkMode = new Label();
            pnlToolTips = new CustomControls.CustomPanel();
            lblToolTipsDescription = new Label();
            rbToolTips = new CustomControls.CustomRadioButton();
            lblToolTips = new Label();
            pnlFont = new CustomControls.CustomPanel();
            lblComicSans = new Label();
            lblCentury = new Label();
            lblBahnschrift = new Label();
            rbComicSans = new CustomControls.CustomRadioButton();
            rbCentury = new CustomControls.CustomRadioButton();
            rbBahnschrift = new CustomControls.CustomRadioButton();
            lblFontDescription = new Label();
            lblFont = new Label();
            pnlDarkMode.SuspendLayout();
            pnlToolTips.SuspendLayout();
            pnlFont.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppearance
            // 
            lblAppearance.Anchor = AnchorStyles.None;
            lblAppearance.AutoSize = true;
            lblAppearance.Font = new Font("Bahnschrift", 24F);
            lblAppearance.ForeColor = Color.White;
            lblAppearance.Location = new Point(151, 19);
            lblAppearance.Margin = new Padding(10);
            lblAppearance.Name = "lblAppearance";
            lblAppearance.Size = new Size(188, 39);
            lblAppearance.TabIndex = 8;
            lblAppearance.Text = "Appearance";
            // 
            // lblEditPromt
            // 
            lblEditPromt.Anchor = AnchorStyles.None;
            lblEditPromt.AutoSize = true;
            lblEditPromt.Font = new Font("Bahnschrift", 12F);
            lblEditPromt.ForeColor = Color.FromArgb(168, 171, 174);
            lblEditPromt.Location = new Point(151, 68);
            lblEditPromt.Margin = new Padding(10, 0, 10, 20);
            lblEditPromt.Name = "lblEditPromt";
            lblEditPromt.Size = new Size(274, 19);
            lblEditPromt.TabIndex = 10;
            lblEditPromt.Text = "Edit your appearance settings below";
            // 
            // approveChangesBar
            // 
            approveChangesBar.BackColor = Color.FromArgb(9, 9, 10);
            approveChangesBar.Dock = DockStyle.Bottom;
            approveChangesBar.IsLoading = false;
            approveChangesBar.Location = new Point(0, 459);
            approveChangesBar.Name = "approveChangesBar";
            approveChangesBar.Size = new Size(654, 41);
            approveChangesBar.TabIndex = 15;
            approveChangesBar.ToolTipsActive = true;
            approveChangesBar.Visible = false;
            // 
            // pnlDarkMode
            // 
            pnlDarkMode.Anchor = AnchorStyles.None;
            pnlDarkMode.BorderColor = Color.FromArgb(39, 39, 42);
            pnlDarkMode.BorderThickness = 1F;
            pnlDarkMode.Controls.Add(lblDarkModeDescription);
            pnlDarkMode.Controls.Add(rbDarkMode);
            pnlDarkMode.Controls.Add(lblDarkMode);
            pnlDarkMode.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlDarkMode.Location = new Point(151, 112);
            pnlDarkMode.Margin = new Padding(5);
            pnlDarkMode.Name = "pnlDarkMode";
            pnlDarkMode.Padding = new Padding(5);
            pnlDarkMode.Size = new Size(339, 87);
            pnlDarkMode.TabIndex = 16;
            // 
            // lblDarkModeDescription
            // 
            lblDarkModeDescription.Anchor = AnchorStyles.Left;
            lblDarkModeDescription.Font = new Font("Bahnschrift", 10F);
            lblDarkModeDescription.ForeColor = Color.FromArgb(168, 171, 174);
            lblDarkModeDescription.Location = new Point(10, 39);
            lblDarkModeDescription.Margin = new Padding(5);
            lblDarkModeDescription.Name = "lblDarkModeDescription";
            lblDarkModeDescription.Size = new Size(298, 38);
            lblDarkModeDescription.TabIndex = 17;
            lblDarkModeDescription.Text = "If enabled, the application will run in dark mode";
            // 
            // rbDarkMode
            // 
            rbDarkMode.Anchor = AnchorStyles.Right;
            rbDarkMode.BorderThickness = 1.7F;
            rbDarkMode.CheckColor = Color.White;
            rbDarkMode.Checked = true;
            rbDarkMode.CheckRadius = 5F;
            rbDarkMode.ForeColor = Color.White;
            rbDarkMode.Location = new Point(312, 36);
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
            lblDarkMode.Location = new Point(10, 10);
            lblDarkMode.Margin = new Padding(5);
            lblDarkMode.Name = "lblDarkMode";
            lblDarkMode.Size = new Size(100, 23);
            lblDarkMode.TabIndex = 18;
            lblDarkMode.Text = "Dark Mode";
            // 
            // pnlToolTips
            // 
            pnlToolTips.Anchor = AnchorStyles.None;
            pnlToolTips.BorderColor = Color.FromArgb(39, 39, 42);
            pnlToolTips.BorderThickness = 1F;
            pnlToolTips.Controls.Add(lblToolTipsDescription);
            pnlToolTips.Controls.Add(rbToolTips);
            pnlToolTips.Controls.Add(lblToolTips);
            pnlToolTips.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlToolTips.Location = new Point(151, 209);
            pnlToolTips.Margin = new Padding(5);
            pnlToolTips.Name = "pnlToolTips";
            pnlToolTips.Padding = new Padding(5);
            pnlToolTips.Size = new Size(339, 87);
            pnlToolTips.TabIndex = 16;
            // 
            // lblToolTipsDescription
            // 
            lblToolTipsDescription.Anchor = AnchorStyles.Left;
            lblToolTipsDescription.Font = new Font("Bahnschrift", 10F);
            lblToolTipsDescription.ForeColor = Color.FromArgb(168, 171, 174);
            lblToolTipsDescription.Location = new Point(10, 39);
            lblToolTipsDescription.Margin = new Padding(5);
            lblToolTipsDescription.Name = "lblToolTipsDescription";
            lblToolTipsDescription.Size = new Size(298, 38);
            lblToolTipsDescription.TabIndex = 17;
            lblToolTipsDescription.Text = "If enabled, tool tips will be shown on some controls";
            // 
            // rbToolTips
            // 
            rbToolTips.Anchor = AnchorStyles.Right;
            rbToolTips.BorderThickness = 1.7F;
            rbToolTips.CheckColor = Color.White;
            rbToolTips.Checked = true;
            rbToolTips.CheckRadius = 5F;
            rbToolTips.ForeColor = Color.White;
            rbToolTips.Location = new Point(312, 36);
            rbToolTips.Margin = new Padding(5);
            rbToolTips.Name = "rbToolTips";
            rbToolTips.Size = new Size(17, 17);
            rbToolTips.TabIndex = 0;
            rbToolTips.Text = "customRadioButton1";
            // 
            // lblToolTips
            // 
            lblToolTips.Anchor = AnchorStyles.Left;
            lblToolTips.AutoSize = true;
            lblToolTips.Font = new Font("Bahnschrift", 14F);
            lblToolTips.ForeColor = Color.White;
            lblToolTips.Location = new Point(10, 10);
            lblToolTips.Margin = new Padding(5);
            lblToolTips.Name = "lblToolTips";
            lblToolTips.Size = new Size(83, 23);
            lblToolTips.TabIndex = 18;
            lblToolTips.Text = "Tool Tips";
            // 
            // pnlFont
            // 
            pnlFont.Anchor = AnchorStyles.None;
            pnlFont.BorderColor = Color.FromArgb(39, 39, 42);
            pnlFont.BorderThickness = 1F;
            pnlFont.Controls.Add(lblComicSans);
            pnlFont.Controls.Add(lblCentury);
            pnlFont.Controls.Add(lblBahnschrift);
            pnlFont.Controls.Add(rbComicSans);
            pnlFont.Controls.Add(rbCentury);
            pnlFont.Controls.Add(rbBahnschrift);
            pnlFont.Controls.Add(lblFontDescription);
            pnlFont.Controls.Add(lblFont);
            pnlFont.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlFont.Location = new Point(151, 306);
            pnlFont.Margin = new Padding(5);
            pnlFont.Name = "pnlFont";
            pnlFont.Padding = new Padding(5);
            pnlFont.Size = new Size(339, 139);
            pnlFont.TabIndex = 19;
            // 
            // lblComicSans
            // 
            lblComicSans.Anchor = AnchorStyles.Left;
            lblComicSans.AutoSize = true;
            lblComicSans.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComicSans.ForeColor = Color.White;
            lblComicSans.Location = new Point(37, 109);
            lblComicSans.Margin = new Padding(5);
            lblComicSans.Name = "lblComicSans";
            lblComicSans.Size = new Size(233, 23);
            lblComicSans.TabIndex = 25;
            lblComicSans.Text = "Comic Sans (dyslexia friendly)";
            lblComicSans.Click += lblComicSans_Click;
            // 
            // lblCentury
            // 
            lblCentury.Anchor = AnchorStyles.Left;
            lblCentury.AutoSize = true;
            lblCentury.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCentury.ForeColor = Color.White;
            lblCentury.Location = new Point(37, 84);
            lblCentury.Margin = new Padding(5);
            lblCentury.Name = "lblCentury";
            lblCentury.Size = new Size(71, 20);
            lblCentury.TabIndex = 24;
            lblCentury.Text = "Century";
            lblCentury.Click += lblCentury_Click;
            // 
            // lblBahnschrift
            // 
            lblBahnschrift.Anchor = AnchorStyles.Left;
            lblBahnschrift.AutoSize = true;
            lblBahnschrift.Font = new Font("Bahnschrift", 12F);
            lblBahnschrift.ForeColor = Color.White;
            lblBahnschrift.Location = new Point(37, 58);
            lblBahnschrift.Margin = new Padding(5);
            lblBahnschrift.Name = "lblBahnschrift";
            lblBahnschrift.Size = new Size(157, 19);
            lblBahnschrift.TabIndex = 23;
            lblBahnschrift.Text = "Bahnschrift (default)";
            lblBahnschrift.Click += lblBahnschrift_Click;
            // 
            // rbComicSans
            // 
            rbComicSans.Anchor = AnchorStyles.Right;
            rbComicSans.BorderThickness = 1.7F;
            rbComicSans.CheckColor = Color.White;
            rbComicSans.CheckRadius = 5F;
            rbComicSans.ForeColor = Color.White;
            rbComicSans.Location = new Point(10, 111);
            rbComicSans.Margin = new Padding(5);
            rbComicSans.Name = "rbComicSans";
            rbComicSans.Size = new Size(17, 17);
            rbComicSans.TabIndex = 22;
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
            rbCentury.Location = new Point(10, 84);
            rbCentury.Margin = new Padding(5);
            rbCentury.Name = "rbCentury";
            rbCentury.Size = new Size(17, 17);
            rbCentury.TabIndex = 21;
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
            rbBahnschrift.Location = new Point(10, 59);
            rbBahnschrift.Margin = new Padding(5);
            rbBahnschrift.Name = "rbBahnschrift";
            rbBahnschrift.Size = new Size(17, 17);
            rbBahnschrift.TabIndex = 20;
            rbBahnschrift.Text = "customRadioButton1";
            rbBahnschrift.CheckChanged += rbFontName_CheckChanged;
            // 
            // lblFontDescription
            // 
            lblFontDescription.Anchor = AnchorStyles.Left;
            lblFontDescription.Font = new Font("Bahnschrift", 10F);
            lblFontDescription.ForeColor = Color.FromArgb(168, 171, 174);
            lblFontDescription.Location = new Point(10, 35);
            lblFontDescription.Margin = new Padding(5);
            lblFontDescription.Name = "lblFontDescription";
            lblFontDescription.Size = new Size(319, 26);
            lblFontDescription.TabIndex = 19;
            lblFontDescription.Text = "Select the font you would like to use below";
            // 
            // lblFont
            // 
            lblFont.Anchor = AnchorStyles.Left;
            lblFont.AutoSize = true;
            lblFont.Font = new Font("Bahnschrift", 14F);
            lblFont.ForeColor = Color.White;
            lblFont.Location = new Point(10, 7);
            lblFont.Margin = new Padding(5);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(48, 23);
            lblFont.TabIndex = 18;
            lblFont.Text = "Font";
            // 
            // AppearanceSettingsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(pnlFont);
            Controls.Add(pnlToolTips);
            Controls.Add(pnlDarkMode);
            Controls.Add(approveChangesBar);
            Controls.Add(lblAppearance);
            Controls.Add(lblEditPromt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppearanceSettingsView";
            Text = "AppearanceSettingsView";
            pnlDarkMode.ResumeLayout(false);
            pnlDarkMode.PerformLayout();
            pnlToolTips.ResumeLayout(false);
            pnlToolTips.PerformLayout();
            pnlFont.ResumeLayout(false);
            pnlFont.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppearance;
        private Label lblEditPromt;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private CustomControls.CustomPanel pnlDarkMode;
        private Label lblDarkModeDescription;
        private Label lblDarkMode;
        private CustomControls.CustomRadioButton rbDarkMode;
        private CustomControls.CustomPanel pnlToolTips;
        private Label lblToolTipsDescription;
        private CustomControls.CustomRadioButton rbToolTips;
        private Label lblToolTips;
        private CustomControls.CustomPanel pnlFont;
        private Label lblFont;
        private CustomControls.CustomRadioButton rbComicSans;
        private CustomControls.CustomRadioButton rbCentury;
        private CustomControls.CustomRadioButton rbBahnschrift;
        private Label lblFontDescription;
        private Label lblBahnschrift;
        private Label lblCentury;
        private Label lblComicSans;
    }
}