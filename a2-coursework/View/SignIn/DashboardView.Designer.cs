namespace a2_coursework.View {
    partial class DashboardView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardView));
            pbLogoTitle = new PictureBox();
            lblWelcome = new Label();
            pnlLastLogin = new a2_coursework.CustomControls.CustomPanel();
            lblLastLogin = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            pnlLastPasswordChange = new a2_coursework.CustomControls.CustomPanel();
            lblLastPasswordChange = new Label();
            diLastPasswordChange = new a2_coursework.CustomControls.DateInput();
            diLastLogin = new a2_coursework.CustomControls.DateInput();
            lblChangePasswordPrompt = new Label();
            btnChangePassword = new a2_coursework.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)pbLogoTitle).BeginInit();
            pnlLastLogin.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            pnlLastPasswordChange.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogoTitle
            // 
            pbLogoTitle.Anchor = AnchorStyles.None;
            pbLogoTitle.Image = Properties.Resources.Logo_Title_Condensed;
            pbLogoTitle.Location = new Point(251, 22);
            pbLogoTitle.Name = "pbLogoTitle";
            pbLogoTitle.Size = new Size(282, 50);
            pbLogoTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoTitle.TabIndex = 0;
            pbLogoTitle.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AccessibleDescription = "Welcome";
            lblWelcome.Anchor = AnchorStyles.None;
            lblWelcome.Font = new Font("Bahnschrift", 24F);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(19, 85);
            lblWelcome.Margin = new Padding(10);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(746, 39);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Good afternoon, John Doe";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLastLogin
            // 
            pnlLastLogin.Anchor = AnchorStyles.None;
            pnlLastLogin.BorderColor = Color.FromArgb(39, 39, 42);
            pnlLastLogin.BorderThickness = 1F;
            pnlLastLogin.Controls.Add(diLastLogin);
            pnlLastLogin.Controls.Add(lblLastLogin);
            pnlLastLogin.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlLastLogin.Location = new Point(20, 20);
            pnlLastLogin.Margin = new Padding(20);
            pnlLastLogin.Name = "pnlLastLogin";
            pnlLastLogin.Size = new Size(300, 250);
            pnlLastLogin.TabIndex = 1;
            // 
            // lblLastLogin
            // 
            lblLastLogin.AccessibleDescription = "Welcome";
            lblLastLogin.AutoSize = true;
            lblLastLogin.Font = new Font("Bahnschrift", 20F);
            lblLastLogin.ForeColor = Color.White;
            lblLastLogin.Location = new Point(10, 10);
            lblLastLogin.Margin = new Padding(10);
            lblLastLogin.Name = "lblLastLogin";
            lblLastLogin.Size = new Size(134, 33);
            lblLastLogin.TabIndex = 1;
            lblLastLogin.Text = "Last login";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.None;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel.Controls.Add(pnlLastLogin);
            flowLayoutPanel.Controls.Add(pnlLastPasswordChange);
            flowLayoutPanel.Location = new Point(52, 137);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(680, 290);
            flowLayoutPanel.TabIndex = 2;
            flowLayoutPanel.Resize += flowLayoutPanel_Resize;
            // 
            // pnlLastPasswordChange
            // 
            pnlLastPasswordChange.Anchor = AnchorStyles.None;
            pnlLastPasswordChange.BorderColor = Color.FromArgb(39, 39, 42);
            pnlLastPasswordChange.BorderThickness = 1F;
            pnlLastPasswordChange.Controls.Add(btnChangePassword);
            pnlLastPasswordChange.Controls.Add(lblChangePasswordPrompt);
            pnlLastPasswordChange.Controls.Add(diLastPasswordChange);
            pnlLastPasswordChange.Controls.Add(lblLastPasswordChange);
            pnlLastPasswordChange.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlLastPasswordChange.Location = new Point(360, 20);
            pnlLastPasswordChange.Margin = new Padding(20);
            pnlLastPasswordChange.Name = "pnlLastPasswordChange";
            pnlLastPasswordChange.Size = new Size(300, 250);
            pnlLastPasswordChange.TabIndex = 1;
            // 
            // lblLastPasswordChange
            // 
            lblLastPasswordChange.AccessibleDescription = "Welcome";
            lblLastPasswordChange.AutoSize = true;
            lblLastPasswordChange.Font = new Font("Bahnschrift", 20F);
            lblLastPasswordChange.ForeColor = Color.White;
            lblLastPasswordChange.Location = new Point(10, 10);
            lblLastPasswordChange.Margin = new Padding(10);
            lblLastPasswordChange.Name = "lblLastPasswordChange";
            lblLastPasswordChange.Size = new Size(287, 33);
            lblLastPasswordChange.TabIndex = 1;
            lblLastPasswordChange.Text = "Last password change";
            // 
            // diLastPasswordChange
            // 
            diLastPasswordChange.BorderColor = Color.FromArgb(39, 39, 42);
            diLastPasswordChange.BorderErrorColor = Color.Red;
            diLastPasswordChange.BorderThickness = 1F;
            diLastPasswordChange.Day = null;
            diLastPasswordChange.DayToolTip = "";
            diLastPasswordChange.Location = new Point(61, 110);
            diLastPasswordChange.MaxDate = null;
            diLastPasswordChange.MaximumSize = new Size(180, 70);
            diLastPasswordChange.MinDate = null;
            diLastPasswordChange.MinimumSize = new Size(180, 70);
            diLastPasswordChange.Month = null;
            diLastPasswordChange.MonthToolTip = "";
            diLastPasswordChange.Name = "diLastPasswordChange";
            diLastPasswordChange.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            diLastPasswordChange.ReadOnly = true;
            diLastPasswordChange.Size = new Size(180, 70);
            diLastPasswordChange.TabIndex = 2;
            diLastPasswordChange.ToolTipsActive = true;
            diLastPasswordChange.Year = null;
            diLastPasswordChange.YearToolTip = "";
            // 
            // diLastLogin
            // 
            diLastLogin.BorderColor = Color.FromArgb(39, 39, 42);
            diLastLogin.BorderErrorColor = Color.Red;
            diLastLogin.BorderThickness = 1F;
            diLastLogin.Day = null;
            diLastLogin.DayToolTip = "";
            diLastLogin.Location = new Point(57, 110);
            diLastLogin.MaxDate = null;
            diLastLogin.MaximumSize = new Size(180, 70);
            diLastLogin.MinDate = null;
            diLastLogin.MinimumSize = new Size(180, 70);
            diLastLogin.Month = null;
            diLastLogin.MonthToolTip = "";
            diLastLogin.Name = "diLastLogin";
            diLastLogin.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            diLastLogin.ReadOnly = true;
            diLastLogin.Size = new Size(180, 70);
            diLastLogin.TabIndex = 2;
            diLastLogin.ToolTipsActive = true;
            diLastLogin.Year = null;
            diLastLogin.YearToolTip = "";
            // 
            // lblChangePasswordPrompt
            // 
            lblChangePasswordPrompt.AccessibleDescription = "Sign in below to access your account";
            lblChangePasswordPrompt.AutoSize = true;
            lblChangePasswordPrompt.Font = new Font("Bahnschrift", 12F);
            lblChangePasswordPrompt.ForeColor = Color.FromArgb(168, 171, 174);
            lblChangePasswordPrompt.Location = new Point(13, 53);
            lblChangePasswordPrompt.Name = "lblChangePasswordPrompt";
            lblChangePasswordPrompt.Size = new Size(228, 19);
            lblChangePasswordPrompt.TabIndex = 4;
            lblChangePasswordPrompt.Text = "Please change your password";
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = SystemColors.Control;
            btnChangePassword.BorderColor = Color.Empty;
            btnChangePassword.BorderThickness = 0F;
            btnChangePassword.ClickedBorderColor = Color.Empty;
            btnChangePassword.ClickedColor = Color.FromArgb(226, 226, 226);
            btnChangePassword.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.DisabledBorderColor = Color.Empty;
            btnChangePassword.DisabledColor = Color.FromArgb(226, 226, 226);
            btnChangePassword.Font = new Font("Bahnschrift", 12F);
            btnChangePassword.ForeColor = Color.FromArgb(9, 9, 10);
            btnChangePassword.HoverBorderColor = Color.Empty;
            btnChangePassword.HoverColor = Color.FromArgb(226, 226, 226);
            btnChangePassword.Image = null;
            btnChangePassword.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnChangePassword.Location = new Point(30, 200);
            btnChangePassword.Margin = new Padding(30, 30, 30, 20);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(240, 30);
            btnChangePassword.TabIndex = 5;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnChangePassword.TextPosition = new Point(50, 5);
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(flowLayoutPanel);
            Controls.Add(lblWelcome);
            Controls.Add(pbLogoTitle);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 500);
            Name = "DashboardView";
            Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)pbLogoTitle).EndInit();
            pnlLastLogin.ResumeLayout(false);
            pnlLastLogin.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            pnlLastPasswordChange.ResumeLayout(false);
            pnlLastPasswordChange.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbLogoTitle;
        private Label lblWelcome;
        private CustomControls.CustomPanel pnlLastLogin;
        private Label lblLastLogin;
        private FlowLayoutPanel flowLayoutPanel;
        private CustomControls.CustomPanel pnlLastPasswordChange;
        private Label lblLastPasswordChange;
        private CustomControls.DateInput diLastLogin;
        private CustomControls.DateInput diLastPasswordChange;
        private Label lblChangePasswordPrompt;
        private CustomControls.CustomButton btnChangePassword;
    }
}