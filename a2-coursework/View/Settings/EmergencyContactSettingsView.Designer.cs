namespace a2_coursework.View.Settings {
    partial class EmergencyContactSettingsView {
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
            lblEmergencyContactTitle = new Label();
            tbEmergencyContactForename = new CustomControls.CustomTextBox();
            tbEmergencyContactSurname = new CustomControls.CustomTextBox();
            lblEmergencyContactSurnameTitle = new Label();
            lblEditPromt = new Label();
            lblEmergencyContactForenameTitle = new Label();
            tbEmergencyContactPhoneNumber = new CustomControls.CustomTextBox();
            lblEmergencyContactPhoneNumber = new Label();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            lblEmergencyContactNameError = new Label();
            lblEmergencyPhoneNumberError = new Label();
            SuspendLayout();
            // 
            // lblEmergencyContactTitle
            // 
            lblEmergencyContactTitle.Anchor = AnchorStyles.None;
            lblEmergencyContactTitle.AutoSize = true;
            lblEmergencyContactTitle.Font = new Font("Bahnschrift", 24F);
            lblEmergencyContactTitle.ForeColor = Color.White;
            lblEmergencyContactTitle.Location = new Point(141, 19);
            lblEmergencyContactTitle.Margin = new Padding(10);
            lblEmergencyContactTitle.Name = "lblEmergencyContactTitle";
            lblEmergencyContactTitle.Size = new Size(293, 39);
            lblEmergencyContactTitle.TabIndex = 8;
            lblEmergencyContactTitle.Text = "Emergency Contact\r\n";
            // 
            // tbEmergencyContactForename
            // 
            tbEmergencyContactForename.Anchor = AnchorStyles.None;
            tbEmergencyContactForename.BackColor = Color.FromArgb(9, 9, 10);
            tbEmergencyContactForename.BorderColor = Color.FromArgb(39, 39, 42);
            tbEmergencyContactForename.BorderThickness = 1F;
            tbEmergencyContactForename.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbEmergencyContactForename.Font = new Font("Bahnschrift", 12F);
            tbEmergencyContactForename.ForeColor = Color.Empty;
            tbEmergencyContactForename.HoverColor = Color.Empty;
            tbEmergencyContactForename.Location = new Point(141, 145);
            tbEmergencyContactForename.Margin = new Padding(5);
            tbEmergencyContactForename.MaxLength = 256;
            tbEmergencyContactForename.MultiLine = false;
            tbEmergencyContactForename.Name = "tbEmergencyContactForename";
            tbEmergencyContactForename.PlaceholderText = "Jane";
            tbEmergencyContactForename.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbEmergencyContactForename.Size = new Size(355, 40);
            tbEmergencyContactForename.TabIndex = 7;
            tbEmergencyContactForename.TextAlign = HorizontalAlignment.Left;
            tbEmergencyContactForename.TextBoxInset = new Padding(10);
            tbEmergencyContactForename.UsePasswordChar = false;
            // 
            // tbEmergencyContactSurname
            // 
            tbEmergencyContactSurname.Anchor = AnchorStyles.None;
            tbEmergencyContactSurname.BackColor = Color.FromArgb(9, 9, 10);
            tbEmergencyContactSurname.BorderColor = Color.FromArgb(39, 39, 42);
            tbEmergencyContactSurname.BorderThickness = 1F;
            tbEmergencyContactSurname.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbEmergencyContactSurname.Font = new Font("Bahnschrift", 12F);
            tbEmergencyContactSurname.ForeColor = Color.Empty;
            tbEmergencyContactSurname.HoverColor = Color.Empty;
            tbEmergencyContactSurname.Location = new Point(141, 228);
            tbEmergencyContactSurname.Margin = new Padding(5);
            tbEmergencyContactSurname.MaxLength = 256;
            tbEmergencyContactSurname.MultiLine = false;
            tbEmergencyContactSurname.Name = "tbEmergencyContactSurname";
            tbEmergencyContactSurname.PlaceholderText = "Doe";
            tbEmergencyContactSurname.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbEmergencyContactSurname.Size = new Size(355, 40);
            tbEmergencyContactSurname.TabIndex = 9;
            tbEmergencyContactSurname.TextAlign = HorizontalAlignment.Left;
            tbEmergencyContactSurname.TextBoxInset = new Padding(10);
            tbEmergencyContactSurname.UsePasswordChar = false;
            // 
            // lblEmergencyContactSurnameTitle
            // 
            lblEmergencyContactSurnameTitle.Anchor = AnchorStyles.None;
            lblEmergencyContactSurnameTitle.AutoSize = true;
            lblEmergencyContactSurnameTitle.Font = new Font("Bahnschrift", 14F);
            lblEmergencyContactSurnameTitle.ForeColor = Color.White;
            lblEmergencyContactSurnameTitle.Location = new Point(141, 195);
            lblEmergencyContactSurnameTitle.Margin = new Padding(5);
            lblEmergencyContactSurnameTitle.Name = "lblEmergencyContactSurnameTitle";
            lblEmergencyContactSurnameTitle.Size = new Size(256, 23);
            lblEmergencyContactSurnameTitle.TabIndex = 12;
            lblEmergencyContactSurnameTitle.Text = "Emergency Contact Surname";
            // 
            // lblEditPromt
            // 
            lblEditPromt.Anchor = AnchorStyles.None;
            lblEditPromt.AutoSize = true;
            lblEditPromt.Font = new Font("Bahnschrift", 12F);
            lblEditPromt.ForeColor = Color.FromArgb(168, 171, 174);
            lblEditPromt.Location = new Point(141, 68);
            lblEditPromt.Margin = new Padding(10, 0, 10, 20);
            lblEditPromt.Name = "lblEditPromt";
            lblEditPromt.Size = new Size(353, 19);
            lblEditPromt.TabIndex = 10;
            lblEditPromt.Text = "Edit your emergency contact information below";
            // 
            // lblEmergencyContactForenameTitle
            // 
            lblEmergencyContactForenameTitle.Anchor = AnchorStyles.None;
            lblEmergencyContactForenameTitle.AutoSize = true;
            lblEmergencyContactForenameTitle.Font = new Font("Bahnschrift", 14F);
            lblEmergencyContactForenameTitle.ForeColor = Color.White;
            lblEmergencyContactForenameTitle.Location = new Point(141, 112);
            lblEmergencyContactForenameTitle.Margin = new Padding(5);
            lblEmergencyContactForenameTitle.Name = "lblEmergencyContactForenameTitle";
            lblEmergencyContactForenameTitle.Size = new Size(264, 23);
            lblEmergencyContactForenameTitle.TabIndex = 11;
            lblEmergencyContactForenameTitle.Text = "Emergency Contact Forename";
            // 
            // tbEmergencyContactPhoneNumber
            // 
            tbEmergencyContactPhoneNumber.Anchor = AnchorStyles.None;
            tbEmergencyContactPhoneNumber.BackColor = Color.FromArgb(9, 9, 10);
            tbEmergencyContactPhoneNumber.BorderColor = Color.FromArgb(39, 39, 42);
            tbEmergencyContactPhoneNumber.BorderThickness = 1F;
            tbEmergencyContactPhoneNumber.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbEmergencyContactPhoneNumber.Font = new Font("Bahnschrift", 12F);
            tbEmergencyContactPhoneNumber.ForeColor = Color.Empty;
            tbEmergencyContactPhoneNumber.HoverColor = Color.Empty;
            tbEmergencyContactPhoneNumber.Location = new Point(141, 349);
            tbEmergencyContactPhoneNumber.Margin = new Padding(5);
            tbEmergencyContactPhoneNumber.MaxLength = 256;
            tbEmergencyContactPhoneNumber.MultiLine = false;
            tbEmergencyContactPhoneNumber.Name = "tbEmergencyContactPhoneNumber";
            tbEmergencyContactPhoneNumber.PlaceholderText = "+449876543210";
            tbEmergencyContactPhoneNumber.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbEmergencyContactPhoneNumber.Size = new Size(355, 40);
            tbEmergencyContactPhoneNumber.TabIndex = 13;
            tbEmergencyContactPhoneNumber.TextAlign = HorizontalAlignment.Left;
            tbEmergencyContactPhoneNumber.TextBoxInset = new Padding(10);
            tbEmergencyContactPhoneNumber.UsePasswordChar = false;
            // 
            // lblEmergencyContactPhoneNumber
            // 
            lblEmergencyContactPhoneNumber.Anchor = AnchorStyles.None;
            lblEmergencyContactPhoneNumber.AutoSize = true;
            lblEmergencyContactPhoneNumber.Font = new Font("Bahnschrift", 14F);
            lblEmergencyContactPhoneNumber.ForeColor = Color.White;
            lblEmergencyContactPhoneNumber.Location = new Point(141, 316);
            lblEmergencyContactPhoneNumber.Margin = new Padding(5);
            lblEmergencyContactPhoneNumber.Name = "lblEmergencyContactPhoneNumber";
            lblEmergencyContactPhoneNumber.Size = new Size(305, 23);
            lblEmergencyContactPhoneNumber.TabIndex = 14;
            lblEmergencyContactPhoneNumber.Text = "Emergency Contact Phone Number";
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
            approveChangesBar.Visible = false;
            // 
            // lblContactError
            // 
            lblEmergencyContactNameError.Anchor = AnchorStyles.None;
            lblEmergencyContactNameError.Font = new Font("Bahnschrift", 12F);
            lblEmergencyContactNameError.ForeColor = Color.FromArgb(168, 171, 174);
            lblEmergencyContactNameError.Location = new Point(141, 273);
            lblEmergencyContactNameError.Name = "lblContactError";
            lblEmergencyContactNameError.Size = new Size(355, 38);
            lblEmergencyContactNameError.TabIndex = 17;
            lblEmergencyContactNameError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEmergencyPhoneError
            // 
            lblEmergencyPhoneNumberError.Anchor = AnchorStyles.None;
            lblEmergencyPhoneNumberError.Font = new Font("Bahnschrift", 12F);
            lblEmergencyPhoneNumberError.ForeColor = Color.FromArgb(168, 171, 174);
            lblEmergencyPhoneNumberError.Location = new Point(141, 394);
            lblEmergencyPhoneNumberError.Name = "lblEmergencyPhoneError";
            lblEmergencyPhoneNumberError.Size = new Size(355, 38);
            lblEmergencyPhoneNumberError.TabIndex = 18;
            lblEmergencyPhoneNumberError.TextAlign = ContentAlignment.TopCenter;
            // 
            // EmergencyContactSettingsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(lblEmergencyPhoneNumberError);
            Controls.Add(lblEmergencyContactNameError);
            Controls.Add(approveChangesBar);
            Controls.Add(tbEmergencyContactPhoneNumber);
            Controls.Add(lblEmergencyContactPhoneNumber);
            Controls.Add(lblEmergencyContactTitle);
            Controls.Add(tbEmergencyContactForename);
            Controls.Add(tbEmergencyContactSurname);
            Controls.Add(lblEmergencyContactSurnameTitle);
            Controls.Add(lblEditPromt);
            Controls.Add(lblEmergencyContactForenameTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmergencyContactSettingsView";
            Text = "EmergencyContactSettingsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmergencyContactTitle;
        private CustomControls.CustomTextBox tbEmergencyContactForename;
        private CustomControls.CustomTextBox tbEmergencyContactSurname;
        private Label lblEmergencyContactSurnameTitle;
        private Label lblEditPromt;
        private Label lblEmergencyContactForenameTitle;
        private CustomControls.CustomTextBox tbEmergencyContactPhoneNumber;
        private Label lblEmergencyContactPhoneNumber;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private Label lblEmergencyContactNameError;
        private Label lblEmergencyPhoneNumberError;
    }
}