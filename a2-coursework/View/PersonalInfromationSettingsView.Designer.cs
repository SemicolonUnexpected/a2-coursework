namespace a2_coursework.View {
    partial class PersonalInfromationSettingsView {
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
            lblDateOfBirthErrorText = new Label();
            lblNameError = new Label();
            diDateOfBirth = new User_Controls.DateInput();
            lblDateOfBirthTitle = new Label();
            lblSurnameTitle = new Label();
            lblForenameTitle = new Label();
            lblEditPromt = new Label();
            tbSurname = new CustomControls.CustomTextBox();
            approveChangesBar1 = new User_Controls.Settings.ApproveChangesBar();
            SuspendLayout();
            // 
            // tbForename
            // 
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
            tbForename.Name = "tbForename";
            tbForename.PlaceholderText = "Forename";
            tbForename.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbForename.Size = new Size(355, 40);
            tbForename.TabIndex = 1;
            tbForename.TextBoxInset = new Padding(10);
            tbForename.UsePasswordChar = false;
            // 
            // lblPersonalInfo
            // 
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
            // lblDateOfBirthErrorText
            // 
            lblDateOfBirthErrorText.Font = new Font("Bahnschrift", 12F);
            lblDateOfBirthErrorText.ForeColor = Color.FromArgb(168, 171, 174);
            lblDateOfBirthErrorText.Location = new Point(344, 382);
            lblDateOfBirthErrorText.Name = "lblDateOfBirthErrorText";
            lblDateOfBirthErrorText.Size = new Size(195, 38);
            lblDateOfBirthErrorText.TabIndex = 10;
            lblDateOfBirthErrorText.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNameError
            // 
            lblNameError.Font = new Font("Bahnschrift", 12F);
            lblNameError.ForeColor = Color.FromArgb(168, 171, 174);
            lblNameError.Location = new Point(151, 273);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(388, 38);
            lblNameError.TabIndex = 9;
            lblNameError.TextAlign = ContentAlignment.TopCenter;
            // 
            // diDateOfBirth
            // 
            diDateOfBirth.BackColor = Color.FromArgb(9, 9, 10);
            diDateOfBirth.Location = new Point(138, 340);
            diDateOfBirth.MaximumSize = new Size(200, 100);
            diDateOfBirth.MinimumSize = new Size(200, 100);
            diDateOfBirth.Name = "diDateOfBirth";
            diDateOfBirth.Size = new Size(200, 100);
            diDateOfBirth.TabIndex = 8;
            diDateOfBirth.ErrorChanged += dateInput1_ErrorChanged;
            // 
            // lblDateOfBirthTitle
            // 
            lblDateOfBirthTitle.AutoSize = true;
            lblDateOfBirthTitle.Font = new Font("Bahnschrift", 14F);
            lblDateOfBirthTitle.ForeColor = Color.White;
            lblDateOfBirthTitle.Location = new Point(151, 316);
            lblDateOfBirthTitle.Margin = new Padding(5);
            lblDateOfBirthTitle.Name = "lblDateOfBirthTitle";
            lblDateOfBirthTitle.Size = new Size(116, 23);
            lblDateOfBirthTitle.TabIndex = 7;
            lblDateOfBirthTitle.Text = "Date of Birth";
            // 
            // lblSurnameTitle
            // 
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
            tbSurname.Name = "tbSurname";
            tbSurname.PlaceholderText = "Surname";
            tbSurname.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSurname.Size = new Size(355, 40);
            tbSurname.TabIndex = 3;
            tbSurname.TextBoxInset = new Padding(10);
            tbSurname.UsePasswordChar = false;
            // 
            // approveChangesBar1
            // 
            approveChangesBar1.BackColor = Color.FromArgb(9, 9, 10);
            approveChangesBar1.Dock = DockStyle.Bottom;
            approveChangesBar1.Location = new Point(0, 460);
            approveChangesBar1.Name = "approveChangesBar1";
            approveChangesBar1.Size = new Size(654, 40);
            approveChangesBar1.TabIndex = 11;
            // 
            // PersonalInfromationSettingsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(approveChangesBar1);
            Controls.Add(lblDateOfBirthErrorText);
            Controls.Add(lblNameError);
            Controls.Add(lblPersonalInfo);
            Controls.Add(diDateOfBirth);
            Controls.Add(tbForename);
            Controls.Add(lblDateOfBirthTitle);
            Controls.Add(tbSurname);
            Controls.Add(lblSurnameTitle);
            Controls.Add(lblEditPromt);
            Controls.Add(lblForenameTitle);
            ForeColor = Color.FromArgb(9, 9, 10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalInfromationSettingsView";
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
        private User_Controls.DateInput diDateOfBirth;
        private Label lblNameError;
        private Label lblDateOfBirthErrorText;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar1;
    }
}