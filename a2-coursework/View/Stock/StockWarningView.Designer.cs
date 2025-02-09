namespace a2_coursework.View.Stock {
    partial class StockWarningView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockWarningView));
            numericUpDown1 = new CustomControls.CustomNumericUpDown();
            lblName = new Label();
            label2 = new Label();
            customNumericUpDown2 = new CustomControls.CustomNumericUpDown();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            lblStaffLink = new Label();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(9, 9, 10);
            numericUpDown1.Location = new Point(151, 156);
            numericUpDown1.Maximum = 1000000;
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(250, 41);
            numericUpDown1.TabIndex = 22;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 14F);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(151, 125);
            lblName.Margin = new Padding(5, 10, 5, 5);
            lblName.Name = "lblName";
            lblName.Size = new Size(173, 23);
            lblName.TabIndex = 21;
            lblName.Text = "Low Quantity Level";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(148, 210);
            label2.Margin = new Padding(5, 10, 5, 5);
            label2.Name = "label2";
            label2.Size = new Size(176, 23);
            label2.TabIndex = 21;
            label2.Text = "High Quantity Level";
            // 
            // customNumericUpDown2
            // 
            customNumericUpDown2.BackColor = Color.FromArgb(9, 9, 10);
            customNumericUpDown2.Location = new Point(148, 241);
            customNumericUpDown2.Maximum = 1000000;
            customNumericUpDown2.Name = "customNumericUpDown2";
            customNumericUpDown2.Size = new Size(250, 41);
            customNumericUpDown2.TabIndex = 22;
            // 
            // approveChangesBar
            // 
            approveChangesBar.BackColor = Color.FromArgb(9, 9, 10);
            approveChangesBar.Dock = DockStyle.Bottom;
            approveChangesBar.IsLoading = false;
            approveChangesBar.Location = new Point(0, 459);
            approveChangesBar.Name = "approveChangesBar";
            approveChangesBar.Size = new Size(654, 41);
            approveChangesBar.TabIndex = 23;
            approveChangesBar.ToolTipsActive = true;
            // 
            // lblStaffLink
            // 
            lblStaffLink.Anchor = AnchorStyles.Top;
            lblStaffLink.Font = new Font("Bahnschrift", 12F);
            lblStaffLink.ForeColor = Color.FromArgb(168, 171, 174);
            lblStaffLink.Location = new Point(151, 9);
            lblStaffLink.Margin = new Padding(10, 0, 10, 20);
            lblStaffLink.Name = "lblStaffLink";
            lblStaffLink.Size = new Size(391, 98);
            lblStaffLink.TabIndex = 26;
            lblStaffLink.Text = resources.GetString("lblStaffLink.Text");
            // 
            // StockWarningView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(lblStaffLink);
            Controls.Add(approveChangesBar);
            Controls.Add(customNumericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockWarningView";
            Text = "StockWarningView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomNumericUpDown numericUpDown1;
        private Label lblName;
        private Label label2;
        private CustomControls.CustomNumericUpDown customNumericUpDown2;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private Label lblStaffLink;
    }
}