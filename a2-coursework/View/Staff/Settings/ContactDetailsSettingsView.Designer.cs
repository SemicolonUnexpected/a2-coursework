namespace a2_coursework.View {
    partial class ContactDetailsSettingsView {
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
            lblContactInformation = new Label();
            tbEmail = new a2_coursework.CustomControls.CustomTextBox();
            tbPhoneNumber = new a2_coursework.CustomControls.CustomTextBox();
            lblPhoneNumber = new Label();
            lblEditPromt = new Label();
            lblEmailTitle = new Label();
            approveChangesBar = new a2_coursework.User_Controls.Settings.ApproveChangesBar();
            tbAddress = new a2_coursework.CustomControls.CustomTextBox();
            lblAddressTitle = new Label();
            lblContactError = new Label();
            lblCharacterLimit = new Label();
            SuspendLayout();
            // 
            // lblContactInformation
            // 
            lblContactInformation.Anchor = AnchorStyles.None;
            lblContactInformation.AutoSize = true;
            lblContactInformation.Font = new Font("Bahnschrift", 24F);
            lblContactInformation.ForeColor = Color.White;
            lblContactInformation.Location = new Point(151, 10);
            lblContactInformation.Margin = new Padding(10);
            lblContactInformation.Name = "lblContactInformation";
            lblContactInformation.Size = new Size(299, 39);
            lblContactInformation.TabIndex = 8;
            lblContactInformation.Text = "Contact Information";
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.None;
            tbEmail.BackColor = Color.FromArgb(9, 9, 10);
            tbEmail.BorderColor = Color.FromArgb(39, 39, 42);
            tbEmail.BorderThickness = 1F;
            tbEmail.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbEmail.Font = new Font("Bahnschrift", 12F);
            tbEmail.ForeColor = Color.Empty;
            tbEmail.HoverColor = Color.Empty;
            tbEmail.Location = new Point(151, 136);
            tbEmail.Margin = new Padding(5);
            tbEmail.MaxLength = 255;
            tbEmail.MultiLine = false;
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "johndoe@example.com";
            tbEmail.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbEmail.ReadOnly = false;
            tbEmail.Size = new Size(355, 40);
            tbEmail.TabIndex = 7;
            tbEmail.TextAlign = HorizontalAlignment.Left;
            tbEmail.TextBoxInset = new Padding(10);
            tbEmail.ToolTipText = "This may be used to contact you in an emergency";
            tbEmail.UsePasswordChar = false;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Anchor = AnchorStyles.None;
            tbPhoneNumber.BackColor = Color.FromArgb(9, 9, 10);
            tbPhoneNumber.BorderColor = Color.FromArgb(39, 39, 42);
            tbPhoneNumber.BorderThickness = 1F;
            tbPhoneNumber.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbPhoneNumber.Font = new Font("Bahnschrift", 12F);
            tbPhoneNumber.ForeColor = Color.Empty;
            tbPhoneNumber.HoverColor = Color.Empty;
            tbPhoneNumber.Location = new Point(151, 219);
            tbPhoneNumber.Margin = new Padding(5);
            tbPhoneNumber.MaxLength = 20;
            tbPhoneNumber.MultiLine = false;
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.PlaceholderText = "+441234567890";
            tbPhoneNumber.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbPhoneNumber.ReadOnly = false;
            tbPhoneNumber.Size = new Size(355, 40);
            tbPhoneNumber.TabIndex = 9;
            tbPhoneNumber.TextAlign = HorizontalAlignment.Left;
            tbPhoneNumber.TextBoxInset = new Padding(10);
            tbPhoneNumber.ToolTipText = "This may be used to contact you in an emergency";
            tbPhoneNumber.UsePasswordChar = false;
            tbPhoneNumber.KeyPress += tbPhoneNumber_KeyPress;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Anchor = AnchorStyles.None;
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Bahnschrift", 14F);
            lblPhoneNumber.ForeColor = Color.White;
            lblPhoneNumber.Location = new Point(151, 186);
            lblPhoneNumber.Margin = new Padding(5);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(137, 23);
            lblPhoneNumber.TabIndex = 12;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEditPromt
            // 
            lblEditPromt.Anchor = AnchorStyles.None;
            lblEditPromt.AutoSize = true;
            lblEditPromt.Font = new Font("Bahnschrift", 12F);
            lblEditPromt.ForeColor = Color.FromArgb(168, 171, 174);
            lblEditPromt.Location = new Point(153, 59);
            lblEditPromt.Margin = new Padding(10, 0, 10, 20);
            lblEditPromt.Name = "lblEditPromt";
            lblEditPromt.Size = new Size(267, 19);
            lblEditPromt.TabIndex = 10;
            lblEditPromt.Text = "Edit your contact information below";
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.Anchor = AnchorStyles.None;
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.Font = new Font("Bahnschrift", 14F);
            lblEmailTitle.ForeColor = Color.White;
            lblEmailTitle.Location = new Point(153, 103);
            lblEmailTitle.Margin = new Padding(5);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(67, 23);
            lblEmailTitle.TabIndex = 11;
            lblEmailTitle.Text = "E-mail";
            // 
            // approveChangesBar
            // 
            approveChangesBar.BackColor = Color.FromArgb(9, 9, 10);
            approveChangesBar.Dock = DockStyle.Bottom;
            approveChangesBar.IsLoading = false;
            approveChangesBar.Location = new Point(0, 459);
            approveChangesBar.Name = "approveChangesBar";
            approveChangesBar.Size = new Size(654, 41);
            approveChangesBar.TabIndex = 13;
            approveChangesBar.ToolTipsActive = true;
            approveChangesBar.Visible = false;
            // 
            // tbAddress
            // 
            tbAddress.Anchor = AnchorStyles.None;
            tbAddress.BackColor = Color.FromArgb(9, 9, 10);
            tbAddress.BorderColor = Color.FromArgb(39, 39, 42);
            tbAddress.BorderThickness = 1F;
            tbAddress.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbAddress.Font = new Font("Bahnschrift", 12F);
            tbAddress.ForeColor = Color.Empty;
            tbAddress.HoverColor = Color.Empty;
            tbAddress.Location = new Point(151, 338);
            tbAddress.Margin = new Padding(5);
            tbAddress.MaximumSize = new Size(355, 79);
            tbAddress.MaxLength = 255;
            tbAddress.MultiLine = true;
            tbAddress.Name = "tbAddress";
            tbAddress.PlaceholderText = "6 Oak Tree Avenue\r\nLisburn\r\nDown";
            tbAddress.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbAddress.ReadOnly = false;
            tbAddress.Size = new Size(355, 79);
            tbAddress.TabIndex = 14;
            tbAddress.TextAlign = HorizontalAlignment.Left;
            tbAddress.TextBoxInset = new Padding(10);
            tbAddress.UsePasswordChar = false;
            tbAddress.TextChanged += tbAddress_TextChanged;
            // 
            // lblAddressTitle
            // 
            lblAddressTitle.Anchor = AnchorStyles.None;
            lblAddressTitle.AutoSize = true;
            lblAddressTitle.Font = new Font("Bahnschrift", 14F);
            lblAddressTitle.ForeColor = Color.White;
            lblAddressTitle.Location = new Point(151, 307);
            lblAddressTitle.Margin = new Padding(5);
            lblAddressTitle.Name = "lblAddressTitle";
            lblAddressTitle.Size = new Size(165, 23);
            lblAddressTitle.TabIndex = 15;
            lblAddressTitle.Text = "Address (optional)";
            // 
            // lblContactError
            // 
            lblContactError.Anchor = AnchorStyles.None;
            lblContactError.Font = new Font("Bahnschrift", 12F);
            lblContactError.ForeColor = Color.FromArgb(168, 171, 174);
            lblContactError.Location = new Point(151, 264);
            lblContactError.Name = "lblContactError";
            lblContactError.Size = new Size(355, 38);
            lblContactError.TabIndex = 16;
            lblContactError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCharacterLimit
            // 
            lblCharacterLimit.Anchor = AnchorStyles.None;
            lblCharacterLimit.Font = new Font("Bahnschrift", 12F);
            lblCharacterLimit.ForeColor = Color.FromArgb(168, 171, 174);
            lblCharacterLimit.Location = new Point(356, 422);
            lblCharacterLimit.Margin = new Padding(10, 0, 10, 20);
            lblCharacterLimit.Name = "lblCharacterLimit";
            lblCharacterLimit.Size = new Size(150, 24);
            lblCharacterLimit.TabIndex = 10;
            lblCharacterLimit.Text = "0/255";
            lblCharacterLimit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ContactDetailsSettingsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(lblContactError);
            Controls.Add(tbAddress);
            Controls.Add(lblAddressTitle);
            Controls.Add(approveChangesBar);
            Controls.Add(lblContactInformation);
            Controls.Add(tbEmail);
            Controls.Add(tbPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblCharacterLimit);
            Controls.Add(lblEditPromt);
            Controls.Add(lblEmailTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ContactDetailsSettingsView";
            Text = "ContactDetailsSettingsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContactInformation;
        private CustomControls.CustomTextBox tbEmail;
        private CustomControls.CustomTextBox tbPhoneNumber;
        private Label lblPhoneNumber;
        private Label lblEditPromt;
        private Label lblEmailTitle;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private CustomControls.CustomTextBox tbAddress;
        private Label lblAddressTitle;
        private Label lblContactError;
        private Label lblCharacterLimit;
    }
}