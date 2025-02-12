namespace a2_coursework.View.Stock {
    partial class ManageStockWarningView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStockWarningView));
            nudLowQuantity = new CustomControls.CustomNumericUpDown();
            lblLowQuantity = new Label();
            lblHighQuantity = new Label();
            nudHighQuantity = new CustomControls.CustomNumericUpDown();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // nudLowQuantity
            // 
            nudLowQuantity.Anchor = AnchorStyles.None;
            nudLowQuantity.BackColor = Color.FromArgb(9, 9, 10);
            nudLowQuantity.Location = new Point(202, 156);
            nudLowQuantity.Maximum = 1000000;
            nudLowQuantity.Name = "nudLowQuantity";
            nudLowQuantity.Size = new Size(250, 41);
            nudLowQuantity.TabIndex = 22;
            // 
            // lblLowQuantity
            // 
            lblLowQuantity.Anchor = AnchorStyles.None;
            lblLowQuantity.AutoSize = true;
            lblLowQuantity.Font = new Font("Bahnschrift", 14F);
            lblLowQuantity.ForeColor = Color.White;
            lblLowQuantity.Location = new Point(202, 125);
            lblLowQuantity.Margin = new Padding(5, 10, 5, 5);
            lblLowQuantity.Name = "lblLowQuantity";
            lblLowQuantity.Size = new Size(173, 23);
            lblLowQuantity.TabIndex = 21;
            lblLowQuantity.Text = "Low Quantity Level";
            // 
            // lblHighQuantity
            // 
            lblHighQuantity.Anchor = AnchorStyles.None;
            lblHighQuantity.AutoSize = true;
            lblHighQuantity.Font = new Font("Bahnschrift", 14F);
            lblHighQuantity.ForeColor = Color.White;
            lblHighQuantity.Location = new Point(202, 210);
            lblHighQuantity.Margin = new Padding(5, 10, 5, 5);
            lblHighQuantity.Name = "lblHighQuantity";
            lblHighQuantity.Size = new Size(176, 23);
            lblHighQuantity.TabIndex = 21;
            lblHighQuantity.Text = "High Quantity Level";
            // 
            // nudHighQuantity
            // 
            nudHighQuantity.Anchor = AnchorStyles.None;
            nudHighQuantity.BackColor = Color.FromArgb(9, 9, 10);
            nudHighQuantity.Location = new Point(202, 241);
            nudHighQuantity.Maximum = 1000000;
            nudHighQuantity.Name = "nudHighQuantity";
            nudHighQuantity.Size = new Size(250, 41);
            nudHighQuantity.TabIndex = 22;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.Font = new Font("Bahnschrift", 12F);
            lblInfo.ForeColor = Color.FromArgb(168, 171, 174);
            lblInfo.Location = new Point(132, 9);
            lblInfo.Margin = new Padding(10, 0, 10, 20);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(391, 98);
            lblInfo.TabIndex = 26;
            lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // ManageStockWarningView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 420);
            Controls.Add(lblInfo);
            Controls.Add(nudHighQuantity);
            Controls.Add(nudLowQuantity);
            Controls.Add(lblHighQuantity);
            Controls.Add(lblLowQuantity);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStockWarningView";
            Text = "StockWarningView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomNumericUpDown nudLowQuantity;
        private Label lblLowQuantity;
        private Label lblHighQuantity;
        private CustomControls.CustomNumericUpDown nudHighQuantity;
        private Label lblInfo;
    }
}