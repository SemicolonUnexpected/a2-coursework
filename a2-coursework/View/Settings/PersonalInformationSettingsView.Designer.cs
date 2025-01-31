namespace a2_coursework.View.Settings {
    partial class PersonalInformationSettingsView {
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
            tbForename = new CustomControls.CustomTextBox();
            lblPersonalInfo = new Label();
            lblDateOfBirthError = new Label();
            lblNameError = new Label();
            lblDateOfBirthTitle = new Label();
            lblSurnameTitle = new Label();
            lblForenameTitle = new Label();
            lblEditPromt = new Label();
            tbSurname = new CustomControls.CustomTextBox();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            diDateOfBirth = new CustomControls.DateInput();
            SuspendLayout();
            // 
            // tbForename
            // 
            tbForename.Anchor = AnchorStyles.None;
            tbForename.BackColor = Color.FromArgb(9, 9, 10);
            tbForename.BorderColor = Color.FromArgb(39, 39, 42);
            tbForename.BorderThickness = 1F;
            tbForename.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbForename.Font = new Font("Bahnschrift", 12F);
            tbForename.ForeColor = Color.Empty;
            tbForename.HoverColor = Color.Empty;
            tbForename.Location = new Point(151, 145);
            tbForename.Margin = new Padding(5);
            tbForename.MaxLength = 256;
            tbForename.MultiLine = false;
            tbForename.Name = "tbForename";
            tbForename.PlaceholderText = "John";
            tbForename.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbForename.Size = new Size(355, 40);
            tbForename.TabIndex = 1;
            tbForename.TextAlign = HorizontalAlignment.Left;
            tbForename.TextBoxInset = new Padding(10);
            tbForename.UsePasswordChar = false;
            // 
            // lblPersonalInfo
            // 
            lblPersonalInfo.Anchor = AnchorStyles.None;
            lblPersonalInfo.AutoSize = true;
            lblPersonalInfo.Font = new Font("Bahnschrift", 24F);
            lblPersonalInfo.ForeColor = Color.White;
            lblPersonalInfo.Location = new Point(145, 19);
            lblPersonalInfo.Margin = new Padding(10);
            lblPersonalInfo.Name = "lblPersonalInfo";
            lblPersonalInfo.Size = new Size(319, 39);
            lblPersonalInfo.TabIndex = 2;
            lblPersonalInfo.Text = "Personal Information";
            // 
            // lblDateOfBirthError
            // 
            lblDateOfBirthError.Anchor = AnchorStyles.None;
            lblDateOfBirthError.Font = new Font("Bahnschrift", 12F);
            lblDateOfBirthError.ForeColor = Color.FromArgb(168, 171, 174);
            lblDateOfBirthError.Location = new Point(344, 378);
            lblDateOfBirthError.Name = "lblDateOfBirthError";
            lblDateOfBirthError.Size = new Size(162, 37);
            lblDateOfBirthError.TabIndex = 10;
            lblDateOfBirthError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNameError
            // 
            lblNameError.Anchor = AnchorStyles.None;
            lblNameError.Font = new Font("Bahnschrift", 12F);
            lblNameError.ForeColor = Color.FromArgb(168, 171, 174);
            lblNameError.Location = new Point(151, 273);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(355, 38);
            lblNameError.TabIndex = 9;
            lblNameError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDateOfBirthTitle
            // 
            lblDateOfBirthTitle.Anchor = AnchorStyles.None;
            lblDateOfBirthTitle.AutoSize = true;
            lblDateOfBirthTitle.Font = new Font("Bahnschrift", 14F);
            lblDateOfBirthTitle.ForeColor = Color.White;
            lblDateOfBirthTitle.Location = new Point(151, 316);
            lblDateOfBirthTitle.Margin = new Padding(5);
            lblDateOfBirthTitle.Name = "lblDateOfBirthTitle";
            lblDateOfBirthTitle.Size = new Size(201, 23);
            lblDateOfBirthTitle.TabIndex = 7;
            lblDateOfBirthTitle.Text = "Date of Birth (optional)";
            // 
            // lblSurnameTitle
            // 
            lblSurnameTitle.Anchor = AnchorStyles.None;
            lblSurnameTitle.AutoSize = true;
            lblSurnameTitle.Font = new Font("Bahnschrift", 14F);
            lblSurnameTitle.ForeColor = Color.White;
            lblSurnameTitle.Location = new Point(149, 195);
            lblSurnameTitle.Margin = new Padding(5);
            lblSurnameTitle.Name = "lblSurnameTitle";
            lblSurnameTitle.Size = new Size(88, 23);
            lblSurnameTitle.TabIndex = 6;
            lblSurnameTitle.Text = "Surname";
            // 
            // lblForenameTitle
            // 
            lblForenameTitle.Anchor = AnchorStyles.None;
            lblForenameTitle.AutoSize = true;
            lblForenameTitle.Font = new Font("Bahnschrift", 14F);
            lblForenameTitle.ForeColor = Color.White;
            lblForenameTitle.Location = new Point(149, 112);
            lblForenameTitle.Margin = new Padding(5);
            lblForenameTitle.Name = "lblForenameTitle";
            lblForenameTitle.Size = new Size(96, 23);
            lblForenameTitle.TabIndex = 5;
            lblForenameTitle.Text = "Forename";
            // 
            // lblEditPromt
            // 
            lblEditPromt.Anchor = AnchorStyles.None;
            lblEditPromt.AutoSize = true;
            lblEditPromt.Font = new Font("Bahnschrift", 12F);
            lblEditPromt.ForeColor = Color.FromArgb(168, 171, 174);
            lblEditPromt.Location = new Point(149, 68);
            lblEditPromt.Margin = new Padding(10, 0, 10, 20);
            lblEditPromt.Name = "lblEditPromt";
            lblEditPromt.Size = new Size(279, 19);
            lblEditPromt.TabIndex = 4;
            lblEditPromt.Text = "Edit your personal information below";
            // 
            // tbSurname
            // 
            tbSurname.Anchor = AnchorStyles.None;
            tbSurname.BackColor = Color.FromArgb(9, 9, 10);
            tbSurname.BorderColor = Color.FromArgb(39, 39, 42);
            tbSurname.BorderThickness = 1F;
            tbSurname.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbSurname.Font = new Font("Bahnschrift", 12F);
            tbSurname.ForeColor = Color.Empty;
            tbSurname.HoverColor = Color.Empty;
            tbSurname.Location = new Point(151, 228);
            tbSurname.Margin = new Padding(5);
            tbSurname.MaxLength = 256;
            tbSurname.MultiLine = false;
            tbSurname.Name = "tbSurname";
            tbSurname.PlaceholderText = "Doe";
            tbSurname.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSurname.Size = new Size(355, 40);
            tbSurname.TabIndex = 3;
            tbSurname.TextAlign = HorizontalAlignment.Left;
            tbSurname.TextBoxInset = new Padding(10);
            tbSurname.UsePasswordChar = false;
            // 
            // approveChangesBar
            // 
            approveChangesBar.BackColor = Color.FromArgb(9, 9, 10);
            approveChangesBar.Dock = DockStyle.Bottom;
            approveChangesBar.IsLoading = false;
            approveChangesBar.Location = new Point(0, 459);
            approveChangesBar.Name = "approveChangesBar";
            approveChangesBar.Size = new Size(654, 41);
            approveChangesBar.TabIndex = 11;
            approveChangesBar.Visible = false;
            // 
            // diDateOfBirth
            // 
            diDateOfBirth.Anchor = AnchorStyles.None;
            diDateOfBirth.BorderColor = Color.FromArgb(39, 39, 42);
            diDateOfBirth.BorderErrorColor = Color.Red;
            diDateOfBirth.BorderThickness = 1F;
            diDateOfBirth.Day = null;
            diDateOfBirth.Location = new Point(151, 347);
            diDateOfBirth.MaxDate = null;
            diDateOfBirth.MaximumSize = new Size(180, 68);
            diDateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            diDateOfBirth.MinimumSize = new Size(180, 68);
            diDateOfBirth.Month = null;
            diDateOfBirth.Name = "diDateOfBirth";
            diDateOfBirth.NullValid = true;
            diDateOfBirth.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            diDateOfBirth.ShowPlaceholder = false;
            diDateOfBirth.Size = new Size(180, 68);
            diDateOfBirth.TabIndex = 12;
            diDateOfBirth.Year = null;
            // 
            // PersonalInformationSettingsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(diDateOfBirth);
            Controls.Add(approveChangesBar);
            Controls.Add(lblDateOfBirthError);
            Controls.Add(lblNameError);
            Controls.Add(lblPersonalInfo);
            Controls.Add(tbForename);
            Controls.Add(lblDateOfBirthTitle);
            Controls.Add(tbSurname);
            Controls.Add(lblSurnameTitle);
            Controls.Add(lblEditPromt);
            Controls.Add(lblForenameTitle);
            ForeColor = Color.FromArgb(9, 9, 10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalInformationSettingsView";
            Text = "SettingsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomTextBox tbForename;
        private Label lblPersonalInfo;
        private CustomControls.CustomTextBox tbSurname;
        private Label lblEditPromt;
        private Label lblForenameTitle;
        private Label lblSurnameTitle;
        private Label lblDateOfBirthTitle;
        private Label lblNameError;
        private Label lblDateOfBirthError;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private CustomControls.DateInput diDateOfBirth;
    }
}