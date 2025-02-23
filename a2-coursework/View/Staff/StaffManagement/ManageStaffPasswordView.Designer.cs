namespace a2_coursework.View.Staff.StaffManagement {
    partial class ManageStaffPasswordView {
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
            components = new System.ComponentModel.Container();
            tbConfirmPassword = new CustomControls.CustomTextBox();
            lblConfirmPassword = new Label();
            pnlPasswordValidation = new CustomControls.CustomPanel();
            pbSpecialCharacter = new PictureBox();
            pbNumber = new PictureBox();
            pbUppercaseLowercase = new PictureBox();
            pbEightLong = new PictureBox();
            lblSpecialCharacter = new Label();
            lblNumber = new Label();
            lblUppercaseLowercase = new Label();
            lblEightLong = new Label();
            tbPassword = new CustomControls.CustomTextBox();
            lblPasswordError = new Label();
            lblPassword = new Label();
            pbShowPassword = new PictureBox();
            toolTip = new ToolTip(components);
            pnlPasswordValidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUppercaseLowercase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEightLong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).BeginInit();
            SuspendLayout();
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Anchor = AnchorStyles.None;
            tbConfirmPassword.BackColor = Color.FromArgb(9, 9, 10);
            tbConfirmPassword.BorderColor = Color.FromArgb(39, 39, 42);
            tbConfirmPassword.BorderThickness = 1F;
            tbConfirmPassword.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbConfirmPassword.Font = new Font("Bahnschrift", 12F);
            tbConfirmPassword.ForeColor = Color.Empty;
            tbConfirmPassword.HoverColor = Color.Empty;
            tbConfirmPassword.Location = new Point(153, 308);
            tbConfirmPassword.Margin = new Padding(5);
            tbConfirmPassword.MaxLength = 256;
            tbConfirmPassword.MultiLine = false;
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PlaceholderText = "Password123!";
            tbConfirmPassword.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbConfirmPassword.ReadOnly = false;
            tbConfirmPassword.Size = new Size(330, 40);
            tbConfirmPassword.TabIndex = 29;
            tbConfirmPassword.TextAlign = HorizontalAlignment.Left;
            tbConfirmPassword.TextBoxInset = new Padding(10);
            tbConfirmPassword.UsePasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Anchor = AnchorStyles.None;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Bahnschrift", 14F);
            lblConfirmPassword.ForeColor = Color.White;
            lblConfirmPassword.Location = new Point(153, 275);
            lblConfirmPassword.Margin = new Padding(5);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(168, 23);
            lblConfirmPassword.TabIndex = 30;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // pnlPasswordValidation
            // 
            pnlPasswordValidation.Anchor = AnchorStyles.None;
            pnlPasswordValidation.BorderColor = Color.FromArgb(39, 39, 42);
            pnlPasswordValidation.BorderThickness = 1F;
            pnlPasswordValidation.Controls.Add(pbSpecialCharacter);
            pnlPasswordValidation.Controls.Add(pbNumber);
            pnlPasswordValidation.Controls.Add(pbUppercaseLowercase);
            pnlPasswordValidation.Controls.Add(pbEightLong);
            pnlPasswordValidation.Controls.Add(lblSpecialCharacter);
            pnlPasswordValidation.Controls.Add(lblNumber);
            pnlPasswordValidation.Controls.Add(lblUppercaseLowercase);
            pnlPasswordValidation.Controls.Add(lblEightLong);
            pnlPasswordValidation.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlPasswordValidation.Location = new Point(153, 97);
            pnlPasswordValidation.Margin = new Padding(5);
            pnlPasswordValidation.Name = "pnlPasswordValidation";
            pnlPasswordValidation.Padding = new Padding(5);
            pnlPasswordValidation.Size = new Size(330, 168);
            pnlPasswordValidation.TabIndex = 28;
            // 
            // pbSpecialCharacter
            // 
            pbSpecialCharacter.Anchor = AnchorStyles.None;
            pbSpecialCharacter.Image = Properties.Resources.eye_crossed_light;
            pbSpecialCharacter.Location = new Point(11, 134);
            pbSpecialCharacter.Name = "pbSpecialCharacter";
            pbSpecialCharacter.Size = new Size(21, 21);
            pbSpecialCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpecialCharacter.TabIndex = 31;
            pbSpecialCharacter.TabStop = false;
            // 
            // pbNumber
            // 
            pbNumber.Anchor = AnchorStyles.None;
            pbNumber.Image = Properties.Resources.eye_crossed_light;
            pbNumber.Location = new Point(11, 94);
            pbNumber.Name = "pbNumber";
            pbNumber.Size = new Size(21, 21);
            pbNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNumber.TabIndex = 31;
            pbNumber.TabStop = false;
            // 
            // pbUppercaseLowercase
            // 
            pbUppercaseLowercase.Anchor = AnchorStyles.None;
            pbUppercaseLowercase.Image = Properties.Resources.eye_crossed_light;
            pbUppercaseLowercase.Location = new Point(11, 54);
            pbUppercaseLowercase.Name = "pbUppercaseLowercase";
            pbUppercaseLowercase.Size = new Size(21, 21);
            pbUppercaseLowercase.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUppercaseLowercase.TabIndex = 31;
            pbUppercaseLowercase.TabStop = false;
            // 
            // pbEightLong
            // 
            pbEightLong.Anchor = AnchorStyles.None;
            pbEightLong.Image = Properties.Resources.cross_light;
            pbEightLong.Location = new Point(11, 14);
            pbEightLong.Name = "pbEightLong";
            pbEightLong.Size = new Size(21, 21);
            pbEightLong.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEightLong.TabIndex = 31;
            pbEightLong.TabStop = false;
            // 
            // lblSpecialCharacter
            // 
            lblSpecialCharacter.Anchor = AnchorStyles.Top;
            lblSpecialCharacter.AutoSize = true;
            lblSpecialCharacter.Font = new Font("Bahnschrift", 12F);
            lblSpecialCharacter.ForeColor = Color.FromArgb(168, 171, 174);
            lblSpecialCharacter.Location = new Point(38, 133);
            lblSpecialCharacter.Margin = new Padding(10);
            lblSpecialCharacter.Name = "lblSpecialCharacter";
            lblSpecialCharacter.Size = new Size(150, 19);
            lblSpecialCharacter.TabIndex = 19;
            lblSpecialCharacter.Text = "A special character";
            // 
            // lblNumber
            // 
            lblNumber.Anchor = AnchorStyles.Top;
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Bahnschrift", 12F);
            lblNumber.ForeColor = Color.FromArgb(168, 171, 174);
            lblNumber.Location = new Point(38, 93);
            lblNumber.Margin = new Padding(10);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(80, 19);
            lblNumber.TabIndex = 19;
            lblNumber.Text = "A number";
            // 
            // lblUppercaseLowercase
            // 
            lblUppercaseLowercase.Anchor = AnchorStyles.Top;
            lblUppercaseLowercase.AutoSize = true;
            lblUppercaseLowercase.Font = new Font("Bahnschrift", 12F);
            lblUppercaseLowercase.ForeColor = Color.FromArgb(168, 171, 174);
            lblUppercaseLowercase.Location = new Point(38, 53);
            lblUppercaseLowercase.Margin = new Padding(10);
            lblUppercaseLowercase.Name = "lblUppercaseLowercase";
            lblUppercaseLowercase.Size = new Size(281, 19);
            lblUppercaseLowercase.TabIndex = 19;
            lblUppercaseLowercase.Text = "Uppercase and lowercase characters";
            // 
            // lblEightLong
            // 
            lblEightLong.Anchor = AnchorStyles.Top;
            lblEightLong.AutoSize = true;
            lblEightLong.Font = new Font("Bahnschrift", 12F);
            lblEightLong.ForeColor = Color.FromArgb(168, 171, 174);
            lblEightLong.Location = new Point(38, 13);
            lblEightLong.Margin = new Padding(10);
            lblEightLong.Name = "lblEightLong";
            lblEightLong.Size = new Size(165, 19);
            lblEightLong.TabIndex = 19;
            lblEightLong.Text = "Eight characters long";
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.None;
            tbPassword.BackColor = Color.FromArgb(9, 9, 10);
            tbPassword.BorderColor = Color.FromArgb(39, 39, 42);
            tbPassword.BorderThickness = 1F;
            tbPassword.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbPassword.Font = new Font("Bahnschrift", 12F);
            tbPassword.ForeColor = Color.Empty;
            tbPassword.HoverColor = Color.Empty;
            tbPassword.Location = new Point(153, 47);
            tbPassword.Margin = new Padding(5);
            tbPassword.MaxLength = 256;
            tbPassword.MultiLine = false;
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Password123!";
            tbPassword.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbPassword.ReadOnly = false;
            tbPassword.Size = new Size(330, 40);
            tbPassword.TabIndex = 1;
            tbPassword.TextAlign = HorizontalAlignment.Left;
            tbPassword.TextBoxInset = new Padding(10);
            tbPassword.ToolTipText = "Include a special character, number and uppercase and lowercase";
            tbPassword.UsePasswordChar = true;
            // 
            // lblPasswordError
            // 
            lblPasswordError.Anchor = AnchorStyles.None;
            lblPasswordError.Font = new Font("Bahnschrift", 12F);
            lblPasswordError.ForeColor = Color.FromArgb(168, 171, 174);
            lblPasswordError.Location = new Point(153, 353);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(330, 53);
            lblPasswordError.TabIndex = 25;
            lblPasswordError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Bahnschrift", 14F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(153, 14);
            lblPassword.Margin = new Padding(5);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 23);
            lblPassword.TabIndex = 23;
            lblPassword.Text = "Password";
            // 
            // pbShowPassword
            // 
            pbShowPassword.Anchor = AnchorStyles.None;
            pbShowPassword.Image = Properties.Resources.eye_crossed_light;
            pbShowPassword.Location = new Point(452, 58);
            pbShowPassword.Name = "pbShowPassword";
            pbShowPassword.Size = new Size(21, 21);
            pbShowPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbShowPassword.TabIndex = 31;
            pbShowPassword.TabStop = false;
            toolTip.SetToolTip(pbShowPassword, "Show password");
            pbShowPassword.Click += pbShowPassword_Click;
            // 
            // ManageStaffPasswordView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(pbShowPassword);
            Controls.Add(tbConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPasswordError);
            Controls.Add(pnlPasswordValidation);
            Controls.Add(tbPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStaffPasswordView";
            Text = "Password";
            pnlPasswordValidation.ResumeLayout(false);
            pnlPasswordValidation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUppercaseLowercase).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEightLong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomTextBox tbConfirmPassword;
        private Label lblConfirmPassword;
        private CustomControls.CustomPanel pnlPasswordValidation;
        private PictureBox pbSpecialCharacter;
        private PictureBox pbNumber;
        private PictureBox pbUppercaseLowercase;
        private PictureBox pbEightLong;
        private Label lblSpecialCharacter;
        private Label lblNumber;
        private Label lblUppercaseLowercase;
        private Label lblEightLong;
        private CustomControls.CustomTextBox tbPassword;
        private Label lblPasswordError;
        private Label lblPassword;
        private PictureBox pbShowPassword;
        private ToolTip toolTip;
    }
}