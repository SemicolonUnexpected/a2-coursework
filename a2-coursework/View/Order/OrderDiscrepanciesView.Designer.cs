namespace a2_coursework.View.Order {
    partial class ManageOrderDiscrepanciesView {
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
            tbDescription = new a2_coursework.CustomControls.CustomTextBox();
            lblDescription = new Label();
            lblCharacterLimit = new Label();
            SuspendLayout();
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.None;
            tbDescription.BackColor = Color.FromArgb(9, 9, 10);
            tbDescription.BorderColor = Color.FromArgb(39, 39, 42);
            tbDescription.BorderThickness = 1F;
            tbDescription.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbDescription.Font = new Font("Bahnschrift", 12F);
            tbDescription.ForeColor = Color.Empty;
            tbDescription.HoverColor = Color.Empty;
            tbDescription.Location = new Point(145, 92);
            tbDescription.Margin = new Padding(5);
            tbDescription.MaximumSize = new Size(355, 166);
            tbDescription.MaxLength = 500;
            tbDescription.MultiLine = true;
            tbDescription.Name = "tbDescription";
            tbDescription.PlaceholderText = "";
            tbDescription.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbDescription.ReadOnly = false;
            tbDescription.Size = new Size(355, 166);
            tbDescription.TabIndex = 22;
            tbDescription.TextAlign = HorizontalAlignment.Left;
            tbDescription.TextBoxInset = new Padding(10);
            tbDescription.UsePasswordChar = false;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Bahnschrift", 14F);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(145, 61);
            lblDescription.Margin = new Padding(5);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(214, 23);
            lblDescription.TabIndex = 23;
            lblDescription.Text = "Discrepancies (optional)";
            // 
            // lblCharacterLimit
            // 
            lblCharacterLimit.Anchor = AnchorStyles.None;
            lblCharacterLimit.Font = new Font("Bahnschrift", 12F);
            lblCharacterLimit.ForeColor = Color.FromArgb(168, 171, 174);
            lblCharacterLimit.Location = new Point(350, 263);
            lblCharacterLimit.Margin = new Padding(10, 0, 10, 20);
            lblCharacterLimit.Name = "lblCharacterLimit";
            lblCharacterLimit.Size = new Size(150, 24);
            lblCharacterLimit.TabIndex = 19;
            lblCharacterLimit.Text = "0/500";
            lblCharacterLimit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ManageOrderDiscrepanciesView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(tbDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblCharacterLimit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrderDiscrepanciesView";
            Text = "Contact Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.CustomTextBox tbDescription;
        private Label lblDescription;
        private Label lblCharacterLimit;
    }
}