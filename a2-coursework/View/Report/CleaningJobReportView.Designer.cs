namespace a2_coursework.View.Reports {
    partial class CleaningJobReportView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleaningJobReportView));
            pnl = new a2_coursework.CustomControls.CustomPanel();
            lblID = new Label();
            tbID = new a2_coursework.CustomControls.CustomTextBox();
            btnGenerateReport = new a2_coursework.CustomControls.CustomButton();
            lblError = new Label();
            lblCleaningJobReports = new Label();
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // pnl
            // 
            pnl.Anchor = AnchorStyles.None;
            pnl.BorderColor = Color.FromArgb(39, 39, 42);
            pnl.BorderThickness = 1F;
            pnl.Controls.Add(lblID);
            pnl.Controls.Add(tbID);
            pnl.Controls.Add(btnGenerateReport);
            pnl.Controls.Add(lblError);
            pnl.Controls.Add(lblCleaningJobReports);
            pnl.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnl.Location = new Point(156, 113);
            pnl.Margin = new Padding(20);
            pnl.Name = "pnl";
            pnl.Size = new Size(312, 270);
            pnl.TabIndex = 1;
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.None;
            lblID.AutoSize = true;
            lblID.Font = new Font("Bahnschrift", 14F);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(19, 102);
            lblID.Margin = new Padding(5);
            lblID.Name = "lblID";
            lblID.Size = new Size(156, 23);
            lblID.TabIndex = 24;
            lblID.Text = "Cleaning Job ID : ";
            // 
            // tbID
            // 
            tbID.BackColor = Color.FromArgb(9, 9, 10);
            tbID.BorderColor = Color.FromArgb(39, 39, 42);
            tbID.BorderThickness = 1F;
            tbID.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbID.Font = new Font("Bahnschrift", 12F);
            tbID.ForeColor = Color.Empty;
            tbID.HoverColor = Color.Empty;
            tbID.Location = new Point(185, 93);
            tbID.Margin = new Padding(5);
            tbID.MaximumSize = new Size(355, 79);
            tbID.MaxLength = 256;
            tbID.MultiLine = false;
            tbID.Name = "tbID";
            tbID.PlaceholderText = "";
            tbID.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbID.ReadOnly = false;
            tbID.Size = new Size(108, 40);
            tbID.TabIndex = 24;
            tbID.TextAlign = HorizontalAlignment.Left;
            tbID.TextBoxInset = new Padding(10);
            tbID.UsePasswordChar = false;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = SystemColors.Control;
            btnGenerateReport.BorderColor = Color.Empty;
            btnGenerateReport.BorderThickness = 0F;
            btnGenerateReport.ClickedBorderColor = Color.Empty;
            btnGenerateReport.ClickedColor = Color.FromArgb(226, 226, 226);
            btnGenerateReport.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.DisabledBorderColor = Color.Empty;
            btnGenerateReport.DisabledColor = Color.FromArgb(226, 226, 226);
            btnGenerateReport.Font = new Font("Bahnschrift", 12F);
            btnGenerateReport.ForeColor = Color.FromArgb(9, 9, 10);
            btnGenerateReport.HoverBorderColor = Color.Empty;
            btnGenerateReport.HoverColor = Color.FromArgb(226, 226, 226);
            btnGenerateReport.Image = null;
            btnGenerateReport.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnGenerateReport.Location = new Point(30, 168);
            btnGenerateReport.Margin = new Padding(30, 30, 30, 20);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(252, 36);
            btnGenerateReport.TabIndex = 5;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnGenerateReport.TextPosition = new Point(61, 8);
            // 
            // lblError
            // 
            lblError.AccessibleDescription = "Sign in below to access your account";
            lblError.Font = new Font("Bahnschrift", 12F);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(30, 224);
            lblError.Name = "lblError";
            lblError.Size = new Size(252, 19);
            lblError.TabIndex = 4;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCleaningJobReports
            // 
            lblCleaningJobReports.AccessibleDescription = "Welcome";
            lblCleaningJobReports.AutoSize = true;
            lblCleaningJobReports.Font = new Font("Bahnschrift", 20F);
            lblCleaningJobReports.ForeColor = Color.White;
            lblCleaningJobReports.Location = new Point(19, 10);
            lblCleaningJobReports.Margin = new Padding(10);
            lblCleaningJobReports.Name = "lblCleaningJobReports";
            lblCleaningJobReports.Size = new Size(274, 33);
            lblCleaningJobReports.TabIndex = 1;
            lblCleaningJobReports.Text = "Cleaning Job Reports";
            // 
            // CleaningJobReportView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(638, 500);
            Controls.Add(pnl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 500);
            Name = "CleaningJobReportView";
            Text = "LoginView";
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CustomControls.CustomPanel pnl;
        private Label lblCleaningJobReports;
        private Label lblError;
        private CustomControls.CustomButton btnGenerateReport;
        private CustomControls.CustomTextBox tbID;
        private Label lblID;
    }
}