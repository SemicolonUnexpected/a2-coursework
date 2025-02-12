namespace a2_coursework.View.Users {
    partial class ChangePasswordView {
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
            sb = new CustomControls.CustomScrollBar();
            pnlHolder = new Panel();
            btnChangePassword = new CustomControls.CustomButton();
            lblChangePassword = new Label();
            lblEditPromt = new Label();
            pnlChangePassword = new CustomControls.CustomPanel();
            pbShowNewPassword = new PictureBox();
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
            tbNewPassword = new CustomControls.CustomTextBox();
            lblPasswordError = new Label();
            lblNewPassword = new Label();
            rbDarkMode = new CustomControls.CustomRadioButton();
            lblUsername = new Label();
            tbUsername = new CustomControls.CustomTextBox();
            lblUsernameError = new Label();
            toolTip = new ToolTip(components);
            pnlHolder.SuspendLayout();
            pnlChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowNewPassword).BeginInit();
            pnlPasswordValidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUppercaseLowercase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEightLong).BeginInit();
            SuspendLayout();
            // 
            // sb
            // 
            sb.BackColor = Color.FromArgb(9, 9, 10);
            sb.Dock = DockStyle.Right;
            sb.LargeChange = 50;
            sb.Location = new Point(644, 0);
            sb.Maximum = 100;
            sb.Minimum = 0;
            sb.MinimumThumbHeight = 30;
            sb.Name = "sb";
            sb.Padding = new Padding(2);
            sb.Size = new Size(10, 807);
            sb.SmallChange = 10;
            sb.TabIndex = 29;
            sb.Text = "customScrollBar1";
            sb.ThumbClickedColor = Color.FromArgb(39, 39, 42);
            sb.ThumbColor = Color.FromArgb(39, 39, 42);
            sb.ThumbCorderRadii = new CustomControls.CornerRadiiF(3F, 3F, 3F, 3F);
            sb.ThumbHoverColor = Color.FromArgb(39, 39, 42);
            sb.Visible = false;
            sb.ValueChanged += sb_ValueChanged;
            // 
            // pnlHolder
            // 
            pnlHolder.Anchor = AnchorStyles.None;
            pnlHolder.Controls.Add(btnChangePassword);
            pnlHolder.Controls.Add(lblChangePassword);
            pnlHolder.Controls.Add(lblEditPromt);
            pnlHolder.Controls.Add(pnlChangePassword);
            pnlHolder.Controls.Add(lblUsername);
            pnlHolder.Controls.Add(tbUsername);
            pnlHolder.Controls.Add(lblUsernameError);
            pnlHolder.Location = new Point(88, 0);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(483, 699);
            pnlHolder.TabIndex = 28;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.Top;
            btnChangePassword.BackColor = SystemColors.Control;
            btnChangePassword.BorderColor = Color.Empty;
            btnChangePassword.BorderThickness = 0F;
            btnChangePassword.ClickedBorderColor = Color.Empty;
            btnChangePassword.ClickedColor = Color.FromArgb(226, 226, 226);
            btnChangePassword.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.DisabledBorderColor = Color.Empty;
            btnChangePassword.DisabledColor = Color.FromArgb(226, 226, 226);
            btnChangePassword.Font = new Font("Bahnschrift", 12F);
            btnChangePassword.ForeColor = Color.FromArgb(9, 9, 10);
            btnChangePassword.HoverBorderColor = Color.Empty;
            btnChangePassword.HoverColor = Color.FromArgb(226, 226, 226);
            btnChangePassword.Image = null;
            btnChangePassword.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnChangePassword.Location = new Point(105, 649);
            btnChangePassword.Margin = new Padding(10);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(282, 40);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Change password";
            btnChangePassword.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnChangePassword.TextPosition = new Point(71, 10);
            // 
            // lblChangePassword
            // 
            lblChangePassword.Anchor = AnchorStyles.Top;
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new Font("Bahnschrift", 24F);
            lblChangePassword.ForeColor = Color.White;
            lblChangePassword.Location = new Point(69, 10);
            lblChangePassword.Margin = new Padding(10);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(276, 39);
            lblChangePassword.TabIndex = 17;
            lblChangePassword.Text = "Change Password";
            // 
            // lblEditPromt
            // 
            lblEditPromt.Anchor = AnchorStyles.Top;
            lblEditPromt.Font = new Font("Bahnschrift", 12F);
            lblEditPromt.ForeColor = Color.FromArgb(168, 171, 174);
            lblEditPromt.Location = new Point(69, 59);
            lblEditPromt.Margin = new Padding(10, 0, 10, 5);
            lblEditPromt.Name = "lblEditPromt";
            lblEditPromt.Size = new Size(355, 42);
            lblEditPromt.TabIndex = 18;
            lblEditPromt.Text = "Input a username, a new password and click \"Change Password\"";
            // 
            // pnlChangePassword
            // 
            pnlChangePassword.Anchor = AnchorStyles.Top;
            pnlChangePassword.BorderColor = Color.FromArgb(39, 39, 42);
            pnlChangePassword.BorderThickness = 1F;
            pnlChangePassword.Controls.Add(pbShowNewPassword);
            pnlChangePassword.Controls.Add(tbConfirmPassword);
            pnlChangePassword.Controls.Add(lblConfirmPassword);
            pnlChangePassword.Controls.Add(pnlPasswordValidation);
            pnlChangePassword.Controls.Add(tbNewPassword);
            pnlChangePassword.Controls.Add(lblPasswordError);
            pnlChangePassword.Controls.Add(lblNewPassword);
            pnlChangePassword.Controls.Add(rbDarkMode);
            pnlChangePassword.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlChangePassword.Location = new Point(69, 232);
            pnlChangePassword.Margin = new Padding(5);
            pnlChangePassword.Name = "pnlChangePassword";
            pnlChangePassword.Padding = new Padding(5);
            pnlChangePassword.Size = new Size(355, 412);
            pnlChangePassword.TabIndex = 2;
            // 
            // pbShowNewPassword
            // 
            pbShowNewPassword.Anchor = AnchorStyles.Top;
            pbShowNewPassword.Image = Properties.Resources.eye_crossed_light;
            pbShowNewPassword.Location = new Point(310, 56);
            pbShowNewPassword.Name = "pbShowNewPassword";
            pbShowNewPassword.Size = new Size(21, 21);
            pbShowNewPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbShowNewPassword.TabIndex = 30;
            pbShowNewPassword.TabStop = false;
            toolTip.SetToolTip(pbShowNewPassword, "Show the password");
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Anchor = AnchorStyles.Top;
            tbConfirmPassword.BackColor = Color.FromArgb(9, 9, 10);
            tbConfirmPassword.BorderColor = Color.FromArgb(39, 39, 42);
            tbConfirmPassword.BorderThickness = 1F;
            tbConfirmPassword.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbConfirmPassword.Font = new Font("Bahnschrift", 12F);
            tbConfirmPassword.ForeColor = Color.Empty;
            tbConfirmPassword.HoverColor = Color.Empty;
            tbConfirmPassword.Location = new Point(10, 306);
            tbConfirmPassword.Margin = new Padding(5);
            tbConfirmPassword.MaxLength = 256;
            tbConfirmPassword.MultiLine = false;
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PlaceholderText = "newPassword123!";
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
            lblConfirmPassword.Anchor = AnchorStyles.Top;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Bahnschrift", 14F);
            lblConfirmPassword.ForeColor = Color.White;
            lblConfirmPassword.Location = new Point(10, 273);
            lblConfirmPassword.Margin = new Padding(5);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(168, 23);
            lblConfirmPassword.TabIndex = 30;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // pnlPasswordValidation
            // 
            pnlPasswordValidation.Anchor = AnchorStyles.Top;
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
            pnlPasswordValidation.Location = new Point(10, 95);
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
            pbSpecialCharacter.Location = new Point(8, 133);
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
            pbNumber.Location = new Point(8, 93);
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
            pbUppercaseLowercase.Location = new Point(8, 53);
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
            pbEightLong.Location = new Point(8, 13);
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
            lblSpecialCharacter.Location = new Point(40, 133);
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
            lblNumber.Location = new Point(40, 93);
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
            lblUppercaseLowercase.Location = new Point(40, 53);
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
            lblEightLong.Location = new Point(40, 13);
            lblEightLong.Margin = new Padding(10);
            lblEightLong.Name = "lblEightLong";
            lblEightLong.Size = new Size(165, 19);
            lblEightLong.TabIndex = 19;
            lblEightLong.Text = "Eight characters long";
            // 
            // tbNewPassword
            // 
            tbNewPassword.Anchor = AnchorStyles.Top;
            tbNewPassword.BackColor = Color.FromArgb(9, 9, 10);
            tbNewPassword.BorderColor = Color.FromArgb(39, 39, 42);
            tbNewPassword.BorderThickness = 1F;
            tbNewPassword.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbNewPassword.Font = new Font("Bahnschrift", 12F);
            tbNewPassword.ForeColor = Color.Empty;
            tbNewPassword.HoverColor = Color.Empty;
            tbNewPassword.Location = new Point(10, 45);
            tbNewPassword.Margin = new Padding(5);
            tbNewPassword.MaxLength = 256;
            tbNewPassword.MultiLine = false;
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PlaceholderText = "newPassword123!";
            tbNewPassword.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbNewPassword.ReadOnly = false;
            tbNewPassword.Size = new Size(330, 40);
            tbNewPassword.TabIndex = 1;
            tbNewPassword.TextAlign = HorizontalAlignment.Left;
            tbNewPassword.TextBoxInset = new Padding(10);
            tbNewPassword.ToolTipText = "Include a special character, number and uppercase and lowercase";
            tbNewPassword.UsePasswordChar = true;
            // 
            // lblPasswordError
            // 
            lblPasswordError.Anchor = AnchorStyles.Top;
            lblPasswordError.Font = new Font("Bahnschrift", 12F);
            lblPasswordError.ForeColor = Color.FromArgb(168, 171, 174);
            lblPasswordError.Location = new Point(10, 351);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(330, 53);
            lblPasswordError.TabIndex = 25;
            lblPasswordError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Anchor = AnchorStyles.Top;
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Bahnschrift", 14F);
            lblNewPassword.ForeColor = Color.White;
            lblNewPassword.Location = new Point(10, 12);
            lblNewPassword.Margin = new Padding(5);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(138, 23);
            lblNewPassword.TabIndex = 23;
            lblNewPassword.Text = "New Password";
            // 
            // rbDarkMode
            // 
            rbDarkMode.Anchor = AnchorStyles.Right;
            rbDarkMode.BorderThickness = 1.7F;
            rbDarkMode.CheckColor = Color.White;
            rbDarkMode.Checked = true;
            rbDarkMode.CheckRadius = 5F;
            rbDarkMode.ForeColor = Color.White;
            rbDarkMode.Location = new Point(612, 396);
            rbDarkMode.Margin = new Padding(5);
            rbDarkMode.Name = "rbDarkMode";
            rbDarkMode.Size = new Size(17, 17);
            rbDarkMode.TabIndex = 0;
            rbDarkMode.Text = "customRadioButton1";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 14F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(69, 111);
            lblUsername.Margin = new Padding(5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 23);
            lblUsername.TabIndex = 23;
            lblUsername.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Top;
            tbUsername.BackColor = Color.FromArgb(9, 9, 10);
            tbUsername.BorderColor = Color.FromArgb(39, 39, 42);
            tbUsername.BorderThickness = 1F;
            tbUsername.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbUsername.Font = new Font("Bahnschrift", 12F);
            tbUsername.ForeColor = Color.Empty;
            tbUsername.HoverColor = Color.Empty;
            tbUsername.Location = new Point(69, 144);
            tbUsername.Margin = new Padding(5);
            tbUsername.MaxLength = 256;
            tbUsername.MultiLine = false;
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "jdoe1";
            tbUsername.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbUsername.ReadOnly = false;
            tbUsername.Size = new Size(355, 40);
            tbUsername.TabIndex = 0;
            tbUsername.TextAlign = HorizontalAlignment.Left;
            tbUsername.TextBoxInset = new Padding(10);
            tbUsername.UsePasswordChar = true;
            // 
            // lblUsernameError
            // 
            lblUsernameError.Anchor = AnchorStyles.Top;
            lblUsernameError.Font = new Font("Bahnschrift", 12F);
            lblUsernameError.ForeColor = Color.FromArgb(168, 171, 174);
            lblUsernameError.Location = new Point(69, 189);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(330, 38);
            lblUsernameError.TabIndex = 25;
            lblUsernameError.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChangePasswordView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 807);
            Controls.Add(sb);
            Controls.Add(pnlHolder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePasswordView";
            Text = "ChangePasswordView";
            pnlHolder.ResumeLayout(false);
            pnlHolder.PerformLayout();
            pnlChangePassword.ResumeLayout(false);
            pnlChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowNewPassword).EndInit();
            pnlPasswordValidation.ResumeLayout(false);
            pnlPasswordValidation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUppercaseLowercase).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEightLong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomScrollBar sb;
        private Panel pnlHolder;
        private PictureBox pbShowNewPassword;
        private CustomControls.CustomButton btnChangePassword;
        private Label lblChangePassword;
        private Label lblEditPromt;
        private CustomControls.CustomPanel pnlChangePassword;
        private CustomControls.CustomPanel pnlPasswordValidation;
        private PictureBox pbSpecialCharacter;
        private PictureBox pbNumber;
        private PictureBox pbUppercaseLowercase;
        private PictureBox pbEightLong;
        private Label lblSpecialCharacter;
        private Label lblNumber;
        private Label lblUppercaseLowercase;
        private Label lblEightLong;
        private CustomControls.CustomTextBox tbNewPassword;
        private CustomControls.CustomTextBox tbUsername;
        private Label lblPasswordError;
        private Label lblNewPassword;
        private Label lblUsername;
        private CustomControls.CustomRadioButton rbDarkMode;
        private CustomControls.CustomTextBox tbConfirmPassword;
        private Label lblConfirmPassword;
        private ToolTip toolTip;
        private Label lblUsernameError;
    }
}