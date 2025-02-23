namespace a2_coursework.View.Customer {
    partial class ManageCustomerContactDetailsView {
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
            lblContactError = new Label();
            tbAddress = new CustomControls.CustomTextBox();
            lblAddressTitle = new Label();
            tbEmail = new CustomControls.CustomTextBox();
            tbPhoneNumber = new CustomControls.CustomTextBox();
            lblPhoneNumber = new Label();
            lblCharacterLimit = new Label();
            lblEmailTitle = new Label();
            SuspendLayout();
            // 
            // lblContactError
            // 
            lblContactError.Anchor = AnchorStyles.None;
            lblContactError.Font = new Font("Bahnschrift", 12F);
            lblContactError.ForeColor = Color.FromArgb(168, 171, 174);
            lblContactError.Location = new Point(150, 175);
            lblContactError.Name = "lblContactError";
            lblContactError.Size = new Size(355, 38);
            lblContactError.TabIndex = 24;
            lblContactError.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbAddress
            // 
            tbAddress.Anchor = AnchorStyles.None;
            tbAddress.BackColor = Color.FromArgb(9, 9, 10);
            tbAddress.BorderColor = Color.FromArgb(39, 39, 42);
            tbAddress.BorderThickness = 1F;
            tbAddress.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbAddress.Font = new Font("Bahnschrift", 12F);
            tbAddress.ForeColor = Color.Empty;
            tbAddress.HoverColor = Color.Empty;
            tbAddress.Location = new Point(150, 249);
            tbAddress.Margin = new Padding(5);
            tbAddress.MaximumSize = new Size(355, 79);
            tbAddress.MaxLength = 256;
            tbAddress.MultiLine = true;
            tbAddress.Name = "tbAddress";
            tbAddress.PlaceholderText = "6 Oak Tree Avenue\r\nLisburn\r\nDown";
            tbAddress.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbAddress.ReadOnly = false;
            tbAddress.Size = new Size(355, 79);
            tbAddress.TabIndex = 22;
            tbAddress.TextAlign = HorizontalAlignment.Left;
            tbAddress.TextBoxInset = new Padding(10);
            tbAddress.UsePasswordChar = false;
            // 
            // lblAddressTitle
            // 
            lblAddressTitle.Anchor = AnchorStyles.None;
            lblAddressTitle.AutoSize = true;
            lblAddressTitle.Font = new Font("Bahnschrift", 14F);
            lblAddressTitle.ForeColor = Color.White;
            lblAddressTitle.Location = new Point(150, 218);
            lblAddressTitle.Margin = new Padding(5);
            lblAddressTitle.Name = "lblAddressTitle";
            lblAddressTitle.Size = new Size(165, 23);
            lblAddressTitle.TabIndex = 23;
            lblAddressTitle.Text = "Address (optional)";
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.None;
            tbEmail.BackColor = Color.FromArgb(9, 9, 10);
            tbEmail.BorderColor = Color.FromArgb(39, 39, 42);
            tbEmail.BorderThickness = 1F;
            tbEmail.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbEmail.Font = new Font("Bahnschrift", 12F);
            tbEmail.ForeColor = Color.Empty;
            tbEmail.HoverColor = Color.Empty;
            tbEmail.Location = new Point(150, 47);
            tbEmail.Margin = new Padding(5);
            tbEmail.MaxLength = 256;
            tbEmail.MultiLine = false;
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "johndoe@example.com";
            tbEmail.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbEmail.ReadOnly = false;
            tbEmail.Size = new Size(355, 40);
            tbEmail.TabIndex = 17;
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
            tbPhoneNumber.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbPhoneNumber.Font = new Font("Bahnschrift", 12F);
            tbPhoneNumber.ForeColor = Color.Empty;
            tbPhoneNumber.HoverColor = Color.Empty;
            tbPhoneNumber.Location = new Point(150, 130);
            tbPhoneNumber.Margin = new Padding(5);
            tbPhoneNumber.MaxLength = 256;
            tbPhoneNumber.MultiLine = false;
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.PlaceholderText = "+441234567890";
            tbPhoneNumber.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbPhoneNumber.ReadOnly = false;
            tbPhoneNumber.Size = new Size(355, 40);
            tbPhoneNumber.TabIndex = 18;
            tbPhoneNumber.TextAlign = HorizontalAlignment.Left;
            tbPhoneNumber.TextBoxInset = new Padding(10);
            tbPhoneNumber.ToolTipText = "This may be used to contact you in an emergency";
            tbPhoneNumber.UsePasswordChar = false;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Anchor = AnchorStyles.None;
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Bahnschrift", 14F);
            lblPhoneNumber.ForeColor = Color.White;
            lblPhoneNumber.Location = new Point(150, 97);
            lblPhoneNumber.Margin = new Padding(5);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(137, 23);
            lblPhoneNumber.TabIndex = 21;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblCharacterLimit
            // 
            lblCharacterLimit.Anchor = AnchorStyles.None;
            lblCharacterLimit.Font = new Font("Bahnschrift", 12F);
            lblCharacterLimit.ForeColor = Color.FromArgb(168, 171, 174);
            lblCharacterLimit.Location = new Point(355, 340);
            lblCharacterLimit.Margin = new Padding(10, 0, 10, 20);
            lblCharacterLimit.Name = "lblCharacterLimit";
            lblCharacterLimit.Size = new Size(150, 24);
            lblCharacterLimit.TabIndex = 19;
            lblCharacterLimit.Text = "0/256";
            lblCharacterLimit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.Anchor = AnchorStyles.None;
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.Font = new Font("Bahnschrift", 14F);
            lblEmailTitle.ForeColor = Color.White;
            lblEmailTitle.Location = new Point(150, 14);
            lblEmailTitle.Margin = new Padding(5);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(67, 23);
            lblEmailTitle.TabIndex = 20;
            lblEmailTitle.Text = "E-mail";
            // 
            // ManageStaffContactDetailsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(lblContactError);
            Controls.Add(tbAddress);
            Controls.Add(lblAddressTitle);
            Controls.Add(tbEmail);
            Controls.Add(tbPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblCharacterLimit);
            Controls.Add(lblEmailTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStaffContactDetailsView";
            Text = "Contact Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContactError;
        private CustomControls.CustomTextBox tbAddress;
        private Label lblAddressTitle;
        private CustomControls.CustomTextBox tbEmail;
        private CustomControls.CustomTextBox tbPhoneNumber;
        private Label lblPhoneNumber;
        private Label lblCharacterLimit;
        private Label lblEmailTitle;
    }
}