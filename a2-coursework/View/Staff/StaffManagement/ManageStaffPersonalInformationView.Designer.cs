namespace a2_coursework.View.StaffView {
    partial class ManageStaffPersonalInformationView {
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
            diDateOfBirth = new CustomControls.DateInput();
            lblDateOfBirthError = new Label();
            lblNameError = new Label();
            tbForename = new CustomControls.CustomTextBox();
            lblDateOfBirthTitle = new Label();
            tbSurname = new CustomControls.CustomTextBox();
            lblSurnameTitle = new Label();
            lblForenameTitle = new Label();
            SuspendLayout();
            // 
            // diDateOfBirth
            // 
            diDateOfBirth.Anchor = AnchorStyles.None;
            diDateOfBirth.BorderColor = Color.FromArgb(39, 39, 42);
            diDateOfBirth.BorderErrorColor = Color.Red;
            diDateOfBirth.BorderThickness = 1F;
            diDateOfBirth.Day = null;
            diDateOfBirth.DayToolTip = "";
            diDateOfBirth.Location = new Point(150, 249);
            diDateOfBirth.MaxDate = null;
            diDateOfBirth.MaximumSize = new Size(180, 68);
            diDateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            diDateOfBirth.MinimumSize = new Size(180, 68);
            diDateOfBirth.Month = null;
            diDateOfBirth.MonthToolTip = "";
            diDateOfBirth.Name = "diDateOfBirth";
            diDateOfBirth.NullValid = true;
            diDateOfBirth.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            diDateOfBirth.ReadOnly = false;
            diDateOfBirth.Size = new Size(180, 68);
            diDateOfBirth.TabIndex = 20;
            diDateOfBirth.ToolTipsActive = true;
            diDateOfBirth.Year = null;
            diDateOfBirth.YearToolTip = "";
            // 
            // lblDateOfBirthError
            // 
            lblDateOfBirthError.Anchor = AnchorStyles.None;
            lblDateOfBirthError.Font = new Font("Bahnschrift", 12F);
            lblDateOfBirthError.ForeColor = Color.FromArgb(168, 171, 174);
            lblDateOfBirthError.Location = new Point(336, 276);
            lblDateOfBirthError.Name = "lblDateOfBirthError";
            lblDateOfBirthError.Size = new Size(169, 41);
            lblDateOfBirthError.TabIndex = 19;
            lblDateOfBirthError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNameError
            // 
            lblNameError.Anchor = AnchorStyles.None;
            lblNameError.Font = new Font("Bahnschrift", 12F);
            lblNameError.ForeColor = Color.FromArgb(168, 171, 174);
            lblNameError.Location = new Point(150, 175);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(355, 38);
            lblNameError.TabIndex = 18;
            lblNameError.TextAlign = ContentAlignment.TopCenter;
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
            tbForename.Location = new Point(150, 47);
            tbForename.Margin = new Padding(5);
            tbForename.MaxLength = 256;
            tbForename.MultiLine = false;
            tbForename.Name = "tbForename";
            tbForename.PlaceholderText = "John";
            tbForename.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbForename.ReadOnly = false;
            tbForename.Size = new Size(355, 40);
            tbForename.TabIndex = 13;
            tbForename.TextAlign = HorizontalAlignment.Left;
            tbForename.TextBoxInset = new Padding(10);
            tbForename.ToolTipText = "Type in your forname";
            tbForename.UsePasswordChar = false;
            // 
            // lblDateOfBirthTitle
            // 
            lblDateOfBirthTitle.Anchor = AnchorStyles.None;
            lblDateOfBirthTitle.AutoSize = true;
            lblDateOfBirthTitle.Font = new Font("Bahnschrift", 14F);
            lblDateOfBirthTitle.ForeColor = Color.White;
            lblDateOfBirthTitle.Location = new Point(150, 218);
            lblDateOfBirthTitle.Margin = new Padding(5);
            lblDateOfBirthTitle.Name = "lblDateOfBirthTitle";
            lblDateOfBirthTitle.Size = new Size(201, 23);
            lblDateOfBirthTitle.TabIndex = 17;
            lblDateOfBirthTitle.Text = "Date of Birth (optional)";
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
            tbSurname.Location = new Point(150, 130);
            tbSurname.Margin = new Padding(5);
            tbSurname.MaxLength = 256;
            tbSurname.MultiLine = false;
            tbSurname.Name = "tbSurname";
            tbSurname.PlaceholderText = "Doe";
            tbSurname.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSurname.ReadOnly = false;
            tbSurname.Size = new Size(355, 40);
            tbSurname.TabIndex = 14;
            tbSurname.TextAlign = HorizontalAlignment.Left;
            tbSurname.TextBoxInset = new Padding(10);
            tbSurname.ToolTipText = "Type in your surname";
            tbSurname.UsePasswordChar = false;
            // 
            // lblSurnameTitle
            // 
            lblSurnameTitle.Anchor = AnchorStyles.None;
            lblSurnameTitle.AutoSize = true;
            lblSurnameTitle.Font = new Font("Bahnschrift", 14F);
            lblSurnameTitle.ForeColor = Color.White;
            lblSurnameTitle.Location = new Point(150, 97);
            lblSurnameTitle.Margin = new Padding(5);
            lblSurnameTitle.Name = "lblSurnameTitle";
            lblSurnameTitle.Size = new Size(88, 23);
            lblSurnameTitle.TabIndex = 16;
            lblSurnameTitle.Text = "Surname";
            // 
            // lblForenameTitle
            // 
            lblForenameTitle.Anchor = AnchorStyles.None;
            lblForenameTitle.AutoSize = true;
            lblForenameTitle.Font = new Font("Bahnschrift", 14F);
            lblForenameTitle.ForeColor = Color.White;
            lblForenameTitle.Location = new Point(150, 14);
            lblForenameTitle.Margin = new Padding(5);
            lblForenameTitle.Name = "lblForenameTitle";
            lblForenameTitle.Size = new Size(96, 23);
            lblForenameTitle.TabIndex = 15;
            lblForenameTitle.Text = "Forename";
            // 
            // ManageStaffPersonalInformationView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(diDateOfBirth);
            Controls.Add(lblDateOfBirthError);
            Controls.Add(lblNameError);
            Controls.Add(tbForename);
            Controls.Add(lblDateOfBirthTitle);
            Controls.Add(tbSurname);
            Controls.Add(lblSurnameTitle);
            Controls.Add(lblForenameTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStaffPersonalInformationView";
            Text = "Personal Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.DateInput diDateOfBirth;
        private Label lblDateOfBirthError;
        private Label lblNameError;
        private CustomControls.CustomTextBox tbForename;
        private Label lblDateOfBirthTitle;
        private CustomControls.CustomTextBox tbSurname;
        private Label lblSurnameTitle;
        private Label lblForenameTitle;
    }
}