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
            tbForename = new CustomControls.CustomTextBox();
            tbSurname = new CustomControls.CustomTextBox();
            lblSurnameTitle = new Label();
            lblEditPromt = new Label();
            lblForenameTitle = new Label();
            customTextBox1 = new CustomControls.CustomTextBox();
            label1 = new Label();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
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
            // tbForename
            // 
            tbForename.Anchor = AnchorStyles.None;
            tbForename.BackColor = Color.FromArgb(9, 9, 10);
            tbForename.BorderColor = Color.FromArgb(39, 39, 42);
            tbForename.BorderThickness = 1F;
            tbForename.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbForename.Font = new Font("Bahnschrift", 12F);
            tbForename.ForeColor = Color.Empty;
            tbForename.HoverColor = Color.Empty;
            tbForename.Location = new Point(153, 252);
            tbForename.Margin = new Padding(5);
            tbForename.MaxLength = 256;
            tbForename.MultiLine = false;
            tbForename.Name = "tbForename";
            tbForename.PlaceholderText = "John";
            tbForename.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbForename.Size = new Size(355, 40);
            tbForename.TabIndex = 7;
            tbForename.TextAlign = HorizontalAlignment.Left;
            tbForename.TextBoxInset = new Padding(10);
            tbForename.UsePasswordChar = false;
            // 
            // tbSurname
            // 
            tbSurname.Anchor = AnchorStyles.None;
            tbSurname.BackColor = Color.FromArgb(9, 9, 10);
            tbSurname.BorderColor = Color.FromArgb(39, 39, 42);
            tbSurname.BorderThickness = 1F;
            tbSurname.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbSurname.Font = new Font("Bahnschrift", 12F);
            tbSurname.ForeColor = Color.Empty;
            tbSurname.HoverColor = Color.Empty;
            tbSurname.Location = new Point(153, 335);
            tbSurname.Margin = new Padding(5);
            tbSurname.MaxLength = 256;
            tbSurname.MultiLine = false;
            tbSurname.Name = "tbSurname";
            tbSurname.PlaceholderText = "Doe";
            tbSurname.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSurname.Size = new Size(355, 40);
            tbSurname.TabIndex = 9;
            tbSurname.TextAlign = HorizontalAlignment.Left;
            tbSurname.TextBoxInset = new Padding(10);
            tbSurname.UsePasswordChar = false;
            // 
            // lblSurnameTitle
            // 
            lblSurnameTitle.Anchor = AnchorStyles.None;
            lblSurnameTitle.AutoSize = true;
            lblSurnameTitle.Font = new Font("Bahnschrift", 14F);
            lblSurnameTitle.ForeColor = Color.White;
            lblSurnameTitle.Location = new Point(151, 302);
            lblSurnameTitle.Margin = new Padding(5);
            lblSurnameTitle.Name = "lblSurnameTitle";
            lblSurnameTitle.Size = new Size(88, 23);
            lblSurnameTitle.TabIndex = 12;
            lblSurnameTitle.Text = "Surname";
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
            // lblForenameTitle
            // 
            lblForenameTitle.Anchor = AnchorStyles.None;
            lblForenameTitle.AutoSize = true;
            lblForenameTitle.Font = new Font("Bahnschrift", 14F);
            lblForenameTitle.ForeColor = Color.White;
            lblForenameTitle.Location = new Point(151, 219);
            lblForenameTitle.Margin = new Padding(5);
            lblForenameTitle.Name = "lblForenameTitle";
            lblForenameTitle.Size = new Size(96, 23);
            lblForenameTitle.TabIndex = 11;
            lblForenameTitle.Text = "Forename";
            // 
            // customTextBox1
            // 
            customTextBox1.Anchor = AnchorStyles.None;
            customTextBox1.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox1.BorderColor = Color.FromArgb(39, 39, 42);
            customTextBox1.BorderThickness = 1F;
            customTextBox1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox1.Font = new Font("Bahnschrift", 12F);
            customTextBox1.ForeColor = Color.Empty;
            customTextBox1.HoverColor = Color.Empty;
            customTextBox1.Location = new Point(150, 247);
            customTextBox1.Margin = new Padding(5);
            customTextBox1.MaxLength = 256;
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "+441234567890";
            customTextBox1.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            customTextBox1.Size = new Size(355, 40);
            customTextBox1.TabIndex = 13;
            customTextBox1.TextAlign = HorizontalAlignment.Left;
            customTextBox1.TextBoxInset = new Padding(10);
            customTextBox1.UsePasswordChar = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(150, 214);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 14;
            label1.Text = "Phone Number";
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
            // AppearanceSettingsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(approveChangesBar);
            Controls.Add(customTextBox1);
            Controls.Add(label1);
            Controls.Add(lblAppearance);
            Controls.Add(tbForename);
            Controls.Add(tbSurname);
            Controls.Add(lblSurnameTitle);
            Controls.Add(lblEditPromt);
            Controls.Add(lblForenameTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppearanceSettingsView";
            Text = "AppearanceSettingsView";
            Load += AppearanceSettingsView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppearance;
        private CustomControls.CustomTextBox tbForename;
        private CustomControls.CustomTextBox tbSurname;
        private Label lblSurnameTitle;
        private Label lblEditPromt;
        private Label lblForenameTitle;
        private CustomControls.CustomTextBox customTextBox1;
        private Label label1;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
    }
}