namespace a2_coursework.View.Order {
    partial class ManageCleaningJobDurationView {
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
            lblEndTime = new Label();
            lblStartTime = new Label();
            lblDate = new Label();
            dateInput = new a2_coursework.CustomControls.DateInput();
            lblTimeError = new Label();
            pnlTime = new a2_coursework.CustomControls.CustomPanel();
            tiEndTime = new a2_coursework.CustomControls.TimeInput();
            tiStartTime = new a2_coursework.CustomControls.TimeInput();
            lblDateError = new Label();
            pnlTime.SuspendLayout();
            SuspendLayout();
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Bahnschrift", 14F);
            lblEndTime.ForeColor = Color.White;
            lblEndTime.Location = new Point(204, 10);
            lblEndTime.Margin = new Padding(5);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(135, 23);
            lblEndTime.TabIndex = 23;
            lblEndTime.Text = "End Time (24h)";
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Bahnschrift", 14F);
            lblStartTime.ForeColor = Color.White;
            lblStartTime.Location = new Point(17, 10);
            lblStartTime.Margin = new Padding(5);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(145, 23);
            lblStartTime.TabIndex = 21;
            lblStartTime.Text = "Start Time (24h)";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Bahnschrift", 14F);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(145, 44);
            lblDate.Margin = new Padding(5);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(48, 23);
            lblDate.TabIndex = 20;
            lblDate.Text = "Date";
            // 
            // dateInput
            // 
            dateInput.Anchor = AnchorStyles.None;
            dateInput.BorderColor = Color.FromArgb(39, 39, 42);
            dateInput.BorderErrorColor = Color.Red;
            dateInput.BorderThickness = 1F;
            dateInput.Day = null;
            dateInput.DayToolTip = "";
            dateInput.Location = new Point(145, 75);
            dateInput.Margin = new Padding(7);
            dateInput.MaxDate = null;
            dateInput.MaximumSize = new Size(180, 70);
            dateInput.MinDate = null;
            dateInput.MinimumSize = new Size(180, 70);
            dateInput.Month = null;
            dateInput.MonthToolTip = "";
            dateInput.Name = "dateInput";
            dateInput.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            dateInput.ReadOnly = false;
            dateInput.Size = new Size(180, 70);
            dateInput.TabIndex = 25;
            dateInput.ToolTipsActive = true;
            dateInput.Year = null;
            dateInput.YearToolTip = "";
            // 
            // lblTimeError
            // 
            lblTimeError.Anchor = AnchorStyles.None;
            lblTimeError.Font = new Font("Bahnschrift", 12F);
            lblTimeError.ForeColor = Color.FromArgb(168, 171, 174);
            lblTimeError.Location = new Point(145, 298);
            lblTimeError.Name = "lblTimeError";
            lblTimeError.Size = new Size(361, 38);
            lblTimeError.TabIndex = 24;
            lblTimeError.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlTime
            // 
            pnlTime.Anchor = AnchorStyles.None;
            pnlTime.BorderColor = Color.FromArgb(39, 39, 42);
            pnlTime.BorderThickness = 1F;
            pnlTime.Controls.Add(tiEndTime);
            pnlTime.Controls.Add(tiStartTime);
            pnlTime.Controls.Add(lblStartTime);
            pnlTime.Controls.Add(lblEndTime);
            pnlTime.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlTime.Location = new Point(145, 188);
            pnlTime.Margin = new Padding(5);
            pnlTime.Name = "pnlTime";
            pnlTime.Padding = new Padding(10, 5, 10, 5);
            pnlTime.Size = new Size(361, 105);
            pnlTime.TabIndex = 26;
            // 
            // tiEndTime
            // 
            tiEndTime.BackColor = Color.FromArgb(9, 9, 10);
            tiEndTime.BorderColor = Color.FromArgb(39, 39, 42);
            tiEndTime.BorderErrorColor = Color.FromArgb(190, 18, 60);
            tiEndTime.Hour = "00";
            tiEndTime.Location = new Point(222, 50);
            tiEndTime.Margin = new Padding(30, 5, 30, 10);
            tiEndTime.MaximumSize = new Size(99, 40);
            tiEndTime.MinimumSize = new Size(99, 40);
            tiEndTime.Minute = "00";
            tiEndTime.Name = "tiEndTime";
            tiEndTime.PlaceholderColor = Color.Empty;
            tiEndTime.ReadOnly = false;
            tiEndTime.Size = new Size(99, 40);
            tiEndTime.TabIndex = 24;
            tiEndTime.Time = new TimeOnly(0L);
            // 
            // tiStartTime
            // 
            tiStartTime.BackColor = Color.FromArgb(9, 9, 10);
            tiStartTime.BorderColor = Color.FromArgb(39, 39, 42);
            tiStartTime.BorderErrorColor = Color.FromArgb(190, 18, 60);
            tiStartTime.Hour = "00";
            tiStartTime.Location = new Point(40, 50);
            tiStartTime.Margin = new Padding(30, 5, 30, 10);
            tiStartTime.MaximumSize = new Size(99, 40);
            tiStartTime.MinimumSize = new Size(99, 40);
            tiStartTime.Minute = "00";
            tiStartTime.Name = "tiStartTime";
            tiStartTime.PlaceholderColor = Color.Empty;
            tiStartTime.ReadOnly = false;
            tiStartTime.Size = new Size(99, 40);
            tiStartTime.TabIndex = 24;
            tiStartTime.Time = new TimeOnly(0L);
            // 
            // lblDateError
            // 
            lblDateError.Anchor = AnchorStyles.None;
            lblDateError.Font = new Font("Bahnschrift", 12F);
            lblDateError.ForeColor = Color.FromArgb(168, 171, 174);
            lblDateError.Location = new Point(335, 75);
            lblDateError.Name = "lblDateError";
            lblDateError.Size = new Size(171, 70);
            lblDateError.TabIndex = 24;
            lblDateError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageCleaningJobDurationView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(dateInput);
            Controls.Add(lblDateError);
            Controls.Add(lblTimeError);
            Controls.Add(lblDate);
            Controls.Add(pnlTime);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCleaningJobDurationView";
            Text = "Date and Time";
            pnlTime.ResumeLayout(false);
            pnlTime.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEndTime;
        private Label lblStartTime;
        private Label lblDate;
        private CustomControls.DateInput dateInput;
        private Label lblTimeError;
        private CustomControls.CustomPanel pnlTime;
        private CustomControls.TimeInput tiStartTime;
        private CustomControls.TimeInput tiEndTime;
        private Label lblDateError;
    }
}