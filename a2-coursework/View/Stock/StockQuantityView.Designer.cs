namespace a2_coursework.View.Stock {
    partial class StockQuantityView {
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
            tbBulkAdd = new CustomControls.CustomTextBox();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            btnAdd = new CustomControls.CustomButton();
            tbBulkRemove = new CustomControls.CustomTextBox();
            lblBulkRemove = new Label();
            btnRemove = new CustomControls.CustomButton();
            lblReasonForChange = new Label();
            tbReasonForChange = new CustomControls.CustomTextBox();
            lblCharacterLimit = new Label();
            lblStaffLink = new Label();
            nudQuantity = new CustomControls.CustomNumericUpDown();
            SuspendLayout();
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.None;
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Bahnschrift", 14F);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(135, 14);
            lblQuantity.Margin = new Padding(5);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(80, 23);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Quantity";
            // 
            // lblBulkAdd
            // 
            lblBulkAdd.Anchor = AnchorStyles.None;
            lblBulkAdd.AutoSize = true;
            lblBulkAdd.Font = new Font("Bahnschrift", 14F);
            lblBulkAdd.ForeColor = Color.White;
            lblBulkAdd.Location = new Point(135, 94);
            lblBulkAdd.Margin = new Padding(5);
            lblBulkAdd.Name = "lblBulkAdd";
            lblBulkAdd.Size = new Size(86, 23);
            lblBulkAdd.TabIndex = 12;
            lblBulkAdd.Text = "Bulk Add";
            // 
            // tbBulkAdd
            // 
            tbBulkAdd.Anchor = AnchorStyles.Top;
            tbBulkAdd.BackColor = Color.FromArgb(9, 9, 10);
            tbBulkAdd.BorderColor = Color.FromArgb(39, 39, 42);
            tbBulkAdd.BorderThickness = 1F;
            tbBulkAdd.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbBulkAdd.Font = new Font("Bahnschrift", 12F);
            tbBulkAdd.ForeColor = Color.Empty;
            tbBulkAdd.HoverColor = Color.Empty;
            tbBulkAdd.Location = new Point(135, 127);
            tbBulkAdd.Margin = new Padding(5);
            tbBulkAdd.MaxLength = 256;
            tbBulkAdd.MultiLine = false;
            tbBulkAdd.Name = "tbBulkAdd";
            tbBulkAdd.PlaceholderText = "";
            tbBulkAdd.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbBulkAdd.ReadOnly = true;
            tbBulkAdd.Size = new Size(264, 40);
            tbBulkAdd.TabIndex = 1;
            tbBulkAdd.TextAlign = HorizontalAlignment.Left;
            tbBulkAdd.TextBoxInset = new Padding(10);
            tbBulkAdd.UsePasswordChar = false;
            tbBulkAdd.KeyPress += tbBulkAdd_KeyPress;
            // 
            // approveChangesBar
            // 
            approveChangesBar.BackColor = Color.FromArgb(9, 9, 10);
            approveChangesBar.Dock = DockStyle.Bottom;
            approveChangesBar.IsLoading = false;
            approveChangesBar.Location = new Point(0, 459);
            approveChangesBar.Name = "approveChangesBar";
            approveChangesBar.Size = new Size(654, 41);
            approveChangesBar.TabIndex = 13;
            approveChangesBar.ToolTipsActive = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.BorderColor = Color.Empty;
            btnAdd.BorderThickness = 0F;
            btnAdd.ClickedBorderColor = Color.Empty;
            btnAdd.ClickedColor = Color.FromArgb(226, 226, 226);
            btnAdd.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.DisabledBorderColor = Color.Empty;
            btnAdd.DisabledColor = Color.FromArgb(226, 226, 226);
            btnAdd.Font = new Font("Bahnschrift", 12F);
            btnAdd.ForeColor = Color.FromArgb(9, 9, 10);
            btnAdd.HoverBorderColor = Color.Empty;
            btnAdd.HoverColor = Color.FromArgb(226, 226, 226);
            btnAdd.Image = null;
            btnAdd.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnAdd.Location = new Point(414, 127);
            btnAdd.Margin = new Padding(10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 40);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnAdd.TextPosition = new Point(25, 10);
            // 
            // tbBulkRemove
            // 
            tbBulkRemove.Anchor = AnchorStyles.Top;
            tbBulkRemove.BackColor = Color.FromArgb(9, 9, 10);
            tbBulkRemove.BorderColor = Color.FromArgb(39, 39, 42);
            tbBulkRemove.BorderThickness = 1F;
            tbBulkRemove.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbBulkRemove.Font = new Font("Bahnschrift", 12F);
            tbBulkRemove.ForeColor = Color.Empty;
            tbBulkRemove.HoverColor = Color.Empty;
            tbBulkRemove.Location = new Point(135, 210);
            tbBulkRemove.Margin = new Padding(5);
            tbBulkRemove.MaxLength = 256;
            tbBulkRemove.MultiLine = false;
            tbBulkRemove.Name = "tbBulkRemove";
            tbBulkRemove.PlaceholderText = "";
            tbBulkRemove.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbBulkRemove.ReadOnly = true;
            tbBulkRemove.Size = new Size(264, 40);
            tbBulkRemove.TabIndex = 1;
            tbBulkRemove.TextAlign = HorizontalAlignment.Left;
            tbBulkRemove.TextBoxInset = new Padding(10);
            tbBulkRemove.UsePasswordChar = false;
            tbBulkRemove.KeyPress += tbBulkRemove_KeyPress;
            // 
            // lblBulkRemove
            // 
            lblBulkRemove.Anchor = AnchorStyles.None;
            lblBulkRemove.AutoSize = true;
            lblBulkRemove.Font = new Font("Bahnschrift", 14F);
            lblBulkRemove.ForeColor = Color.White;
            lblBulkRemove.Location = new Point(135, 177);
            lblBulkRemove.Margin = new Padding(5);
            lblBulkRemove.Name = "lblBulkRemove";
            lblBulkRemove.Size = new Size(122, 23);
            lblBulkRemove.TabIndex = 12;
            lblBulkRemove.Text = "Bulk Remove";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.Control;
            btnRemove.BorderColor = Color.Empty;
            btnRemove.BorderThickness = 0F;
            btnRemove.ClickedBorderColor = Color.Empty;
            btnRemove.ClickedColor = Color.FromArgb(226, 226, 226);
            btnRemove.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.DisabledBorderColor = Color.Empty;
            btnRemove.DisabledColor = Color.FromArgb(226, 226, 226);
            btnRemove.Font = new Font("Bahnschrift", 12F);
            btnRemove.ForeColor = Color.FromArgb(9, 9, 10);
            btnRemove.HoverBorderColor = Color.Empty;
            btnRemove.HoverColor = Color.FromArgb(226, 226, 226);
            btnRemove.Image = null;
            btnRemove.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnRemove.Location = new Point(414, 210);
            btnRemove.Margin = new Padding(10);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(88, 40);
            btnRemove.TabIndex = 21;
            btnRemove.Text = "Remove";
            btnRemove.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnRemove.TextPosition = new Point(10, 10);
            // 
            // lblReasonForChange
            // 
            lblReasonForChange.Anchor = AnchorStyles.None;
            lblReasonForChange.AutoSize = true;
            lblReasonForChange.Font = new Font("Bahnschrift", 14F);
            lblReasonForChange.ForeColor = Color.White;
            lblReasonForChange.Location = new Point(135, 260);
            lblReasonForChange.Margin = new Padding(5);
            lblReasonForChange.Name = "lblReasonForChange";
            lblReasonForChange.Size = new Size(331, 23);
            lblReasonForChange.TabIndex = 23;
            lblReasonForChange.Text = "Reason for Quantity Change (optional)";
            // 
            // tbReasonForChange
            // 
            tbReasonForChange.Anchor = AnchorStyles.Top;
            tbReasonForChange.BackColor = Color.FromArgb(9, 9, 10);
            tbReasonForChange.BorderColor = Color.FromArgb(39, 39, 42);
            tbReasonForChange.BorderThickness = 1F;
            tbReasonForChange.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbReasonForChange.Font = new Font("Bahnschrift", 12F);
            tbReasonForChange.ForeColor = Color.Empty;
            tbReasonForChange.HoverColor = Color.Empty;
            tbReasonForChange.Location = new Point(135, 321);
            tbReasonForChange.Margin = new Padding(5);
            tbReasonForChange.MaxLength = 256;
            tbReasonForChange.MultiLine = true;
            tbReasonForChange.Name = "tbReasonForChange";
            tbReasonForChange.PlaceholderText = "";
            tbReasonForChange.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbReasonForChange.ReadOnly = true;
            tbReasonForChange.Size = new Size(355, 104);
            tbReasonForChange.TabIndex = 22;
            tbReasonForChange.TextAlign = HorizontalAlignment.Left;
            tbReasonForChange.TextBoxInset = new Padding(10);
            tbReasonForChange.UsePasswordChar = false;
            // 
            // lblCharacterLimit
            // 
            lblCharacterLimit.Anchor = AnchorStyles.None;
            lblCharacterLimit.Font = new Font("Bahnschrift", 12F);
            lblCharacterLimit.ForeColor = Color.FromArgb(168, 171, 174);
            lblCharacterLimit.Location = new Point(340, 430);
            lblCharacterLimit.Margin = new Padding(10, 0, 10, 20);
            lblCharacterLimit.Name = "lblCharacterLimit";
            lblCharacterLimit.Size = new Size(150, 24);
            lblCharacterLimit.TabIndex = 24;
            lblCharacterLimit.Text = "0/1000";
            lblCharacterLimit.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblStaffLink
            // 
            lblStaffLink.Anchor = AnchorStyles.Top;
            lblStaffLink.AutoSize = true;
            lblStaffLink.Font = new Font("Bahnschrift", 12F);
            lblStaffLink.ForeColor = Color.FromArgb(168, 171, 174);
            lblStaffLink.Location = new Point(135, 288);
            lblStaffLink.Margin = new Padding(10, 0, 10, 20);
            lblStaffLink.Name = "lblStaffLink";
            lblStaffLink.Size = new Size(366, 19);
            lblStaffLink.TabIndex = 25;
            lblStaffLink.Text = "Your staff account is linked to this quantity update";
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.FromArgb(9, 9, 10);
            nudQuantity.Location = new Point(135, 45);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(250, 41);
            nudQuantity.TabIndex = 26;
            // 
            // StockQuantityView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(nudQuantity);
            Controls.Add(lblStaffLink);
            Controls.Add(lblCharacterLimit);
            Controls.Add(lblReasonForChange);
            Controls.Add(tbReasonForChange);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(approveChangesBar);
            Controls.Add(lblBulkRemove);
            Controls.Add(lblBulkAdd);
            Controls.Add(tbBulkRemove);
            Controls.Add(lblQuantity);
            Controls.Add(tbBulkAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockQuantityView";
            Text = "Stock_Details_view";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblQuantity;
        private Label lblBulkAdd;
        private CustomControls.CustomTextBox tbBulkAdd;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private CustomControls.CustomButton btnAdd;
        private CustomControls.CustomTextBox tbBulkRemove;
        private Label lblBulkRemove;
        private CustomControls.CustomButton btnRemove;
        private Label lblReasonForChange;
        private CustomControls.CustomTextBox tbReasonForChange;
        private Label lblCharacterLimit;
        private Label lblStaffLink;
        private CustomControls.CustomNumericUpDown nudQuantity;
    }
}
