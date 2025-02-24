namespace a2_coursework.View {
    partial class ManageCleaningJobOptionView {
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
            tbName = new CustomControls.CustomTextBox();
            lblName = new Label();
            tbDescription = new CustomControls.CustomTextBox();
            lblDescription = new Label();
            lblNameError = new Label();
            lblCharacterLimit = new Label();
            nudUnitCost = new NumericUpDown();
            lblUnitCost = new Label();
            pnlUnitCost = new CustomControls.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).BeginInit();
            pnlUnitCost.SuspendLayout();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.None;
            tbName.BackColor = Color.FromArgb(9, 9, 10);
            tbName.BorderColor = Color.FromArgb(39, 39, 42);
            tbName.BorderThickness = 1F;
            tbName.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbName.Font = new Font("Bahnschrift", 12F);
            tbName.ForeColor = Color.Empty;
            tbName.HoverColor = Color.Empty;
            tbName.Location = new Point(148, 47);
            tbName.Margin = new Padding(5);
            tbName.MaxLength = 256;
            tbName.MultiLine = false;
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Clean windows";
            tbName.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbName.ReadOnly = false;
            tbName.Size = new Size(355, 40);
            tbName.TabIndex = 7;
            tbName.TextAlign = HorizontalAlignment.Left;
            tbName.TextBoxInset = new Padding(10);
            tbName.UsePasswordChar = false;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 14F);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(148, 14);
            lblName.Margin = new Padding(5);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 23);
            lblName.TabIndex = 11;
            lblName.Text = "Name";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.None;
            tbDescription.BackColor = Color.FromArgb(9, 9, 10);
            tbDescription.BorderColor = Color.FromArgb(39, 39, 42);
            tbDescription.BorderThickness = 1F;
            tbDescription.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbDescription.Font = new Font("Bahnschrift", 12F);
            tbDescription.ForeColor = Color.Empty;
            tbDescription.HoverColor = Color.Empty;
            tbDescription.Location = new Point(148, 176);
            tbDescription.Margin = new Padding(5);
            tbDescription.MaximumSize = new Size(355, 79);
            tbDescription.MaxLength = 256;
            tbDescription.MultiLine = true;
            tbDescription.Name = "tbDescription";
            tbDescription.PlaceholderText = "Clean windows to make them extra shiny and remove any dirt. Mould will be removed with chemical spray.";
            tbDescription.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbDescription.ReadOnly = false;
            tbDescription.Size = new Size(355, 79);
            tbDescription.TabIndex = 14;
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
            lblDescription.Location = new Point(148, 145);
            lblDescription.Margin = new Padding(5);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(191, 23);
            lblDescription.TabIndex = 15;
            lblDescription.Text = "Description (optional)";
            // 
            // lblNameError
            // 
            lblNameError.Anchor = AnchorStyles.None;
            lblNameError.Font = new Font("Bahnschrift", 12F);
            lblNameError.ForeColor = Color.FromArgb(168, 171, 174);
            lblNameError.Location = new Point(148, 92);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(355, 38);
            lblNameError.TabIndex = 16;
            lblNameError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCharacterLimit
            // 
            lblCharacterLimit.Anchor = AnchorStyles.None;
            lblCharacterLimit.Font = new Font("Bahnschrift", 12F);
            lblCharacterLimit.ForeColor = Color.FromArgb(168, 171, 174);
            lblCharacterLimit.Location = new Point(353, 260);
            lblCharacterLimit.Margin = new Padding(10, 0, 10, 20);
            lblCharacterLimit.Name = "lblCharacterLimit";
            lblCharacterLimit.Size = new Size(150, 24);
            lblCharacterLimit.TabIndex = 10;
            lblCharacterLimit.Text = "0/256";
            lblCharacterLimit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nudUnitCost
            // 
            nudUnitCost.BorderStyle = BorderStyle.FixedSingle;
            nudUnitCost.DecimalPlaces = 2;
            nudUnitCost.Font = new Font("Segoe UI", 12F);
            nudUnitCost.Location = new Point(100, 13);
            nudUnitCost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudUnitCost.Name = "nudUnitCost";
            nudUnitCost.Size = new Size(244, 29);
            nudUnitCost.TabIndex = 17;
            nudUnitCost.TextAlign = HorizontalAlignment.Center;
            // 
            // lblUnitCost
            // 
            lblUnitCost.Anchor = AnchorStyles.None;
            lblUnitCost.AutoSize = true;
            lblUnitCost.Font = new Font("Bahnschrift", 14F);
            lblUnitCost.ForeColor = Color.White;
            lblUnitCost.Location = new Point(5, 13);
            lblUnitCost.Margin = new Padding(5);
            lblUnitCost.Name = "lblUnitCost";
            lblUnitCost.Size = new Size(87, 23);
            lblUnitCost.TabIndex = 11;
            lblUnitCost.Text = "Unit Cost";
            // 
            // pnlUnitCost
            // 
            pnlUnitCost.Anchor = AnchorStyles.None;
            pnlUnitCost.BorderColor = Color.FromArgb(39, 39, 42);
            pnlUnitCost.BorderThickness = 1F;
            pnlUnitCost.Controls.Add(nudUnitCost);
            pnlUnitCost.Controls.Add(lblUnitCost);
            pnlUnitCost.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlUnitCost.Location = new Point(148, 307);
            pnlUnitCost.Name = "pnlUnitCost";
            pnlUnitCost.Size = new Size(355, 49);
            pnlUnitCost.TabIndex = 18;
            // 
            // ManageCleaningJobOptionView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(lblNameError);
            Controls.Add(tbDescription);
            Controls.Add(lblDescription);
            Controls.Add(tbName);
            Controls.Add(lblCharacterLimit);
            Controls.Add(lblName);
            Controls.Add(pnlUnitCost);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCleaningJobOptionView";
            Text = "ContactDetailsSettingsView";
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).EndInit();
            pnlUnitCost.ResumeLayout(false);
            pnlUnitCost.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.CustomTextBox tbName;
        private Label lblName;
        private CustomControls.CustomTextBox tbDescription;
        private Label lblDescription;
        private Label lblNameError;
        private Label lblCharacterLimit;
        private NumericUpDown nudUnitCost;
        private Label lblUnitCost;
        private CustomControls.CustomPanel pnlUnitCost;
    }
}