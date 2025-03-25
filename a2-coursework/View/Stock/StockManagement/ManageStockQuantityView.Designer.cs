namespace a2_coursework.View.Stock {
    partial class ManageStockQuantityView {
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
            lblQuantity = new Label();
            lblBulkAdd = new Label();
            lblBulkRemove = new Label();
            lblReasonForChange = new Label();
            lblStaffLink = new Label();
            nudQuantity = new a2_coursework.CustomControls.CustomNumericUpDown();
            nudBulkAdd = new a2_coursework.CustomControls.CustomNumericUpDown();
            nudBulkRemove = new a2_coursework.CustomControls.CustomNumericUpDown();
            btnRemove = new a2_coursework.CustomControls.CustomButton();
            btnAdd = new a2_coursework.CustomControls.CustomButton();
            tbReasonForQuantityChange = new a2_coursework.CustomControls.CustomTextBox();
            lblCharacterLimit = new Label();
            tbFocusHolder = new TextBox();
            SuspendLayout();
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.None;
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Bahnschrift", 14F);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(135, 3);
            lblQuantity.Margin = new Padding(5);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(151, 23);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Current Quantity";
            lblQuantity.Click += ClearFocusOnClick;
            // 
            // lblBulkAdd
            // 
            lblBulkAdd.Anchor = AnchorStyles.None;
            lblBulkAdd.AutoSize = true;
            lblBulkAdd.Font = new Font("Bahnschrift", 14F);
            lblBulkAdd.ForeColor = Color.White;
            lblBulkAdd.Location = new Point(135, 83);
            lblBulkAdd.Margin = new Padding(5);
            lblBulkAdd.Name = "lblBulkAdd";
            lblBulkAdd.Size = new Size(42, 23);
            lblBulkAdd.TabIndex = 12;
            lblBulkAdd.Text = "Add";
            lblBulkAdd.Click += ClearFocusOnClick;
            // 
            // lblBulkRemove
            // 
            lblBulkRemove.Anchor = AnchorStyles.None;
            lblBulkRemove.AutoSize = true;
            lblBulkRemove.Font = new Font("Bahnschrift", 14F);
            lblBulkRemove.ForeColor = Color.White;
            lblBulkRemove.Location = new Point(135, 166);
            lblBulkRemove.Margin = new Padding(5);
            lblBulkRemove.Name = "lblBulkRemove";
            lblBulkRemove.Size = new Size(78, 23);
            lblBulkRemove.TabIndex = 12;
            lblBulkRemove.Text = "Remove";
            lblBulkRemove.Click += ClearFocusOnClick;
            // 
            // lblReasonForChange
            // 
            lblReasonForChange.Anchor = AnchorStyles.None;
            lblReasonForChange.AutoSize = true;
            lblReasonForChange.Font = new Font("Bahnschrift", 14F);
            lblReasonForChange.ForeColor = Color.White;
            lblReasonForChange.Location = new Point(135, 249);
            lblReasonForChange.Margin = new Padding(5);
            lblReasonForChange.Name = "lblReasonForChange";
            lblReasonForChange.Size = new Size(331, 23);
            lblReasonForChange.TabIndex = 23;
            lblReasonForChange.Text = "Reason for Quantity Change (optional)";
            lblReasonForChange.Click += ClearFocusOnClick;
            // 
            // lblStaffLink
            // 
            lblStaffLink.Anchor = AnchorStyles.None;
            lblStaffLink.AutoSize = true;
            lblStaffLink.Font = new Font("Bahnschrift", 12F);
            lblStaffLink.ForeColor = Color.FromArgb(168, 171, 174);
            lblStaffLink.Location = new Point(135, 277);
            lblStaffLink.Margin = new Padding(10, 0, 10, 20);
            lblStaffLink.Name = "lblStaffLink";
            lblStaffLink.Size = new Size(366, 19);
            lblStaffLink.TabIndex = 25;
            lblStaffLink.Text = "Your staff account is linked to this quantity update";
            lblStaffLink.Click += ClearFocusOnClick;
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.None;
            nudQuantity.BackColor = Color.FromArgb(9, 9, 10);
            nudQuantity.Location = new Point(135, 34);
            nudQuantity.Maximum = 999999999;
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(267, 41);
            nudQuantity.TabIndex = 1;
            // 
            // nudBulkAdd
            // 
            nudBulkAdd.Anchor = AnchorStyles.None;
            nudBulkAdd.BackColor = Color.FromArgb(9, 9, 10);
            nudBulkAdd.Location = new Point(135, 114);
            nudBulkAdd.Maximum = 999999999;
            nudBulkAdd.Name = "nudBulkAdd";
            nudBulkAdd.Size = new Size(267, 41);
            nudBulkAdd.TabIndex = 2;
            // 
            // nudBulkRemove
            // 
            nudBulkRemove.Anchor = AnchorStyles.None;
            nudBulkRemove.BackColor = Color.FromArgb(9, 9, 10);
            nudBulkRemove.Location = new Point(135, 197);
            nudBulkRemove.Maximum = 999999999;
            nudBulkRemove.Name = "nudBulkRemove";
            nudBulkRemove.Size = new Size(267, 41);
            nudBulkRemove.TabIndex = 4;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.BackColor = SystemColors.Control;
            btnRemove.BorderColor = Color.Empty;
            btnRemove.BorderThickness = 0F;
            btnRemove.ClickedBorderColor = Color.Empty;
            btnRemove.ClickedColor = Color.FromArgb(226, 226, 226);
            btnRemove.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.DisabledBorderColor = Color.Empty;
            btnRemove.DisabledColor = Color.FromArgb(226, 226, 226);
            btnRemove.Font = new Font("Bahnschrift", 12F);
            btnRemove.ForeColor = Color.FromArgb(9, 9, 10);
            btnRemove.HoverBorderColor = Color.Empty;
            btnRemove.HoverColor = Color.FromArgb(226, 226, 226);
            btnRemove.Image = null;
            btnRemove.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnRemove.Location = new Point(415, 197);
            btnRemove.Margin = new Padding(10);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(86, 40);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnRemove.TextPosition = new Point(9, 10);
            btnRemove.Click += ClearFocusOnClick;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.BorderColor = Color.Empty;
            btnAdd.BorderThickness = 0F;
            btnAdd.ClickedBorderColor = Color.Empty;
            btnAdd.ClickedColor = Color.FromArgb(226, 226, 226);
            btnAdd.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.DisabledBorderColor = Color.Empty;
            btnAdd.DisabledColor = Color.FromArgb(226, 226, 226);
            btnAdd.Font = new Font("Bahnschrift", 12F);
            btnAdd.ForeColor = Color.FromArgb(9, 9, 10);
            btnAdd.HoverBorderColor = Color.Empty;
            btnAdd.HoverColor = Color.FromArgb(226, 226, 226);
            btnAdd.Image = null;
            btnAdd.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnAdd.Location = new Point(415, 114);
            btnAdd.Margin = new Padding(10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 41);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnAdd.TextPosition = new Point(24, 11);
            btnAdd.Click += ClearFocusOnClick;
            // 
            // tbReasonForQuantityChange
            // 
            tbReasonForQuantityChange.Anchor = AnchorStyles.None;
            tbReasonForQuantityChange.BackColor = Color.FromArgb(9, 9, 10);
            tbReasonForQuantityChange.BorderColor = Color.FromArgb(39, 39, 42);
            tbReasonForQuantityChange.BorderThickness = 1F;
            tbReasonForQuantityChange.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbReasonForQuantityChange.Font = new Font("Bahnschrift", 12F);
            tbReasonForQuantityChange.ForeColor = Color.Empty;
            tbReasonForQuantityChange.HoverColor = Color.Empty;
            tbReasonForQuantityChange.Location = new Point(135, 307);
            tbReasonForQuantityChange.Margin = new Padding(5);
            tbReasonForQuantityChange.MaximumSize = new Size(366, 80);
            tbReasonForQuantityChange.MaxLength = 1000;
            tbReasonForQuantityChange.MultiLine = true;
            tbReasonForQuantityChange.Name = "tbReasonForQuantityChange";
            tbReasonForQuantityChange.PlaceholderText = "Extra stock used in a cleaning job than described in the report";
            tbReasonForQuantityChange.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbReasonForQuantityChange.ReadOnly = false;
            tbReasonForQuantityChange.Size = new Size(366, 80);
            tbReasonForQuantityChange.TabIndex = 6;
            tbReasonForQuantityChange.TextAlign = HorizontalAlignment.Left;
            tbReasonForQuantityChange.TextBoxInset = new Padding(10);
            tbReasonForQuantityChange.UsePasswordChar = false;
            // 
            // lblCharacterLimit
            // 
            lblCharacterLimit.Anchor = AnchorStyles.None;
            lblCharacterLimit.Font = new Font("Bahnschrift", 12F);
            lblCharacterLimit.ForeColor = Color.FromArgb(168, 171, 174);
            lblCharacterLimit.Location = new Point(351, 392);
            lblCharacterLimit.Margin = new Padding(10, 0, 10, 20);
            lblCharacterLimit.Name = "lblCharacterLimit";
            lblCharacterLimit.Size = new Size(150, 24);
            lblCharacterLimit.TabIndex = 24;
            lblCharacterLimit.Text = "0/1000";
            lblCharacterLimit.TextAlign = ContentAlignment.MiddleRight;
            lblCharacterLimit.Click += ClearFocusOnClick;
            // 
            // tbFocusHolder
            // 
            tbFocusHolder.Location = new Point(586, 113);
            tbFocusHolder.MaximumSize = new Size(0, 1);
            tbFocusHolder.Name = "tbFocusHolder";
            tbFocusHolder.Size = new Size(0, 1);
            tbFocusHolder.TabIndex = 0;
            // 
            // ManageStockQuantityView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(tbReasonForQuantityChange);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(nudBulkRemove);
            Controls.Add(nudBulkAdd);
            Controls.Add(nudQuantity);
            Controls.Add(lblStaffLink);
            Controls.Add(lblCharacterLimit);
            Controls.Add(lblReasonForChange);
            Controls.Add(lblBulkRemove);
            Controls.Add(lblBulkAdd);
            Controls.Add(lblQuantity);
            Controls.Add(tbFocusHolder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStockQuantityView";
            Text = "Stock Quantity";
            Click += ClearFocusOnClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblQuantity;
        private Label lblBulkAdd;
        private Label lblBulkRemove;
        private Label lblReasonForChange;
        private Label lblCharacterLimit;
        private Label lblStaffLink;
        private CustomControls.CustomNumericUpDown nudQuantity;
        private CustomControls.CustomNumericUpDown nudBulkAdd;
        private CustomControls.CustomNumericUpDown nudBulkRemove;
        private CustomControls.CustomButton btnRemove;
        private CustomControls.CustomButton btnAdd;
        private CustomControls.CustomTextBox tbReasonForQuantityChange;
        private Label label1;
        private TextBox tbFocusHolder;
    }
}
