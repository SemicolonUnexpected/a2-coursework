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
            pnlLastPasswordChange = new a2_coursework.CustomControls.CustomPanel();
            btnChangePassword = new a2_coursework.CustomControls.CustomButton();
            lblChangePasswordPrompt = new Label();
            diLastPasswordChange = new a2_coursework.CustomControls.DateInput();
            lblLastPasswordChange = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogoTitle).BeginInit();
            pnlLastPasswordChange.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogoTitle
            // 
            pbLogoTitle.Anchor = AnchorStyles.None;
            pbLogoTitle.Image = Properties.Resources.Logo_Title_Condensed;
            pbLogoTitle.Location = new Point(178, 22);
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
            lblWelcome.Size = new Size(600, 39);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Good afternoon, John Doe";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
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
            pnlLastPasswordChange.Location = new Point(163, 162);
            pnlLastPasswordChange.Margin = new Padding(20);
            pnlLastPasswordChange.Name = "pnlLastPasswordChange";
            pnlLastPasswordChange.Size = new Size(312, 270);
            pnlLastPasswordChange.TabIndex = 1;
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
            btnChangePassword.Size = new Size(252, 36);
            btnChangePassword.TabIndex = 5;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnChangePassword.TextPosition = new Point(56, 8);
            // 
            // lblChangePasswordPrompt
            // 
            lblChangePasswordPrompt.AccessibleDescription = "Sign in below to access your account";
            lblChangePasswordPrompt.AutoSize = true;
            lblChangePasswordPrompt.Font = new Font("Bahnschrift", 12F);
            lblChangePasswordPrompt.ForeColor = Color.Red;
            lblChangePasswordPrompt.Location = new Point(39, 53);
            lblChangePasswordPrompt.Name = "lblChangePasswordPrompt";
            lblChangePasswordPrompt.Size = new Size(228, 19);
            lblChangePasswordPrompt.TabIndex = 4;
            lblChangePasswordPrompt.Text = "Please change your password";
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
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(638, 461);
            Controls.Add(pnlLastPasswordChange);
            Controls.Add(lblWelcome);
            Controls.Add(pbLogoTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 500);
            Name = "DashboardView";
            Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)pbLogoTitle).EndInit();
            pnlLastPasswordChange.ResumeLayout(false);
            pnlLastPasswordChange.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbLogoTitle;
        private Label lblWelcome;
        private CustomControls.CustomPanel pnlLastPasswordChange;
        private Label lblLastPasswordChange;
        private CustomControls.DateInput diLastPasswordChange;
        private Label lblChangePasswordPrompt;
        private CustomControls.CustomButton btnChangePassword;
    }
}