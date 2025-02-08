namespace a2_coursework.View.Stock {
    partial class StockQuantityView {
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
            lblName = new Label();
            label1 = new Label();
            customTextBox1 = new CustomControls.CustomTextBox();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            lblEmergencyContactPhoneNumberError = new Label();
            numericUpDown1 = new CustomControls.CustomNumericUpDown();
            SuspendLayout();
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
            lblName.Size = new Size(80, 23);
            lblName.TabIndex = 12;
            lblName.Text = "Quantity";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 239);
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
            customTextBox1.Location = new Point(135, 272);
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
            lblEmergencyContactPhoneNumberError.Location = new Point(135, 317);
            lblEmergencyContactPhoneNumberError.Name = "lblEmergencyContactPhoneNumberError";
            lblEmergencyContactPhoneNumberError.Size = new Size(355, 38);
            lblEmergencyContactPhoneNumberError.TabIndex = 19;
            lblEmergencyContactPhoneNumberError.TextAlign = ContentAlignment.TopCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(135, 55);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(174, 41);
            numericUpDown1.TabIndex = 20;
            // 
            // StockQuantityView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(numericUpDown1);
            Controls.Add(lblEmergencyContactPhoneNumberError);
            Controls.Add(approveChangesBar);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(customTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockQuantityView";
            Text = "Stock_Details_view";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label label1;
        private CustomControls.CustomTextBox customTextBox1;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private Label lblEmergencyContactPhoneNumberError;
        private CustomControls.CustomNumericUpDown numericUpDown1;
    }
}
