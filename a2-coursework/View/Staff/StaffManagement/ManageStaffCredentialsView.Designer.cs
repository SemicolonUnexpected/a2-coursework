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
            cbPrivilegeLevel = new ComboBox();
            lblPrivilegeLevel = new Label();
            tbUsername = new CustomControls.CustomTextBox();
            lblUsernameError = new Label();
            lblUsername = new Label();
            lblSuggestedUsername = new Label();
            SuspendLayout();
            // 
            // cbPrivilegeLevel
            // 
            cbPrivilegeLevel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPrivilegeLevel.FormattingEnabled = true;
            cbPrivilegeLevel.Location = new Point(156, 191);
            cbPrivilegeLevel.MinimumSize = new Size(355, 0);
            cbPrivilegeLevel.Name = "cbPrivilegeLevel";
            cbPrivilegeLevel.Size = new Size(355, 31);
            cbPrivilegeLevel.TabIndex = 24;
            // 
            // lblPrivilegeLevel
            // 
            lblPrivilegeLevel.Anchor = AnchorStyles.Top;
            lblPrivilegeLevel.AutoSize = true;
            lblPrivilegeLevel.Font = new Font("Bahnschrift", 14F);
            lblPrivilegeLevel.ForeColor = Color.White;
            lblPrivilegeLevel.Location = new Point(156, 160);
            lblPrivilegeLevel.Margin = new Padding(5);
            lblPrivilegeLevel.Name = "lblPrivilegeLevel";
            lblPrivilegeLevel.Size = new Size(138, 23);
            lblPrivilegeLevel.TabIndex = 23;
            lblPrivilegeLevel.Text = "Privilege Level";
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
            tbUsername.Location = new Point(156, 70);
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
            // lblUsernameError
            // 
            lblUsernameError.Anchor = AnchorStyles.Top;
            lblUsernameError.Font = new Font("Bahnschrift", 12F);
            lblUsernameError.ForeColor = Color.FromArgb(168, 171, 174);
            lblUsernameError.Location = new Point(156, 115);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(355, 40);
            lblUsernameError.TabIndex = 25;
            lblUsernameError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 14F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(156, 14);
            lblUsername.Margin = new Padding(5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 23);
            lblUsername.TabIndex = 22;
            lblUsername.Text = "Username";
            // 
            // lblSuggestedUsername
            // 
            lblSuggestedUsername.Anchor = AnchorStyles.None;
            lblSuggestedUsername.AutoSize = true;
            lblSuggestedUsername.Font = new Font("Bahnschrift", 12F);
            lblSuggestedUsername.ForeColor = Color.FromArgb(168, 171, 174);
            lblSuggestedUsername.Location = new Point(156, 42);
            lblSuggestedUsername.Margin = new Padding(10, 0, 10, 20);
            lblSuggestedUsername.Name = "lblSuggestedUsername";
            lblSuggestedUsername.Size = new Size(274, 19);
            lblSuggestedUsername.TabIndex = 26;
            lblSuggestedUsername.Text = "Edit your appearance settings below";
            // 
            // ManageStaffCredentialsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(lblSuggestedUsername);
            Controls.Add(cbPrivilegeLevel);
            Controls.Add(lblPrivilegeLevel);
            Controls.Add(tbUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblUsernameError);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStaffCredentialsView";
            Text = "ManageUserCredentialsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPrivilegeLevel;
        private CustomControls.CustomTextBox tbUsername;
        private Label lblUsernameError;
        private Label lblUsername;
        private ComboBox cbPrivilegeLevel;
        private Label lblSuggestedUsername;
    }
}