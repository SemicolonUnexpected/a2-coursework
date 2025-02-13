namespace a2_coursework.View.Users.Settings {
    partial class LoginAttemptsView {
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
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            lblSecurity = new Label();
            lblEditPromt = new Label();
            lblEightLong = new Label();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.ForeColor = Color.FromArgb(9, 9, 10);
            cartesianChart1.Location = new Point(12, 110);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(381, 187);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // lblSecurity
            // 
            lblSecurity.Anchor = AnchorStyles.Top;
            lblSecurity.AutoSize = true;
            lblSecurity.Font = new Font("Bahnschrift", 24F);
            lblSecurity.ForeColor = Color.White;
            lblSecurity.Location = new Point(295, 19);
            lblSecurity.Margin = new Padding(10);
            lblSecurity.Name = "lblSecurity";
            lblSecurity.Size = new Size(135, 39);
            lblSecurity.TabIndex = 20;
            lblSecurity.Text = "Security";
            // 
            // lblEditPromt
            // 
            lblEditPromt.Anchor = AnchorStyles.Top;
            lblEditPromt.AutoSize = true;
            lblEditPromt.Font = new Font("Bahnschrift", 12F);
            lblEditPromt.ForeColor = Color.FromArgb(168, 171, 174);
            lblEditPromt.Location = new Point(295, 68);
            lblEditPromt.Margin = new Padding(10, 0, 10, 20);
            lblEditPromt.Name = "lblEditPromt";
            lblEditPromt.Size = new Size(245, 19);
            lblEditPromt.TabIndex = 21;
            lblEditPromt.Text = "Edit your security settings below";
            // 
            // lblEightLong
            // 
            lblEightLong.Anchor = AnchorStyles.Top;
            lblEightLong.AutoSize = true;
            lblEightLong.Font = new Font("Bahnschrift", 12F);
            lblEightLong.ForeColor = Color.FromArgb(168, 171, 174);
            lblEightLong.Location = new Point(275, 354);
            lblEightLong.Margin = new Padding(10);
            lblEightLong.Name = "lblEightLong";
            lblEightLong.Size = new Size(165, 19);
            lblEightLong.TabIndex = 22;
            lblEightLong.Text = "Eight characters long";
            // 
            // LoginAttemptsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(800, 450);
            Controls.Add(lblSecurity);
            Controls.Add(lblEditPromt);
            Controls.Add(lblEightLong);
            Controls.Add(cartesianChart1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginAttemptsView";
            Text = "LoginAttemptsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private Label lblSecurity;
        private Label lblEditPromt;
        private Label lblEightLong;
    }
}