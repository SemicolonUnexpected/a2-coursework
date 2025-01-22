namespace a2_coursework.View {
    partial class PersonalInfromationSettingsView {
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
            tbUsername = new CustomControls.CustomTextBox();
            lblSettings = new Label();
            pnlHolder = new Panel();
            dateInput1 = new User_Controls.DateInput();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblSignIn = new Label();
            customTextBox5 = new CustomControls.CustomTextBox();
            lblError = new Label();
            pnlHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(9, 9, 10);
            tbUsername.BorderColor = Color.FromArgb(39, 39, 42);
            tbUsername.BorderThickness = 1F;
            tbUsername.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbUsername.Font = new Font("Bahnschrift", 12F);
            tbUsername.ForeColor = Color.Empty;
            tbUsername.HoverColor = Color.Empty;
            tbUsername.Location = new Point(20, 145);
            tbUsername.Margin = new Padding(5);
            tbUsername.MaxLength = 256;
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Forename";
            tbUsername.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbUsername.Size = new Size(388, 40);
            tbUsername.TabIndex = 1;
            tbUsername.TextBoxInset = new Padding(10);
            tbUsername.UsePasswordChar = false;
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Font = new Font("Bahnschrift", 24F);
            lblSettings.ForeColor = Color.White;
            lblSettings.Location = new Point(14, 19);
            lblSettings.Margin = new Padding(10);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(319, 39);
            lblSettings.TabIndex = 2;
            lblSettings.Text = "Personal Information";
            // 
            // pnlHolder
            // 
            pnlHolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pnlHolder.Controls.Add(lblError);
            pnlHolder.Controls.Add(dateInput1);
            pnlHolder.Controls.Add(label3);
            pnlHolder.Controls.Add(label2);
            pnlHolder.Controls.Add(label1);
            pnlHolder.Controls.Add(lblSignIn);
            pnlHolder.Controls.Add(customTextBox5);
            pnlHolder.Controls.Add(tbUsername);
            pnlHolder.Controls.Add(lblSettings);
            pnlHolder.Location = new Point(105, 0);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(428, 500);
            pnlHolder.TabIndex = 3;
            // 
            // dateInput1
            // 
            dateInput1.BackColor = Color.FromArgb(9, 9, 10);
            dateInput1.Location = new Point(7, 340);
            dateInput1.MaximumSize = new Size(200, 100);
            dateInput1.MinimumSize = new Size(200, 100);
            dateInput1.Name = "dateInput1";
            dateInput1.Size = new Size(200, 100);
            dateInput1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 14F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 316);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 7;
            label3.Text = "Date of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 195);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 6;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 112);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 5;
            label1.Text = "Forename";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Bahnschrift", 12F);
            lblSignIn.ForeColor = Color.FromArgb(168, 171, 174);
            lblSignIn.Location = new Point(18, 68);
            lblSignIn.Margin = new Padding(10, 0, 10, 20);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(279, 19);
            lblSignIn.TabIndex = 4;
            lblSignIn.Text = "Edit your personal information below";
            // 
            // customTextBox5
            // 
            customTextBox5.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox5.BorderColor = Color.FromArgb(39, 39, 42);
            customTextBox5.BorderThickness = 1F;
            customTextBox5.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox5.Font = new Font("Bahnschrift", 12F);
            customTextBox5.ForeColor = Color.Empty;
            customTextBox5.HoverColor = Color.Empty;
            customTextBox5.Location = new Point(20, 228);
            customTextBox5.Margin = new Padding(5);
            customTextBox5.MaxLength = 256;
            customTextBox5.Name = "customTextBox5";
            customTextBox5.PlaceholderText = "Surname";
            customTextBox5.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            customTextBox5.Size = new Size(388, 40);
            customTextBox5.TabIndex = 3;
            customTextBox5.TextBoxInset = new Padding(10);
            customTextBox5.UsePasswordChar = false;
            // 
            // lblError
            // 
            lblError.Font = new Font("Bahnschrift", 12F);
            lblError.ForeColor = Color.FromArgb(168, 171, 174);
            lblError.Location = new Point(20, 273);
            lblError.Name = "lblError";
            lblError.Size = new Size(388, 38);
            lblError.TabIndex = 9;
            lblError.TextAlign = ContentAlignment.TopCenter;
            // 
            // PersonalInfromationSettingsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 509);
            Controls.Add(pnlHolder);
            ForeColor = Color.FromArgb(9, 9, 10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalInfromationSettingsView";
            Text = "SettingsView";
            pnlHolder.ResumeLayout(false);
            pnlHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomTextBox tbUsername;
        private Label lblSettings;
        private Panel pnlHolder;
        private CustomControls.CustomTextBox customTextBox5;
        private Label lblSignIn;
        private Label label1;
        private Label label2;
        private Label label3;
        private User_Controls.DateInput dateInput1;
        private Label lblError;
    }
}