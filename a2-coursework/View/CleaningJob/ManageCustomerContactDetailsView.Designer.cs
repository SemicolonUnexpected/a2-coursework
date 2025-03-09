namespace a2_coursework.View.Order {
    partial class ViewCleaningJobCustomerView {
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
            tbEmail = new a2_coursework.CustomControls.CustomTextBox();
            tbPhoneNumber = new a2_coursework.CustomControls.CustomTextBox();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            lblName = new Label();
            tbName = new a2_coursework.CustomControls.CustomTextBox();
            SuspendLayout();
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
            tbEmail.Location = new Point(147, 195);
            tbEmail.Margin = new Padding(5);
            tbEmail.MaxLength = 256;
            tbEmail.MultiLine = false;
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "";
            tbEmail.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbEmail.ReadOnly = true;
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
            tbPhoneNumber.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbPhoneNumber.Font = new Font("Bahnschrift", 12F);
            tbPhoneNumber.ForeColor = Color.Empty;
            tbPhoneNumber.HoverColor = Color.Empty;
            tbPhoneNumber.Location = new Point(147, 278);
            tbPhoneNumber.Margin = new Padding(5);
            tbPhoneNumber.MaxLength = 256;
            tbPhoneNumber.MultiLine = false;
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.PlaceholderText = "";
            tbPhoneNumber.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbPhoneNumber.ReadOnly = true;
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
            lblPhoneNumber.Location = new Point(147, 245);
            lblPhoneNumber.Margin = new Padding(5);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(137, 23);
            lblPhoneNumber.TabIndex = 21;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Bahnschrift", 14F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(147, 162);
            lblEmail.Margin = new Padding(5);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(67, 23);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "E-mail";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 14F);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(147, 79);
            lblName.Margin = new Padding(5);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 23);
            lblName.TabIndex = 20;
            lblName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.None;
            tbName.BackColor = Color.FromArgb(9, 9, 10);
            tbName.BorderColor = Color.FromArgb(39, 39, 42);
            tbName.BorderThickness = 1F;
            tbName.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbName.Font = new Font("Bahnschrift", 12F);
            tbName.ForeColor = Color.Empty;
            tbName.HoverColor = Color.Empty;
            tbName.Location = new Point(147, 112);
            tbName.Margin = new Padding(5);
            tbName.MaxLength = 256;
            tbName.MultiLine = false;
            tbName.Name = "tbName";
            tbName.PlaceholderText = "";
            tbName.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbName.ReadOnly = true;
            tbName.Size = new Size(355, 40);
            tbName.TabIndex = 17;
            tbName.TextAlign = HorizontalAlignment.Left;
            tbName.TextBoxInset = new Padding(10);
            tbName.ToolTipText = "This may be used to contact you in an emergency";
            tbName.UsePasswordChar = false;
            // 
            // ViewCleaningJobCustomerView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(tbName);
            Controls.Add(tbEmail);
            Controls.Add(tbPhoneNumber);
            Controls.Add(lblName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewCleaningJobCustomerView";
            Text = "Contact Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.CustomTextBox tbEmail;
        private CustomControls.CustomTextBox tbPhoneNumber;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblName;
        private CustomControls.CustomTextBox tbName;
    }
}