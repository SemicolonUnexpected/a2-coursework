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
            pnlLeft = new Panel();
            lblSignIn = new Label();
            btnSwitchTheme = new Custom_Controls.CustomBindingButton();
            pictureBox1 = new PictureBox();
            lblWelcome = new Label();
            btnSignIn = new Custom_Controls.CustomBindingButton();
            label3 = new Label();
            tbUsername = new AS_Coursework.Custom_Controls.CustomTextbox();
            tbPassword = new AS_Coursework.Custom_Controls.CustomTextbox();
            pbShowPassword = new PictureBox();
            pbBackground = new AS_Coursework.Custom_Controls.PicturePanel();
            pnlLeft.SuspendLayout();
            btnSwitchTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            btnSignIn.SuspendLayout();
            tbPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(17, 24, 39);
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
            btnSwitchTheme.Anchor = AnchorStyles.None;
            btnSwitchTheme.BackColor = Color.FromArgb(17, 24, 39);
            btnSwitchTheme.BorderClickedColor = Color.Empty;
            btnSwitchTheme.BorderColor = Color.Empty;
            btnSwitchTheme.BorderHoverColor = Color.Empty;
            btnSwitchTheme.BorderWidth = 0F;
            btnSwitchTheme.ClickedColor = Color.Empty;
            btnSwitchTheme.Controls.Add(pictureBox1);
            btnSwitchTheme.CornerRadius = 16;
            btnSwitchTheme.HoverColor = Color.FromArgb(224, 224, 224);
            btnSwitchTheme.Location = new Point(362, 12);
            btnSwitchTheme.Name = "btnSwitchTheme";
            btnSwitchTheme.Padding = new Padding(5);
            btnSwitchTheme.Size = new Size(32, 32);
            btnSwitchTheme.TabIndex = 8;
            btnSwitchTheme.Text = "customBindingButton2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SunWhite;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
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
            // 
            // tbPassword
            // 
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
            // 
            // pbShowPassword
            // 
            pbShowPassword.Anchor = AnchorStyles.None;
            pbShowPassword.BackgroundImage = Properties.Resources.EyeWhite;
            pbShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            pbShowPassword.Image = Properties.Resources.EyeWhite;
            pbShowPassword.Location = new Point(193, 4);
            pbShowPassword.Name = "pbShowPassword";
            pbShowPassword.Size = new Size(25, 25);
            pbShowPassword.TabIndex = 6;
            pbShowPassword.TabStop = false;
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
            MinimumSize = new Size(600, 500);
            Name = "LoginView";
            Text = "LoginView";
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            btnSwitchTheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}