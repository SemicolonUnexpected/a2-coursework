namespace a2_coursework.View {
    partial class LoginView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            pnlLeft = new Panel();
            lblError = new Label();
            lblSignIn = new Label();
            btnSwitchTheme = new Custom_Controls.CustomBindingButton();
            pbThemeIcon = new PictureBox();
            lblWelcome = new Label();
            btnSignIn = new Custom_Controls.CustomBindingButton();
            label3 = new Label();
            tbUsername = new AS_Coursework.Custom_Controls.CustomTextbox();
            tbPassword = new AS_Coursework.Custom_Controls.CustomTextbox();
            pbShowPassword = new PictureBox();
            pbBackground = new AS_Coursework.Custom_Controls.PicturePanel();
            pnlLeft.SuspendLayout();
            btnSwitchTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbThemeIcon).BeginInit();
            btnSignIn.SuspendLayout();
            tbPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(17, 24, 39);
            pnlLeft.Controls.Add(lblError);
            pnlLeft.Controls.Add(lblSignIn);
            pnlLeft.Controls.Add(btnSwitchTheme);
            pnlLeft.Controls.Add(lblWelcome);
            pnlLeft.Controls.Add(btnSignIn);
            pnlLeft.Controls.Add(tbUsername);
            pnlLeft.Controls.Add(tbPassword);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(400, 461);
            pnlLeft.TabIndex = 9;
            pnlLeft.Text = "pnlLeft";
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Bahnschrift", 11F);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(50, 283);
            lblError.Name = "lblError";
            lblError.Size = new Size(300, 30);
            lblError.TabIndex = 10;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSignIn
            // 
            lblSignIn.Anchor = AnchorStyles.None;
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignIn.ForeColor = Color.FromArgb(248, 250, 252);
            lblSignIn.Location = new Point(82, 115);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(227, 25);
            lblSignIn.TabIndex = 7;
            lblSignIn.Text = "Sign in to your account";
            // 
            // btnSwitchTheme
            // 
            btnSwitchTheme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSwitchTheme.BackColor = Color.FromArgb(17, 24, 39);
            btnSwitchTheme.BorderClickedColor = Color.Empty;
            btnSwitchTheme.BorderColor = Color.Empty;
            btnSwitchTheme.BorderHoverColor = Color.Empty;
            btnSwitchTheme.BorderWidth = 0F;
            btnSwitchTheme.ClickedColor = Color.Empty;
            btnSwitchTheme.Controls.Add(pbThemeIcon);
            btnSwitchTheme.CornerRadius = 16;
            btnSwitchTheme.HoverColor = Color.FromArgb(31, 41, 55);
            btnSwitchTheme.Location = new Point(362, 12);
            btnSwitchTheme.Name = "btnSwitchTheme";
            btnSwitchTheme.Padding = new Padding(5);
            btnSwitchTheme.Size = new Size(32, 32);
            btnSwitchTheme.TabIndex = 8;
            btnSwitchTheme.Text = "customBindingButton2";
            btnSwitchTheme.Click += btnSwitchTheme_Click;
            // 
            // pbThemeIcon
            // 
            pbThemeIcon.BackgroundImage = Properties.Resources.SunWhite;
            pbThemeIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pbThemeIcon.Location = new Point(6, 6);
            pbThemeIcon.Name = "pbThemeIcon";
            pbThemeIcon.Size = new Size(20, 20);
            pbThemeIcon.TabIndex = 0;
            pbThemeIcon.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.None;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bahnschrift", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(248, 250, 252);
            lblWelcome.Location = new Point(79, 70);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(170, 45);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Welcome";
            // 
            // btnSignIn
            // 
            btnSignIn.Anchor = AnchorStyles.None;
            btnSignIn.BackColor = Color.FromArgb(48, 154, 207);
            btnSignIn.BorderClickedColor = Color.Empty;
            btnSignIn.BorderColor = Color.Empty;
            btnSignIn.BorderHoverColor = Color.Empty;
            btnSignIn.BorderWidth = 0F;
            btnSignIn.ClickedColor = Color.Empty;
            btnSignIn.Controls.Add(label3);
            btnSignIn.CornerRadius = 5;
            btnSignIn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.HoverColor = Color.Empty;
            btnSignIn.Location = new Point(130, 320);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(140, 30);
            btnSignIn.TabIndex = 5;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(248, 250, 252);
            label3.Location = new Point(43, 6);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 0;
            label3.Text = "Sign in";
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.None;
            tbUsername.BackColor = Color.FromArgb(17, 24, 39);
            tbUsername.BorderColor = Color.FromArgb(248, 250, 252);
            tbUsername.BorderFocusColor = Color.FromArgb(248, 250, 252);
            tbUsername.BorderSize = 2;
            tbUsername.CustomBorderStyle = AS_Coursework.Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbUsername.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.ForeColor = Color.FromArgb(248, 250, 252);
            tbUsername.IsMultiline = false;
            tbUsername.Location = new Point(90, 180);
            tbUsername.Margin = new Padding(12);
            tbUsername.Name = "tbUsername";
            tbUsername.Padding = new Padding(7);
            tbUsername.PlaceholderText = "Username";
            tbUsername.PlaceholderTextColor = Color.FromArgb(248, 250, 252);
            tbUsername.ShortcutEnabled = true;
            tbUsername.Size = new Size(220, 34);
            tbUsername.TabIndex = 3;
            tbUsername.UsePasswordChar = false;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.None;
            tbPassword.BackColor = Color.FromArgb(17, 24, 39);
            tbPassword.BorderColor = Color.FromArgb(248, 250, 252);
            tbPassword.BorderFocusColor = Color.FromArgb(248, 250, 252);
            tbPassword.BorderSize = 2;
            tbPassword.Controls.Add(pbShowPassword);
            tbPassword.CustomBorderStyle = AS_Coursework.Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbPassword.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.FromArgb(248, 250, 252);
            tbPassword.IsMultiline = false;
            tbPassword.Location = new Point(90, 240);
            tbPassword.Margin = new Padding(12);
            tbPassword.Name = "tbPassword";
            tbPassword.Padding = new Padding(7, 7, 28, 7);
            tbPassword.PlaceholderText = "Password";
            tbPassword.PlaceholderTextColor = Color.FromArgb(248, 250, 252);
            tbPassword.ShortcutEnabled = true;
            tbPassword.Size = new Size(220, 34);
            tbPassword.TabIndex = 2;
            tbPassword.UsePasswordChar = true;
            tbPassword.TextChanged += tbPassword_TextChanged;
            tbPassword.Enter += tbPassword_Enter;
            // 
            // pbShowPassword
            // 
            pbShowPassword.Anchor = AnchorStyles.None;
            pbShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            pbShowPassword.Image = Properties.Resources.EyeWhite;
            pbShowPassword.Location = new Point(193, 4);
            pbShowPassword.Name = "pbShowPassword";
            pbShowPassword.Size = new Size(25, 25);
            pbShowPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbShowPassword.TabIndex = 6;
            pbShowPassword.TabStop = false;
            pbShowPassword.Click += pbShowPassword_Click;
            // 
            // pbBackground
            // 
            pbBackground.Dock = DockStyle.Fill;
            pbBackground.Image = Properties.Resources.Moving_van_back;
            pbBackground.ImagePortion = new Rectangle(0, 0, 878, 700);
            pbBackground.Location = new Point(400, 0);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(384, 461);
            pbBackground.TabIndex = 1;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 461);
            Controls.Add(pbBackground);
            Controls.Add(pnlLeft);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 500);
            Name = "LoginView";
            Text = "LoginView";
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            btnSwitchTheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbThemeIcon).EndInit();
            btnSignIn.ResumeLayout(false);
            btnSignIn.PerformLayout();
            tbPassword.ResumeLayout(false);
            tbPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private AS_Coursework.Custom_Controls.PicturePanel pbBackground;
        private AS_Coursework.Custom_Controls.CustomTextbox tbUsername;
        private AS_Coursework.Custom_Controls.CustomTextbox tbPassword;
        private Button button1;
        private Label lblWelcome;
        private Custom_Controls.CustomBindingButton btnSignIn;
        private PictureBox pbShowPassword;
        private Label label3;
        private Custom_Controls.CustomBindingButton btnSwitchTheme;
        private Label lblSignIn;
        private Panel pnlLeft;
        private PictureBox pbThemeIcon;
        private Label lblError;
    }
}