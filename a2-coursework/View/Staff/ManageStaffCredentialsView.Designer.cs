namespace a2_coursework.View.Stock {
    partial class ManageStaffCredentialsView {
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
            pbShowNewPassword = new PictureBox();
            lblPrivilegeLevel = new Label();
            btnChangePassword = new CustomControls.CustomButton();
            tbUsername = new CustomControls.CustomTextBox();
            pnlChangePassword = new CustomControls.CustomPanel();
            pnlPasswordValidation = new CustomControls.CustomPanel();
            pbSpecialCharacter = new PictureBox();
            pbNumber = new PictureBox();
            pbUppercaseLowercase = new PictureBox();
            pbEightLong = new PictureBox();
            lblSpecialCharacter = new Label();
            lblNumber = new Label();
            lblUppercaseLowercase = new Label();
            lblEightLong = new Label();
            tbConfirmPassword = new CustomControls.CustomTextBox();
            tbNewPassword = new CustomControls.CustomTextBox();
            lblPasswordError = new Label();
            lblConfirmPassword = new Label();
            lblNewPassword = new Label();
            lblChangePassword = new Label();
            lblUsername = new Label();
            toolTip = new ToolTip(components);
            cbPrivilegeLevel = new ComboBox();
            pnlHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowNewPassword).BeginInit();
            pnlChangePassword.SuspendLayout();
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
            sb.Size = new Size(10, 419);
            sb.SmallChange = 10;
            sb.TabIndex = 29;
            sb.Text = "customScrollBar1";
            sb.ThumbClickedColor = Color.FromArgb(39, 39, 42);
            sb.ThumbColor = Color.FromArgb(39, 39, 42);
            sb.ThumbCorderRadii = new CustomControls.CornerRadiiF(3F, 3F, 3F, 3F);
            sb.ThumbHoverColor = Color.FromArgb(39, 39, 42);
            sb.Visible = false;
            // 
            // pnlHolder
            // 
            pnlHolder.Anchor = AnchorStyles.None;
            pnlHolder.Controls.Add(cbPrivilegeLevel);
            pnlHolder.Controls.Add(lblPrivilegeLevel);
            pnlHolder.Controls.Add(btnChangePassword);
            pnlHolder.Controls.Add(tbUsername);
            pnlHolder.Controls.Add(pnlChangePassword);
            pnlHolder.Controls.Add(lblUsername);
            pnlHolder.Location = new Point(83, 0);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(483, 730);
            pnlHolder.TabIndex = 28;
            // 
            // pbShowNewPassword
            // 
            pbShowNewPassword.Anchor = AnchorStyles.Top;
            pbShowNewPassword.Image = Properties.Resources.eye_crossed_light;
            pbShowNewPassword.Location = new Point(309, 86);
            pbShowNewPassword.Name = "pbShowNewPassword";
            pbShowNewPassword.Size = new Size(21, 21);
            pbShowNewPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbShowNewPassword.TabIndex = 30;
            pbShowNewPassword.TabStop = false;
            // 
            // lblPrivilegeLevel
            // 
            lblPrivilegeLevel.Anchor = AnchorStyles.Top;
            lblPrivilegeLevel.AutoSize = true;
            lblPrivilegeLevel.Font = new Font("Bahnschrift", 14F);
            lblPrivilegeLevel.ForeColor = Color.White;
            lblPrivilegeLevel.Location = new Point(64, 97);
            lblPrivilegeLevel.Margin = new Padding(5);
            lblPrivilegeLevel.Name = "lblPrivilegeLevel";
            lblPrivilegeLevel.Size = new Size(138, 23);
            lblPrivilegeLevel.TabIndex = 23;
            lblPrivilegeLevel.Text = "Privilege Level";
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
            btnChangePassword.Location = new Point(100, 617);
            btnChangePassword.Margin = new Padding(10);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(282, 40);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Change password";
            btnChangePassword.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnChangePassword.TextPosition = new Point(71, 10);
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
            tbUsername.Location = new Point(64, 47);
            tbUsername.Margin = new Padding(5);
            tbUsername.MaxLength = 256;
            tbUsername.MultiLine = false;
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "jdoe1";
            tbUsername.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbUsername.ReadOnly = true;
            tbUsername.Size = new Size(355, 40);
            tbUsername.TabIndex = 0;
            tbUsername.TextAlign = HorizontalAlignment.Left;
            tbUsername.TextBoxInset = new Padding(10);
            tbUsername.ToolTipText = "Ask an admin to change your username";
            tbUsername.UsePasswordChar = false;
            // 
            // pnlChangePassword
            // 
            pnlChangePassword.Anchor = AnchorStyles.Top;
            pnlChangePassword.BorderColor = Color.FromArgb(39, 39, 42);
            pnlChangePassword.BorderThickness = 1F;
            pnlChangePassword.Controls.Add(pbShowNewPassword);
            pnlChangePassword.Controls.Add(pnlPasswordValidation);
            pnlChangePassword.Controls.Add(tbConfirmPassword);
            pnlChangePassword.Controls.Add(tbNewPassword);
            pnlChangePassword.Controls.Add(lblPasswordError);
            pnlChangePassword.Controls.Add(lblConfirmPassword);
            pnlChangePassword.Controls.Add(lblNewPassword);
            pnlChangePassword.Controls.Add(lblChangePassword);
            pnlChangePassword.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlChangePassword.Location = new Point(64, 169);
            pnlChangePassword.Margin = new Padding(5);
            pnlChangePassword.Name = "pnlChangePassword";
            pnlChangePassword.Padding = new Padding(5);
            pnlChangePassword.Size = new Size(355, 446);
            pnlChangePassword.TabIndex = 2;
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
            pnlPasswordValidation.Location = new Point(10, 126);
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
            pbSpecialCharacter.Location = new Point(8, 128);
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
            pbNumber.Location = new Point(8, 88);
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
            pbUppercaseLowercase.Location = new Point(8, 48);
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
            pbEightLong.Location = new Point(8, 8);
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
            lblSpecialCharacter.Location = new Point(42, 128);
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
            lblNumber.Location = new Point(42, 88);
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
            lblUppercaseLowercase.Location = new Point(42, 48);
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
            lblEightLong.Location = new Point(42, 8);
            lblEightLong.Margin = new Padding(10);
            lblEightLong.Name = "lblEightLong";
            lblEightLong.Size = new Size(165, 19);
            lblEightLong.TabIndex = 19;
            lblEightLong.Text = "Eight characters long";
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
            tbConfirmPassword.Location = new Point(10, 337);
            tbConfirmPassword.Margin = new Padding(5);
            tbConfirmPassword.MaxLength = 256;
            tbConfirmPassword.MultiLine = false;
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PlaceholderText = "newPassword123!";
            tbConfirmPassword.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbConfirmPassword.ReadOnly = false;
            tbConfirmPassword.Size = new Size(330, 40);
            tbConfirmPassword.TabIndex = 2;
            tbConfirmPassword.TextAlign = HorizontalAlignment.Left;
            tbConfirmPassword.TextBoxInset = new Padding(10);
            tbConfirmPassword.UsePasswordChar = true;
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
            tbNewPassword.Location = new Point(10, 76);
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
            lblPasswordError.Location = new Point(10, 386);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(330, 52);
            lblPasswordError.TabIndex = 25;
            lblPasswordError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Anchor = AnchorStyles.Top;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Bahnschrift", 14F);
            lblConfirmPassword.ForeColor = Color.White;
            lblConfirmPassword.Location = new Point(10, 304);
            lblConfirmPassword.Margin = new Padding(5);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(168, 23);
            lblConfirmPassword.TabIndex = 23;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblNewPassword
            // 
            lblNewPassword.Anchor = AnchorStyles.Top;
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Bahnschrift", 14F);
            lblNewPassword.ForeColor = Color.White;
            lblNewPassword.Location = new Point(10, 43);
            lblNewPassword.Margin = new Padding(5);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(138, 23);
            lblNewPassword.TabIndex = 23;
            lblNewPassword.Text = "New Password";
            // 
            // lblChangePassword
            // 
            lblChangePassword.Anchor = AnchorStyles.Top;
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new Font("Bahnschrift", 14F);
            lblChangePassword.ForeColor = Color.White;
            lblChangePassword.Location = new Point(10, 10);
            lblChangePassword.Margin = new Padding(5);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(164, 23);
            lblChangePassword.TabIndex = 18;
            lblChangePassword.Text = "Change Password";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 14F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(64, 14);
            lblUsername.Margin = new Padding(5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 23);
            lblUsername.TabIndex = 22;
            lblUsername.Text = "Username";
            // 
            // cbPrivilegeLevel
            // 
            cbPrivilegeLevel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPrivilegeLevel.FormattingEnabled = true;
            cbPrivilegeLevel.Location = new Point(64, 130);
            cbPrivilegeLevel.MinimumSize = new Size(355, 0);
            cbPrivilegeLevel.Name = "cbPrivilegeLevel";
            cbPrivilegeLevel.Size = new Size(355, 31);
            cbPrivilegeLevel.TabIndex = 24;
            // 
            // ManageStaffCredentialsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(sb);
            Controls.Add(pnlHolder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStaffCredentialsView";
            Text = "ManageUserCredentialsView";
            pnlHolder.ResumeLayout(false);
            pnlHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowNewPassword).EndInit();
            pnlChangePassword.ResumeLayout(false);
            pnlChangePassword.PerformLayout();
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
        private Label lblPrivilegeLevel;
        private CustomControls.CustomButton btnChangePassword;
        private CustomControls.CustomTextBox tbPrivilegeLevel;
        private CustomControls.CustomTextBox tbUsername;
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
        private CustomControls.CustomTextBox tbConfirmPassword;
        private CustomControls.CustomTextBox tbNewPassword;
        private Label lblPasswordError;
        private Label lblConfirmPassword;
        private Label lblNewPassword;
        private Label lblChangePassword;
        private Label lblUsername;
        private ToolTip toolTip;
        private ComboBox cbPrivilegeLevel;
    }
}