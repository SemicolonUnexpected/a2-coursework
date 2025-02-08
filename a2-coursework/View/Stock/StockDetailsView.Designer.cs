namespace a2_coursework.View.Stock {
    partial class StockDetailsView {
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
            tbStockName = new CustomControls.CustomTextBox();
            lblStockName = new Label();
            lblSKU = new Label();
            tbSKU = new CustomControls.CustomTextBox();
            tbStockDescription = new CustomControls.CustomTextBox();
            lblStockDescription = new Label();
            lblArchived = new Label();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            lblSKUError = new Label();
            lblCharacterLimit = new Label();
            rbArchived = new CustomControls.CustomRadioButton();
            pnlArchived = new CustomControls.CustomPanel();
            pnlArchived.SuspendLayout();
            SuspendLayout();
            // 
            // tbStockName
            // 
            tbStockName.Anchor = AnchorStyles.Top;
            tbStockName.BackColor = Color.FromArgb(9, 9, 10);
            tbStockName.BorderColor = Color.FromArgb(39, 39, 42);
            tbStockName.BorderThickness = 1F;
            tbStockName.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbStockName.Font = new Font("Bahnschrift", 12F);
            tbStockName.ForeColor = Color.Empty;
            tbStockName.HoverColor = Color.Empty;
            tbStockName.Location = new Point(135, 44);
            tbStockName.Margin = new Padding(5);
            tbStockName.MaxLength = 256;
            tbStockName.MultiLine = false;
            tbStockName.Name = "tbStockName";
            tbStockName.PlaceholderText = "Dettol Spray";
            tbStockName.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbStockName.ReadOnly = true;
            tbStockName.Size = new Size(355, 40);
            tbStockName.TabIndex = 1;
            tbStockName.TextAlign = HorizontalAlignment.Left;
            tbStockName.TextBoxInset = new Padding(10);
            tbStockName.UsePasswordChar = false;
            // 
            // lblStockName
            // 
            lblStockName.Anchor = AnchorStyles.None;
            lblStockName.AutoSize = true;
            lblStockName.Font = new Font("Bahnschrift", 14F);
            lblStockName.ForeColor = Color.White;
            lblStockName.Location = new Point(135, 11);
            lblStockName.Margin = new Padding(5);
            lblStockName.Name = "lblStockName";
            lblStockName.Size = new Size(109, 23);
            lblStockName.TabIndex = 12;
            lblStockName.Text = "Stock name";
            // 
            // lblSKU
            // 
            lblSKU.Anchor = AnchorStyles.None;
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Bahnschrift", 14F);
            lblSKU.ForeColor = Color.White;
            lblSKU.Location = new Point(135, 94);
            lblSKU.Margin = new Padding(5);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(45, 23);
            lblSKU.TabIndex = 12;
            lblSKU.Text = "SKU";
            // 
            // tbSKU
            // 
            tbSKU.Anchor = AnchorStyles.Top;
            tbSKU.BackColor = Color.FromArgb(9, 9, 10);
            tbSKU.BorderColor = Color.FromArgb(39, 39, 42);
            tbSKU.BorderThickness = 1F;
            tbSKU.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbSKU.Font = new Font("Bahnschrift", 12F);
            tbSKU.ForeColor = Color.Empty;
            tbSKU.HoverColor = Color.Empty;
            tbSKU.Location = new Point(135, 127);
            tbSKU.Margin = new Padding(5);
            tbSKU.MaxLength = 256;
            tbSKU.MultiLine = false;
            tbSKU.Name = "tbSKU";
            tbSKU.PlaceholderText = "DET-123";
            tbSKU.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSKU.ReadOnly = true;
            tbSKU.Size = new Size(355, 40);
            tbSKU.TabIndex = 1;
            tbSKU.TextAlign = HorizontalAlignment.Left;
            tbSKU.TextBoxInset = new Padding(10);
            tbSKU.UsePasswordChar = false;
            // 
            // tbStockDescription
            // 
            tbStockDescription.Anchor = AnchorStyles.Top;
            tbStockDescription.BackColor = Color.FromArgb(9, 9, 10);
            tbStockDescription.BorderColor = Color.FromArgb(39, 39, 42);
            tbStockDescription.BorderThickness = 1F;
            tbStockDescription.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbStockDescription.Font = new Font("Bahnschrift", 12F);
            tbStockDescription.ForeColor = Color.Empty;
            tbStockDescription.HoverColor = Color.Empty;
            tbStockDescription.Location = new Point(135, 248);
            tbStockDescription.Margin = new Padding(5);
            tbStockDescription.MaxLength = 256;
            tbStockDescription.MultiLine = true;
            tbStockDescription.Name = "tbStockDescription";
            tbStockDescription.PlaceholderText = "Dettol antibacterial surface cleaning Spray kills 99.9 percent of bacteria";
            tbStockDescription.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbStockDescription.ReadOnly = true;
            tbStockDescription.Size = new Size(355, 130);
            tbStockDescription.TabIndex = 1;
            tbStockDescription.TextAlign = HorizontalAlignment.Left;
            tbStockDescription.TextBoxInset = new Padding(10);
            tbStockDescription.UsePasswordChar = false;
            // 
            // lblStockDescription
            // 
            lblStockDescription.Anchor = AnchorStyles.None;
            lblStockDescription.AutoSize = true;
            lblStockDescription.Font = new Font("Bahnschrift", 14F);
            lblStockDescription.ForeColor = Color.White;
            lblStockDescription.Location = new Point(135, 215);
            lblStockDescription.Margin = new Padding(5);
            lblStockDescription.Name = "lblStockDescription";
            lblStockDescription.Size = new Size(156, 23);
            lblStockDescription.TabIndex = 12;
            lblStockDescription.Text = "Stock description";
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Left;
            lblArchived.AutoSize = true;
            lblArchived.Font = new Font("Bahnschrift", 14F);
            lblArchived.ForeColor = Color.White;
            lblArchived.Location = new Point(10, 9);
            lblArchived.Margin = new Padding(5);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(85, 23);
            lblArchived.TabIndex = 12;
            lblArchived.Text = "Archived";
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
            // lblSKUError
            // 
            lblSKUError.Anchor = AnchorStyles.None;
            lblSKUError.Font = new Font("Bahnschrift", 12F);
            lblSKUError.ForeColor = Color.FromArgb(168, 171, 174);
            lblSKUError.Location = new Point(135, 172);
            lblSKUError.Name = "lblSKUError";
            lblSKUError.Size = new Size(355, 38);
            lblSKUError.TabIndex = 19;
            lblSKUError.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCharacterLimit
            // 
            lblCharacterLimit.Anchor = AnchorStyles.None;
            lblCharacterLimit.Font = new Font("Bahnschrift", 12F);
            lblCharacterLimit.ForeColor = Color.FromArgb(168, 171, 174);
            lblCharacterLimit.Location = new Point(340, 383);
            lblCharacterLimit.Margin = new Padding(10, 0, 10, 20);
            lblCharacterLimit.Name = "lblCharacterLimit";
            lblCharacterLimit.Size = new Size(150, 24);
            lblCharacterLimit.TabIndex = 20;
            lblCharacterLimit.Text = "0/256";
            lblCharacterLimit.TextAlign = ContentAlignment.BottomRight;
            // 
            // rbArchived
            // 
            rbArchived.Anchor = AnchorStyles.Left;
            rbArchived.BorderThickness = 1.7F;
            rbArchived.CheckColor = Color.White;
            rbArchived.Checked = true;
            rbArchived.CheckRadius = 5F;
            rbArchived.ForeColor = Color.White;
            rbArchived.Location = new Point(324, 12);
            rbArchived.Margin = new Padding(5);
            rbArchived.Name = "rbArchived";
            rbArchived.Size = new Size(17, 17);
            rbArchived.TabIndex = 21;
            rbArchived.Text = "customRadioButton1";
            // 
            // pnlArchived
            // 
            pnlArchived.Anchor = AnchorStyles.None;
            pnlArchived.BorderColor = Color.FromArgb(39, 39, 42);
            pnlArchived.BorderThickness = 1F;
            pnlArchived.Controls.Add(lblArchived);
            pnlArchived.Controls.Add(rbArchived);
            pnlArchived.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlArchived.Location = new Point(135, 412);
            pnlArchived.Margin = new Padding(5);
            pnlArchived.Name = "pnlArchived";
            pnlArchived.Padding = new Padding(5);
            pnlArchived.Size = new Size(355, 41);
            pnlArchived.TabIndex = 22;
            // 
            // StockDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(pnlArchived);
            Controls.Add(lblCharacterLimit);
            Controls.Add(lblSKUError);
            Controls.Add(approveChangesBar);
            Controls.Add(lblSKU);
            Controls.Add(lblStockDescription);
            Controls.Add(lblStockName);
            Controls.Add(tbStockDescription);
            Controls.Add(tbSKU);
            Controls.Add(tbStockName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockDetailsView";
            Text = "Stock_Details_view";
            pnlArchived.ResumeLayout(false);
            pnlArchived.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomTextBox tbStockName;
        private Label lblStockName;
        private Label lblSKU;
        private CustomControls.CustomTextBox tbSKU;
        private CustomControls.CustomTextBox tbStockDescription;
        private Label lblStockDescription;
        private Label lblArchived;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private Label lblSKUError;
        private Label lblCharacterLimit;
        private CustomControls.CustomRadioButton rbArchived;
        private CustomControls.CustomPanel pnlArchived;
    }
}