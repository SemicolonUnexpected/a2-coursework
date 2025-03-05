namespace a2_coursework.View.CleaningJob {
    partial class  ManageCleaningJobDetailsView{
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
            tbExtraInformation = new a2_coursework.CustomControls.CustomTextBox();
            lblExtraInformation = new Label();
            lblExtraInformationCharacterLimit = new Label();
            lblAddressError = new Label();
            lblAddressCharacterLimit = new Label();
            lblAddress = new Label();
            tbAddress = new a2_coursework.CustomControls.CustomTextBox();
            SuspendLayout();
            // 
            // tbExtraInformation
            // 
            tbExtraInformation.Anchor = AnchorStyles.None;
            tbExtraInformation.BackColor = Color.FromArgb(9, 9, 10);
            tbExtraInformation.BorderColor = Color.FromArgb(39, 39, 42);
            tbExtraInformation.BorderThickness = 1F;
            tbExtraInformation.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbExtraInformation.Font = new Font("Bahnschrift", 12F);
            tbExtraInformation.ForeColor = Color.Empty;
            tbExtraInformation.HoverColor = Color.Empty;
            tbExtraInformation.Location = new Point(150, 243);
            tbExtraInformation.Margin = new Padding(5);
            tbExtraInformation.MaximumSize = new Size(355, 79);
            tbExtraInformation.MaxLength = 500;
            tbExtraInformation.MultiLine = true;
            tbExtraInformation.Name = "tbExtraInformation";
            tbExtraInformation.PlaceholderText = "Please close the gate as the customer has a dog.";
            tbExtraInformation.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbExtraInformation.ReadOnly = false;
            tbExtraInformation.Size = new Size(355, 79);
            tbExtraInformation.TabIndex = 22;
            tbExtraInformation.TextAlign = HorizontalAlignment.Left;
            tbExtraInformation.TextBoxInset = new Padding(10);
            tbExtraInformation.UsePasswordChar = false;
            // 
            // lblExtraInformation
            // 
            lblExtraInformation.Anchor = AnchorStyles.None;
            lblExtraInformation.AutoSize = true;
            lblExtraInformation.Font = new Font("Bahnschrift", 14F);
            lblExtraInformation.ForeColor = Color.White;
            lblExtraInformation.Location = new Point(150, 210);
            lblExtraInformation.Margin = new Padding(5);
            lblExtraInformation.Name = "lblExtraInformation";
            lblExtraInformation.Size = new Size(243, 23);
            lblExtraInformation.TabIndex = 23;
            lblExtraInformation.Text = "Extra Information (optional)";
            // 
            // lblExtraInformationCharacterLimit
            // 
            lblExtraInformationCharacterLimit.Anchor = AnchorStyles.None;
            lblExtraInformationCharacterLimit.Font = new Font("Bahnschrift", 12F);
            lblExtraInformationCharacterLimit.ForeColor = Color.FromArgb(168, 171, 174);
            lblExtraInformationCharacterLimit.Location = new Point(355, 327);
            lblExtraInformationCharacterLimit.Margin = new Padding(10, 0, 10, 20);
            lblExtraInformationCharacterLimit.Name = "lblExtraInformationCharacterLimit";
            lblExtraInformationCharacterLimit.Size = new Size(150, 24);
            lblExtraInformationCharacterLimit.TabIndex = 19;
            lblExtraInformationCharacterLimit.Text = "0/500";
            lblExtraInformationCharacterLimit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAddressError
            // 
            lblAddressError.Anchor = AnchorStyles.None;
            lblAddressError.Font = new Font("Bahnschrift", 12F);
            lblAddressError.ForeColor = Color.FromArgb(168, 171, 174);
            lblAddressError.Location = new Point(150, 167);
            lblAddressError.Name = "lblAddressError";
            lblAddressError.Size = new Size(355, 38);
            lblAddressError.TabIndex = 24;
            lblAddressError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAddressCharacterLimit
            // 
            lblAddressCharacterLimit.Anchor = AnchorStyles.None;
            lblAddressCharacterLimit.Font = new Font("Bahnschrift", 12F);
            lblAddressCharacterLimit.ForeColor = Color.FromArgb(168, 171, 174);
            lblAddressCharacterLimit.Location = new Point(355, 131);
            lblAddressCharacterLimit.Margin = new Padding(10, 0, 10, 20);
            lblAddressCharacterLimit.Name = "lblAddressCharacterLimit";
            lblAddressCharacterLimit.Size = new Size(150, 24);
            lblAddressCharacterLimit.TabIndex = 19;
            lblAddressCharacterLimit.Text = "0/500";
            lblAddressCharacterLimit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.None;
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Bahnschrift", 14F);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(150, 14);
            lblAddress.Margin = new Padding(5);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(80, 23);
            lblAddress.TabIndex = 23;
            lblAddress.Text = "Address";
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
            tbAddress.Location = new Point(150, 47);
            tbAddress.Margin = new Padding(5);
            tbAddress.MaximumSize = new Size(355, 79);
            tbAddress.MaxLength = 500;
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
            // ManageCleaningJobDetailsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(tbAddress);
            Controls.Add(lblAddressError);
            Controls.Add(lblAddress);
            Controls.Add(tbExtraInformation);
            Controls.Add(lblAddressCharacterLimit);
            Controls.Add(lblExtraInformation);
            Controls.Add(lblExtraInformationCharacterLimit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCleaningJobDetailsView";
            Text = "Contact Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.CustomTextBox tbExtraInformation;
        private Label lblExtraInformation;
        private Label lblExtraInformationCharacterLimit;
        private Label lblAddressError;
        private Label lblAddressCharacterLimit;
        private Label lblAddress;
        private CustomControls.CustomTextBox tbAddress;
    }
}