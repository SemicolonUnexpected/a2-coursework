namespace a2_coursework.View.Settings {
    partial class AppearanceSettingsView {
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
            lblAppearance = new Label();
            lblEditPromt = new Label();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            customPanel1 = new CustomControls.CustomPanel();
            label1 = new Label();
            customRadioButton1 = new CustomControls.CustomRadioButton();
            lblEmergencyContactForenameTitle = new Label();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppearance
            // 
            lblAppearance.Anchor = AnchorStyles.None;
            lblAppearance.AutoSize = true;
            lblAppearance.Font = new Font("Bahnschrift", 24F);
            lblAppearance.ForeColor = Color.White;
            lblAppearance.Location = new Point(151, 19);
            lblAppearance.Margin = new Padding(10);
            lblAppearance.Name = "lblAppearance";
            lblAppearance.Size = new Size(188, 39);
            lblAppearance.TabIndex = 8;
            lblAppearance.Text = "Appearance";
            // 
            // lblEditPromt
            // 
            lblEditPromt.Anchor = AnchorStyles.None;
            lblEditPromt.AutoSize = true;
            lblEditPromt.Font = new Font("Bahnschrift", 12F);
            lblEditPromt.ForeColor = Color.FromArgb(168, 171, 174);
            lblEditPromt.Location = new Point(151, 68);
            lblEditPromt.Margin = new Padding(10, 0, 10, 20);
            lblEditPromt.Name = "lblEditPromt";
            lblEditPromt.Size = new Size(274, 19);
            lblEditPromt.TabIndex = 10;
            lblEditPromt.Text = "Edit your appearance settings below";
            // 
            // approveChangesBar
            // 
            approveChangesBar.BackColor = Color.FromArgb(9, 9, 10);
            approveChangesBar.Dock = DockStyle.Bottom;
            approveChangesBar.IsLoading = false;
            approveChangesBar.Location = new Point(0, 459);
            approveChangesBar.Name = "approveChangesBar";
            approveChangesBar.Size = new Size(654, 41);
            approveChangesBar.TabIndex = 15;
            approveChangesBar.Visible = false;
            // 
            // customPanel1
            // 
            customPanel1.BorderColor = Color.FromArgb(39, 39, 42);
            customPanel1.BorderThickness = 1F;
            customPanel1.Controls.Add(label1);
            customPanel1.Controls.Add(customRadioButton1);
            customPanel1.Controls.Add(lblEmergencyContactForenameTitle);
            customPanel1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customPanel1.Location = new Point(151, 121);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(5);
            customPanel1.Size = new Size(339, 87);
            customPanel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.Font = new Font("Bahnschrift", 10F);
            label1.ForeColor = Color.FromArgb(168, 171, 174);
            label1.Location = new Point(10, 43);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(281, 38);
            label1.TabIndex = 17;
            label1.Text = "If enabled, the application will run in dark mode";
            // 
            // customRadioButton1
            // 
            customRadioButton1.Anchor = AnchorStyles.Right;
            customRadioButton1.BorderThickness = 1.7F;
            customRadioButton1.CheckColor = Color.White;
            customRadioButton1.CheckRadius = 0F;
            customRadioButton1.ForeColor = Color.White;
            customRadioButton1.Location = new Point(301, 29);
            customRadioButton1.Name = "customRadioButton1";
            customRadioButton1.Size = new Size(21, 21);
            customRadioButton1.TabIndex = 0;
            customRadioButton1.Text = "customRadioButton1";
            // 
            // lblEmergencyContactForenameTitle
            // 
            lblEmergencyContactForenameTitle.Anchor = AnchorStyles.Left;
            lblEmergencyContactForenameTitle.AutoSize = true;
            lblEmergencyContactForenameTitle.Font = new Font("Bahnschrift", 14F);
            lblEmergencyContactForenameTitle.ForeColor = Color.White;
            lblEmergencyContactForenameTitle.Location = new Point(10, 10);
            lblEmergencyContactForenameTitle.Margin = new Padding(5);
            lblEmergencyContactForenameTitle.Name = "lblEmergencyContactForenameTitle";
            lblEmergencyContactForenameTitle.Size = new Size(100, 23);
            lblEmergencyContactForenameTitle.TabIndex = 18;
            lblEmergencyContactForenameTitle.Text = "Dark Mode";
            // 
            // AppearanceSettingsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(customPanel1);
            Controls.Add(approveChangesBar);
            Controls.Add(lblAppearance);
            Controls.Add(lblEditPromt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppearanceSettingsView";
            Text = "AppearanceSettingsView";
            Load += AppearanceSettingsView_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppearance;
        private Label lblEditPromt;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private CustomControls.CustomPanel customPanel1;
        private CustomControls.CustomRadioButton customRadioButton1;
        private Label label1;
        private Label lblEmergencyContactForenameTitle;
    }
}