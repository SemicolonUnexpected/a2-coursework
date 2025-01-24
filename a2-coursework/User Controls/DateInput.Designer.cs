namespace a2_coursework.User_Controls {
    partial class DateInput {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            tbDay = new CustomControls.CustomTextBox();
            tbMonth = new CustomControls.CustomTextBox();
            tbYear = new CustomControls.CustomTextBox();
            lblDay = new Label();
            lblMonth = new Label();
            lblYear = new Label();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // tbDay
            // 
            tbDay.BackColor = Color.FromArgb(9, 9, 10);
            tbDay.BorderColor = Color.FromArgb(39, 39, 42);
            tbDay.BorderThickness = 1F;
            tbDay.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbDay.Font = new Font("Bahnschrift", 12F);
            tbDay.ForeColor = Color.FromArgb(250, 250, 250);
            tbDay.HoverColor = Color.Empty;
            tbDay.Location = new Point(13, 41);
            tbDay.Margin = new Padding(10);
            tbDay.MaxLength = 2;
            tbDay.Name = "tbDay";
            tbDay.PlaceholderText = "23";
            tbDay.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbDay.Size = new Size(40, 40);
            tbDay.TabIndex = 0;
            tbDay.TextBoxInset = new Padding(13, 10, 10, 10);
            tbDay.UsePasswordChar = false;
            tbDay.TextChanged += tbDay_TextChanged;
            tbDay.KeyPress += tbDay_KeyPress;
            tbDay.Leave += tbDay_Leave;
            // 
            // tbMonth
            // 
            tbMonth.BackColor = Color.FromArgb(9, 9, 10);
            tbMonth.BorderColor = Color.FromArgb(39, 39, 42);
            tbMonth.BorderThickness = 1F;
            tbMonth.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbMonth.Font = new Font("Bahnschrift", 12F);
            tbMonth.ForeColor = Color.FromArgb(250, 250, 250);
            tbMonth.HoverColor = Color.Empty;
            tbMonth.Location = new Point(73, 41);
            tbMonth.Margin = new Padding(10);
            tbMonth.MaxLength = 2;
            tbMonth.Name = "tbMonth";
            tbMonth.PlaceholderText = "06";
            tbMonth.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbMonth.Size = new Size(40, 40);
            tbMonth.TabIndex = 1;
            tbMonth.TextBoxInset = new Padding(12, 10, 10, 10);
            tbMonth.UsePasswordChar = false;
            tbMonth.TextChanged += tbMonth_TextChanged;
            tbMonth.KeyPress += tbMonth_KeyPress;
            tbMonth.Leave += tbMonth_Leave;
            // 
            // tbYear
            // 
            tbYear.BackColor = Color.FromArgb(9, 9, 10);
            tbYear.BorderColor = Color.FromArgb(39, 39, 42);
            tbYear.BorderThickness = 1F;
            tbYear.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbYear.Font = new Font("Bahnschrift", 12F);
            tbYear.ForeColor = Color.FromArgb(250, 250, 250);
            tbYear.HoverColor = Color.Empty;
            tbYear.Location = new Point(133, 41);
            tbYear.Margin = new Padding(10);
            tbYear.MaxLength = 4;
            tbYear.Name = "tbYear";
            tbYear.PlaceholderText = "1986";
            tbYear.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbYear.Size = new Size(60, 40);
            tbYear.TabIndex = 2;
            tbYear.TextBoxInset = new Padding(13, 10, 10, 10);
            tbYear.UsePasswordChar = false;
            tbYear.TextChanged += tbYear_TextChanged;
            tbYear.KeyPress += tbYear_KeyPress;
            tbYear.Leave += tbYear_Leave;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Bahnschrift", 12F);
            lblDay.ForeColor = Color.FromArgb(168, 171, 174);
            lblDay.Location = new Point(16, 13);
            lblDay.Margin = new Padding(10, 0, 10, 20);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(37, 19);
            lblDay.TabIndex = 5;
            lblDay.Text = "Day";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Bahnschrift", 12F);
            lblMonth.ForeColor = Color.FromArgb(168, 171, 174);
            lblMonth.Location = new Point(66, 13);
            lblMonth.Margin = new Padding(10, 0, 10, 20);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(53, 19);
            lblMonth.TabIndex = 6;
            lblMonth.Text = "Month";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Bahnschrift", 12F);
            lblYear.ForeColor = Color.FromArgb(168, 171, 174);
            lblYear.Location = new Point(137, 13);
            lblYear.Margin = new Padding(10, 0, 10, 20);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(41, 19);
            lblYear.TabIndex = 7;
            lblYear.Text = "Year";
            // 
            // DateInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(lblYear);
            Controls.Add(lblMonth);
            Controls.Add(lblDay);
            Controls.Add(tbYear);
            Controls.Add(tbMonth);
            Controls.Add(tbDay);
            MaximumSize = new Size(220, 100);
            MinimumSize = new Size(200, 100);
            Name = "DateInput";
            Size = new Size(220, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomTextBox tbDay;
        private CustomControls.CustomTextBox tbMonth;
        private CustomControls.CustomTextBox tbYear;
        private Label lblDay;
        private Label lblMonth;
        private Label lblYear;
        private ToolTip toolTip;
    }
}
