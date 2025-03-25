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
            tbEmergencyContactForename = new a2_coursework.CustomControls.CustomTextBox();
            tbEmergencyContactSurname = new a2_coursework.CustomControls.CustomTextBox();
            lblEmergencyContactSurnameTitle = new Label();
            lblEditPromt = new Label();
            lblEmergencyContactForenameTitle = new Label();
            tbEmergencyContactPhoneNumber = new a2_coursework.CustomControls.CustomTextBox();
            lblEmergencyContactPhoneNumberTitle = new Label();
            approveChangesBar = new a2_coursework.User_Controls.Settings.ApproveChangesBar();
            lblEmergencyContactPhoneNumberError = new Label();
            SuspendLayout();
            // 
            // lblEmergencyContactTitle
            // 
            lblEmergencyContactTitle.Anchor = AnchorStyles.None;
            lblEmergencyContactTitle.AutoSize = true;
            lblEmergencyContactTitle.Font = new Font("Bahnschrift", 24F);
            lblEmergencyContactTitle.ForeColor = Color.White;
            lblEmergencyContactTitle.Location = new Point(145, 19);
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
            tbEmergencyContactForename.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbEmergencyContactForename.Font = new Font("Bahnschrift", 12F);
            tbEmergencyContactForename.ForeColor = Color.Empty;
            tbEmergencyContactForename.HoverColor = Color.Empty;
            tbEmergencyContactForename.Location = new Point(145, 145);
            tbEmergencyContactForename.Margin = new Padding(5);
            tbEmergencyContactForename.MaxLength = 255;
            tbEmergencyContactForename.MultiLine = false;
            tbEmergencyContactForename.Name = "tbEmergencyContactForename";
            tbEmergencyContactForename.PlaceholderText = "Jane";
            tbEmergencyContactForename.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbEmergencyContactForename.ReadOnly = false;
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
            tbEmergencyContactSurname.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbEmergencyContactSurname.Font = new Font("Bahnschrift", 12F);
            tbEmergencyContactSurname.ForeColor = Color.Empty;
            tbEmergencyContactSurname.HoverColor = Color.Empty;
            tbEmergencyContactSurname.Location = new Point(145, 228);
            tbEmergencyContactSurname.Margin = new Padding(5);
            tbEmergencyContactSurname.MaxLength = 255;
            tbEmergencyContactSurname.MultiLine = false;
            tbEmergencyContactSurname.Name = "tbEmergencyContactSurname";
            tbEmergencyContactSurname.PlaceholderText = "Doe";
            tbEmergencyContactSurname.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbEmergencyContactSurname.ReadOnly = false;
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
            lblEmergencyContactSurnameTitle.Location = new Point(145, 195);
            lblEmergencyContactSurnameTitle.Margin = new Padding(5);
            lblEmergencyContactSurnameTitle.Name = "lblEmergencyContactSurnameTitle";
            lblEmergencyContactSurnameTitle.Size = new Size(341, 23);
            lblEmergencyContactSurnameTitle.TabIndex = 12;
            lblEmergencyContactSurnameTitle.Text = "Emergency Contact Surname (optional)";
            // 
            // lblEditPromt
            // 
            lblEditPromt.Anchor = AnchorStyles.None;
            lblEditPromt.AutoSize = true;
            lblEditPromt.Font = new Font("Bahnschrift", 12F);
            lblEditPromt.ForeColor = Color.FromArgb(168, 171, 174);
            lblEditPromt.Location = new Point(145, 68);
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
            lblEmergencyContactForenameTitle.Location = new Point(145, 112);
            lblEmergencyContactForenameTitle.Margin = new Padding(5);
            lblEmergencyContactForenameTitle.Name = "lblEmergencyContactForenameTitle";
            lblEmergencyContactForenameTitle.Size = new Size(349, 23);
            lblEmergencyContactForenameTitle.TabIndex = 11;
            lblEmergencyContactForenameTitle.Text = "Emergency Contact Forename (optional)";
            // 
            // tbEmergencyContactPhoneNumber
            // 
            tbEmergencyContactPhoneNumber.Anchor = AnchorStyles.None;
            tbEmergencyContactPhoneNumber.BackColor = Color.FromArgb(9, 9, 10);
            tbEmergencyContactPhoneNumber.BorderColor = Color.FromArgb(39, 39, 42);
            tbEmergencyContactPhoneNumber.BorderThickness = 1F;
            tbEmergencyContactPhoneNumber.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbEmergencyContactPhoneNumber.Font = new Font("Bahnschrift", 12F);
            tbEmergencyContactPhoneNumber.ForeColor = Color.Empty;
            tbEmergencyContactPhoneNumber.HoverColor = Color.Empty;
            tbEmergencyContactPhoneNumber.Location = new Point(145, 311);
            tbEmergencyContactPhoneNumber.Margin = new Padding(5);
            tbEmergencyContactPhoneNumber.MaxLength = 255;
            tbEmergencyContactPhoneNumber.MultiLine = false;
            tbEmergencyContactPhoneNumber.Name = "tbEmergencyContactPhoneNumber";
            tbEmergencyContactPhoneNumber.PlaceholderText = "+44 987 654 3210";
            tbEmergencyContactPhoneNumber.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbEmergencyContactPhoneNumber.ReadOnly = false;
            tbEmergencyContactPhoneNumber.Size = new Size(355, 40);
            tbEmergencyContactPhoneNumber.TabIndex = 13;
            tbEmergencyContactPhoneNumber.TextAlign = HorizontalAlignment.Left;
            tbEmergencyContactPhoneNumber.TextBoxInset = new Padding(10);
            tbEmergencyContactPhoneNumber.ToolTipText = "Provide a reliable phone number so your emergency contact can be reached";
            tbEmergencyContactPhoneNumber.UsePasswordChar = false;
            // 
            // lblEmergencyContactPhoneNumberTitle
            // 
            lblEmergencyContactPhoneNumberTitle.Anchor = AnchorStyles.None;
            lblEmergencyContactPhoneNumberTitle.AutoSize = true;
            lblEmergencyContactPhoneNumberTitle.Font = new Font("Bahnschrift", 14F);
            lblEmergencyContactPhoneNumberTitle.ForeColor = Color.White;
            lblEmergencyContactPhoneNumberTitle.Location = new Point(145, 278);
            lblEmergencyContactPhoneNumberTitle.Margin = new Padding(5);
            lblEmergencyContactPhoneNumberTitle.Name = "lblEmergencyContactPhoneNumberTitle";
            lblEmergencyContactPhoneNumberTitle.Size = new Size(390, 23);
            lblEmergencyContactPhoneNumberTitle.TabIndex = 14;
            lblEmergencyContactPhoneNumberTitle.Text = "Emergency Contact Phone Number (optional)";
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
            // lblEmergencyContactPhoneNumberError
            // 
            lblEmergencyContactPhoneNumberError.Anchor = AnchorStyles.None;
            lblEmergencyContactPhoneNumberError.Font = new Font("Bahnschrift", 12F);
            lblEmergencyContactPhoneNumberError.ForeColor = Color.FromArgb(168, 171, 174);
            lblEmergencyContactPhoneNumberError.Location = new Point(145, 356);
            lblEmergencyContactPhoneNumberError.Name = "lblEmergencyContactPhoneNumberError";
            lblEmergencyContactPhoneNumberError.Size = new Size(355, 38);
            lblEmergencyContactPhoneNumberError.TabIndex = 18;
            lblEmergencyContactPhoneNumberError.TextAlign = ContentAlignment.TopCenter;
            // 
            // EmergencyContactSettingsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(lblEmergencyContactPhoneNumberError);
            Controls.Add(approveChangesBar);
            Controls.Add(tbEmergencyContactPhoneNumber);
            Controls.Add(lblEmergencyContactPhoneNumberTitle);
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
        private Label lblEmergencyContactPhoneNumberTitle;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private Label lblEmergencyContactPhoneNumberError;
    }
}