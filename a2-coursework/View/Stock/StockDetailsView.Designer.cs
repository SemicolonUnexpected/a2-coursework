namespace a2_coursework.View.Stock {
    partial class StockDetailsView {
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
            tbCurrentPassword = new CustomControls.CustomTextBox();
            lblName = new Label();
            label1 = new Label();
            customTextBox1 = new CustomControls.CustomTextBox();
            customTextBox2 = new CustomControls.CustomTextBox();
            label2 = new Label();
            label3 = new Label();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            lblEmergencyContactPhoneNumberError = new Label();
            lblCharacterLimit = new Label();
            rbBahnschrift = new CustomControls.CustomRadioButton();
            pnlToolTips = new CustomControls.CustomPanel();
            pnlToolTips.SuspendLayout();
            SuspendLayout();
            // 
            // tbCurrentPassword
            // 
            tbCurrentPassword.Anchor = AnchorStyles.Top;
            tbCurrentPassword.BackColor = Color.FromArgb(9, 9, 10);
            tbCurrentPassword.BorderColor = Color.FromArgb(39, 39, 42);
            tbCurrentPassword.BorderThickness = 1F;
            tbCurrentPassword.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbCurrentPassword.Font = new Font("Bahnschrift", 12F);
            tbCurrentPassword.ForeColor = Color.Empty;
            tbCurrentPassword.HoverColor = Color.Empty;
            tbCurrentPassword.Location = new Point(135, 44);
            tbCurrentPassword.Margin = new Padding(5);
            tbCurrentPassword.MaxLength = 256;
            tbCurrentPassword.MultiLine = false;
            tbCurrentPassword.Name = "tbCurrentPassword";
            tbCurrentPassword.PlaceholderText = "Dettol Spray";
            tbCurrentPassword.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbCurrentPassword.ReadOnly = true;
            tbCurrentPassword.Size = new Size(355, 40);
            tbCurrentPassword.TabIndex = 1;
            tbCurrentPassword.TextAlign = HorizontalAlignment.Left;
            tbCurrentPassword.TextBoxInset = new Padding(10);
            tbCurrentPassword.UsePasswordChar = false;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 14F);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(135, 11);
            lblName.Margin = new Padding(5);
            lblName.Name = "lblName";
            lblName.Size = new Size(109, 23);
            lblName.TabIndex = 12;
            lblName.Text = "Stock name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 94);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 12;
            label1.Text = "SKU";
            // 
            // customTextBox1
            // 
            customTextBox1.Anchor = AnchorStyles.Top;
            customTextBox1.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox1.BorderColor = Color.FromArgb(39, 39, 42);
            customTextBox1.BorderThickness = 1F;
            customTextBox1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox1.Font = new Font("Bahnschrift", 12F);
            customTextBox1.ForeColor = Color.Empty;
            customTextBox1.HoverColor = Color.Empty;
            customTextBox1.Location = new Point(135, 127);
            customTextBox1.Margin = new Padding(5);
            customTextBox1.MaxLength = 256;
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "DET-123";
            customTextBox1.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            customTextBox1.ReadOnly = true;
            customTextBox1.Size = new Size(355, 40);
            customTextBox1.TabIndex = 1;
            customTextBox1.TextAlign = HorizontalAlignment.Left;
            customTextBox1.TextBoxInset = new Padding(10);
            customTextBox1.UsePasswordChar = false;
            // 
            // customTextBox2
            // 
            customTextBox2.Anchor = AnchorStyles.Top;
            customTextBox2.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox2.BorderColor = Color.FromArgb(39, 39, 42);
            customTextBox2.BorderThickness = 1F;
            customTextBox2.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox2.Font = new Font("Bahnschrift", 12F);
            customTextBox2.ForeColor = Color.Empty;
            customTextBox2.HoverColor = Color.Empty;
            customTextBox2.Location = new Point(135, 248);
            customTextBox2.Margin = new Padding(5);
            customTextBox2.MaxLength = 256;
            customTextBox2.MultiLine = true;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.PlaceholderText = "Dettol antibacterial surface cleaning Spray kills 99.9 percent of bacteria";
            customTextBox2.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            customTextBox2.ReadOnly = true;
            customTextBox2.Size = new Size(355, 130);
            customTextBox2.TabIndex = 1;
            customTextBox2.TextAlign = HorizontalAlignment.Left;
            customTextBox2.TextBoxInset = new Padding(10);
            customTextBox2.UsePasswordChar = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(135, 215);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 12;
            label2.Text = "Stock description";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 14F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 9);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 12;
            label3.Text = "Archived";
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
            // 
            // lblEmergencyContactPhoneNumberError
            // 
            lblEmergencyContactPhoneNumberError.Anchor = AnchorStyles.None;
            lblEmergencyContactPhoneNumberError.Font = new Font("Bahnschrift", 12F);
            lblEmergencyContactPhoneNumberError.ForeColor = Color.FromArgb(168, 171, 174);
            lblEmergencyContactPhoneNumberError.Location = new Point(135, 172);
            lblEmergencyContactPhoneNumberError.Name = "lblEmergencyContactPhoneNumberError";
            lblEmergencyContactPhoneNumberError.Size = new Size(355, 38);
            lblEmergencyContactPhoneNumberError.TabIndex = 19;
            lblEmergencyContactPhoneNumberError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCharacterLimit
            // 
            lblCharacterLimit.Anchor = AnchorStyles.None;
            lblCharacterLimit.Font = new Font("Bahnschrift", 12F);
            lblCharacterLimit.ForeColor = Color.FromArgb(168, 171, 174);
            lblCharacterLimit.Location = new Point(340, 383);
            lblCharacterLimit.Margin = new Padding(10, 0, 10, 20);
            lblCharacterLimit.Name = "lblCharacterLimit";
            lblCharacterLimit.Size = new Size(150, 24);
            lblCharacterLimit.TabIndex = 20;
            lblCharacterLimit.Text = "0/256";
            lblCharacterLimit.TextAlign = ContentAlignment.BottomRight;
            // 
            // rbBahnschrift
            // 
            rbBahnschrift.Anchor = AnchorStyles.Left;
            rbBahnschrift.BorderThickness = 1.7F;
            rbBahnschrift.CheckColor = Color.White;
            rbBahnschrift.Checked = true;
            rbBahnschrift.CheckRadius = 5F;
            rbBahnschrift.ForeColor = Color.White;
            rbBahnschrift.Location = new Point(324, 12);
            rbBahnschrift.Margin = new Padding(5);
            rbBahnschrift.Name = "rbBahnschrift";
            rbBahnschrift.Size = new Size(17, 17);
            rbBahnschrift.TabIndex = 21;
            rbBahnschrift.Text = "customRadioButton1";
            // 
            // pnlToolTips
            // 
            pnlToolTips.Anchor = AnchorStyles.None;
            pnlToolTips.BorderColor = Color.FromArgb(39, 39, 42);
            pnlToolTips.BorderThickness = 1F;
            pnlToolTips.Controls.Add(label3);
            pnlToolTips.Controls.Add(rbBahnschrift);
            pnlToolTips.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlToolTips.Location = new Point(135, 412);
            pnlToolTips.Margin = new Padding(5);
            pnlToolTips.Name = "pnlToolTips";
            pnlToolTips.Padding = new Padding(5);
            pnlToolTips.Size = new Size(355, 41);
            pnlToolTips.TabIndex = 22;
            // 
            // Stock_Details_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(pnlToolTips);
            Controls.Add(lblCharacterLimit);
            Controls.Add(lblEmergencyContactPhoneNumberError);
            Controls.Add(approveChangesBar);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(customTextBox2);
            Controls.Add(customTextBox1);
            Controls.Add(tbCurrentPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stock_Details_view";
            Text = "Stock_Details_view";
            pnlToolTips.ResumeLayout(false);
            pnlToolTips.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomTextBox tbCurrentPassword;
        private Label lblName;
        private Label label1;
        private CustomControls.CustomTextBox customTextBox1;
        private CustomControls.CustomTextBox customTextBox2;
        private Label label2;
        private Label label3;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private Label lblEmergencyContactPhoneNumberError;
        private Label lblCharacterLimit;
        private CustomControls.CustomRadioButton rbBahnschrift;
        private CustomControls.CustomPanel pnlToolTips;
    }
}