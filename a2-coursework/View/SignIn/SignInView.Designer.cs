namespace a2_coursework.View {
    partial class SignInView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInView));
            pnl = new a2_coursework.CustomControls.CustomPanel();
            lblError = new Label();
            pbShowPassword = new PictureBox();
            lblSignIn = new Label();
            lblWelcome = new Label();
            tbPassword = new a2_coursework.CustomControls.CustomTextBox();
            btnSignIn = new a2_coursework.CustomControls.CustomButton();
            tbUsername = new a2_coursework.CustomControls.CustomTextBox();
            pbLogoTitle = new PictureBox();
            tbFocusHolder = new a2_coursework.CustomControls.ImprovedTextBox();
            btnSwitchTheme = new a2_coursework.CustomControls.CustomButton();
            pnlCover = new Panel();
            toolTip = new ToolTip(components);
            pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoTitle).BeginInit();
            SuspendLayout();
            // 
            // pnl
            // 
            pnl.Anchor = AnchorStyles.None;
            pnl.BorderColor = Color.FromArgb(39, 39, 42);
            pnl.BorderThickness = 1F;
            pnl.Controls.Add(lblError);
            pnl.Controls.Add(pbShowPassword);
            pnl.Controls.Add(lblSignIn);
            pnl.Controls.Add(lblWelcome);
            pnl.Controls.Add(tbPassword);
            pnl.Controls.Add(btnSignIn);
            pnl.Controls.Add(tbUsername);
            pnl.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnl.Location = new Point(223, 86);
            pnl.Name = "pnl";
            pnl.Size = new Size(340, 340);
            pnl.TabIndex = 1;
            pnl.Click += ClearFocus;
            // 
            // lblError
            // 
            lblError.Font = new Font("Bahnschrift", 12F);
            lblError.ForeColor = Color.FromArgb(168, 171, 174);
            lblError.Location = new Point(28, 277);
            lblError.Name = "lblError";
            lblError.Size = new Size(282, 46);
            lblError.TabIndex = 4;
            lblError.TextAlign = ContentAlignment.TopCenter;
            lblError.Click += ClearFocus;
            // 
            // pbShowPassword
            // 
            pbShowPassword.Anchor = AnchorStyles.None;
            pbShowPassword.Image = Properties.Resources.eye_crossed_light;
            pbShowPassword.Location = new Point(278, 177);
            pbShowPassword.Name = "pbShowPassword";
            pbShowPassword.Size = new Size(21, 21);
            pbShowPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbShowPassword.TabIndex = 5;
            pbShowPassword.TabStop = false;
            pbShowPassword.Click += pbShowPassword_Click;
            // 
            // lblSignIn
            // 
            lblSignIn.AccessibleDescription = "Sign in below to access your account";
            lblSignIn.Font = new Font("Bahnschrift", 12F);
            lblSignIn.ForeColor = Color.FromArgb(168, 171, 174);
            lblSignIn.Location = new Point(28, 65);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(282, 24);
            lblSignIn.TabIndex = 3;
            lblSignIn.Text = "Sign in below to access your account";
            lblSignIn.Click += ClearFocus;
            // 
            // lblWelcome
            // 
            lblWelcome.AccessibleDescription = "Welcome";
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bahnschrift", 24F);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(25, 26);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(146, 39);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            lblWelcome.Click += ClearFocus;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(9, 9, 10);
            tbPassword.BorderColor = Color.FromArgb(39, 39, 42);
            tbPassword.BorderThickness = 1F;
            tbPassword.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbPassword.Font = new Font("Bahnschrift", 12F);
            tbPassword.ForeColor = Color.Empty;
            tbPassword.HoverColor = Color.Empty;
            tbPassword.Location = new Point(28, 167);
            tbPassword.Margin = new Padding(10);
            tbPassword.MaxLength = 32767;
            tbPassword.MultiLine = false;
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Password";
            tbPassword.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbPassword.ReadOnly = false;
            tbPassword.Size = new Size(282, 40);
            tbPassword.TabIndex = 1;
            tbPassword.TextAlign = HorizontalAlignment.Left;
            tbPassword.TextBoxInset = new Padding(10, 10, 45, 10);
            tbPassword.ToolTipText = "Type in a password";
            tbPassword.UsePasswordChar = true;
            tbPassword.KeyPress += tbPassword_KeyPress;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.Control;
            btnSignIn.BorderColor = Color.Empty;
            btnSignIn.BorderThickness = 0F;
            btnSignIn.ClickedBorderColor = Color.Empty;
            btnSignIn.ClickedColor = Color.FromArgb(226, 226, 226);
            btnSignIn.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.DisabledBorderColor = Color.Empty;
            btnSignIn.DisabledColor = Color.FromArgb(226, 226, 226);
            btnSignIn.Font = new Font("Bahnschrift", 12F);
            btnSignIn.ForeColor = Color.FromArgb(9, 9, 10);
            btnSignIn.HoverBorderColor = Color.Empty;
            btnSignIn.HoverColor = Color.FromArgb(226, 226, 226);
            btnSignIn.Image = null;
            btnSignIn.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnSignIn.Location = new Point(28, 227);
            btnSignIn.Margin = new Padding(10);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(282, 40);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign in";
            btnSignIn.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnSignIn.TextPosition = new Point(112, 10);
            toolTip.SetToolTip(btnSignIn, "Click here to sign in");
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(9, 9, 10);
            tbUsername.BorderColor = Color.FromArgb(39, 39, 42);
            tbUsername.BorderThickness = 1F;
            tbUsername.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbUsername.Font = new Font("Bahnschrift", 12F);
            tbUsername.ForeColor = Color.Empty;
            tbUsername.HoverColor = Color.Empty;
            tbUsername.Location = new Point(28, 107);
            tbUsername.Margin = new Padding(10);
            tbUsername.MaxLength = 256;
            tbUsername.MultiLine = false;
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbUsername.ReadOnly = false;
            tbUsername.Size = new Size(282, 40);
            tbUsername.TabIndex = 0;
            tbUsername.TextAlign = HorizontalAlignment.Left;
            tbUsername.TextBoxInset = new Padding(10);
            tbUsername.ToolTipText = "Type in your username";
            tbUsername.UsePasswordChar = false;
            tbUsername.MouseHover += tbUsername_MouseHover;
            // 
            // pbLogoTitle
            // 
            pbLogoTitle.Anchor = AnchorStyles.None;
            pbLogoTitle.Image = Properties.Resources.Logo_Title_Condensed;
            pbLogoTitle.Location = new Point(255, 22);
            pbLogoTitle.Name = "pbLogoTitle";
            pbLogoTitle.Size = new Size(282, 50);
            pbLogoTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoTitle.TabIndex = 0;
            pbLogoTitle.TabStop = false;
            pbLogoTitle.Click += ClearFocus;
            // 
            // tbFocusHolder
            // 
            tbFocusHolder.Location = new Point(631, 154);
            tbFocusHolder.Name = "tbFocusHolder";
            tbFocusHolder.PlaceholderTextColor = Color.Empty;
            tbFocusHolder.Size = new Size(0, 23);
            tbFocusHolder.TabIndex = 0;
            // 
            // btnSwitchTheme
            // 
            btnSwitchTheme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSwitchTheme.BackColor = SystemColors.Control;
            btnSwitchTheme.BackgroundImageLayout = ImageLayout.Zoom;
            btnSwitchTheme.BorderColor = Color.FromArgb(39, 39, 42);
            btnSwitchTheme.BorderThickness = 1F;
            btnSwitchTheme.ClickedBorderColor = Color.Empty;
            btnSwitchTheme.ClickedColor = Color.FromArgb(9, 9, 10);
            btnSwitchTheme.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(20F, 20F, 20F, 20F);
            btnSwitchTheme.Cursor = Cursors.Hand;
            btnSwitchTheme.DisabledBorderColor = Color.Empty;
            btnSwitchTheme.DisabledColor = Color.Empty;
            btnSwitchTheme.Font = new Font("Bahnschrift", 12F);
            btnSwitchTheme.ForeColor = Color.FromArgb(9, 9, 10);
            btnSwitchTheme.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnSwitchTheme.HoverColor = Color.FromArgb(39, 39, 42);
            btnSwitchTheme.Image = Properties.Resources.brightness;
            btnSwitchTheme.ImageRectangle = new Rectangle(7, 7, 28, 28);
            btnSwitchTheme.Location = new Point(724, 19);
            btnSwitchTheme.Margin = new Padding(10);
            btnSwitchTheme.Name = "btnSwitchTheme";
            btnSwitchTheme.Padding = new Padding(10);
            btnSwitchTheme.Size = new Size(41, 41);
            btnSwitchTheme.TabIndex = 3;
            btnSwitchTheme.Text = null;
            btnSwitchTheme.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnSwitchTheme.TextPosition = new Point(20, 20);
            toolTip.SetToolTip(btnSwitchTheme, "Click here to toggle light and dark mode");
            btnSwitchTheme.MouseClick += btnSwitchTheme_MouseClick;
            // 
            // pnlCover
            // 
            pnlCover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCover.Location = new Point(0, 0);
            pnlCover.Name = "pnlCover";
            pnlCover.Size = new Size(1086, 462);
            pnlCover.TabIndex = 4;
            // 
            // SignInView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(pnlCover);
            Controls.Add(btnSwitchTheme);
            Controls.Add(tbFocusHolder);
            Controls.Add(pnl);
            Controls.Add(pbLogoTitle);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 500);
            Name = "SignInView";
            Text = "LoginView";
            Shown += LoginView_Shown;
            Click += ClearFocus;
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnl;
        private CustomControls.CustomTextBox tbUsername;
        private PictureBox pbLogoTitle;
        private CustomControls.CustomButton btnSignIn;
        private CustomControls.CustomTextBox tbPassword;
        private Label lblError;
        private Label lblSignIn;
        private Label lblWelcome;
        private CustomControls.ImprovedTextBox tbFocusHolder;
        private CustomControls.CustomButton btnSwitchTheme;
        private Panel pnlCover;
        private PictureBox pbShowPassword;
        private ToolTip toolTip;
    }
}