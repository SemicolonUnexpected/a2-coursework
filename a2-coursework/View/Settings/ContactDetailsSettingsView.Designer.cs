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
            tbForename = new CustomControls.CustomTextBox();
            tbSurname = new CustomControls.CustomTextBox();
            lblSurnameTitle = new Label();
            lblEditPromt = new Label();
            lblEmailTitle = new Label();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            customTextBox1 = new CustomControls.CustomTextBox();
            label1 = new Label();
            lblContactError = new Label();
            lblAddressError = new Label();
            SuspendLayout();
            // 
            // lblContactInformation
            // 
            lblContactInformation.Anchor = AnchorStyles.None;
            lblContactInformation.AutoSize = true;
            lblContactInformation.Font = new Font("Bahnschrift", 24F);
            lblContactInformation.ForeColor = Color.White;
            lblContactInformation.Location = new Point(151, 19);
            lblContactInformation.Margin = new Padding(10);
            lblContactInformation.Name = "lblContactInformation";
            lblContactInformation.Size = new Size(299, 39);
            lblContactInformation.TabIndex = 8;
            lblContactInformation.Text = "Contact Information";
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
            tbForename.PlaceholderText = "johndoe@example.com";
            tbForename.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbForename.Size = new Size(355, 40);
            tbForename.TabIndex = 7;
            tbForename.TextAlign = HorizontalAlignment.Left;
            tbForename.TextBoxInset = new Padding(10);
            tbForename.UsePasswordChar = false;
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
            tbSurname.PlaceholderText = "+441234567890";
            tbSurname.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSurname.Size = new Size(355, 40);
            tbSurname.TabIndex = 9;
            tbSurname.TextAlign = HorizontalAlignment.Left;
            tbSurname.TextBoxInset = new Padding(10);
            tbSurname.UsePasswordChar = false;
            // 
            // lblSurnameTitle
            // 
            lblSurnameTitle.Anchor = AnchorStyles.None;
            lblSurnameTitle.AutoSize = true;
            lblSurnameTitle.Font = new Font("Bahnschrift", 14F);
            lblSurnameTitle.ForeColor = Color.White;
            lblSurnameTitle.Location = new Point(151, 195);
            lblSurnameTitle.Margin = new Padding(5);
            lblSurnameTitle.Name = "lblSurnameTitle";
            lblSurnameTitle.Size = new Size(137, 23);
            lblSurnameTitle.TabIndex = 12;
            lblSurnameTitle.Text = "Phone Number";
            // 
            // lblEditPromt
            // 
            lblEditPromt.Anchor = AnchorStyles.None;
            lblEditPromt.AutoSize = true;
            lblEditPromt.Font = new Font("Bahnschrift", 12F);
            lblEditPromt.ForeColor = Color.FromArgb(168, 171, 174);
            lblEditPromt.Location = new Point(153, 68);
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
            lblEmailTitle.Location = new Point(153, 112);
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
            approveChangesBar.Visible = false;
            // 
            // customTextBox1
            // 
            customTextBox1.Anchor = AnchorStyles.None;
            customTextBox1.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox1.BorderColor = Color.FromArgb(39, 39, 42);
            customTextBox1.BorderThickness = 1F;
            customTextBox1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox1.Font = new Font("Bahnschrift", 12F);
            customTextBox1.ForeColor = Color.Empty;
            customTextBox1.HoverColor = Color.Empty;
            customTextBox1.Location = new Point(151, 349);
            customTextBox1.Margin = new Padding(5);
            customTextBox1.MaxLength = 256;
            customTextBox1.MultiLine = true;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "6 Oak Tree Avenue\r\nLisburn";
            customTextBox1.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            customTextBox1.Size = new Size(355, 60);
            customTextBox1.TabIndex = 14;
            customTextBox1.TextAlign = HorizontalAlignment.Left;
            customTextBox1.TextBoxInset = new Padding(10);
            customTextBox1.UsePasswordChar = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(151, 316);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 15;
            label1.Text = "Address";
            // 
            // lblContactError
            // 
            lblContactError.Anchor = AnchorStyles.None;
            lblContactError.Font = new Font("Bahnschrift", 12F);
            lblContactError.ForeColor = Color.FromArgb(168, 171, 174);
            lblContactError.Location = new Point(151, 273);
            lblContactError.Name = "lblContactError";
            lblContactError.Size = new Size(355, 38);
            lblContactError.TabIndex = 16;
            lblContactError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAddressError
            // 
            lblAddressError.Anchor = AnchorStyles.None;
            lblAddressError.Font = new Font("Bahnschrift", 12F);
            lblAddressError.ForeColor = Color.FromArgb(168, 171, 174);
            lblAddressError.Location = new Point(151, 414);
            lblAddressError.Name = "lblAddressError";
            lblAddressError.Size = new Size(355, 38);
            lblAddressError.TabIndex = 17;
            lblAddressError.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContactDetailsSettingsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(lblAddressError);
            Controls.Add(lblContactError);
            Controls.Add(customTextBox1);
            Controls.Add(label1);
            Controls.Add(approveChangesBar);
            Controls.Add(lblContactInformation);
            Controls.Add(tbForename);
            Controls.Add(tbSurname);
            Controls.Add(lblSurnameTitle);
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
        private CustomControls.CustomTextBox tbForename;
        private CustomControls.CustomTextBox tbSurname;
        private Label lblSurnameTitle;
        private Label lblEditPromt;
        private Label lblEmailTitle;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private CustomControls.CustomTextBox customTextBox1;
        private Label label1;
        private Label lblContactError;
        private Label lblAddressError;
    }
}