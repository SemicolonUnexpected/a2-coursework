namespace a2_coursework.View.Stock.StockManagement {
    partial class ManageStockDetailsView {
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
            lblSku = new Label();
            tbSku = new CustomControls.CustomTextBox();
            tbStockDescription = new CustomControls.CustomTextBox();
            lblStockDescription = new Label();
            lblArchived = new Label();
            lblNameSkuError = new Label();
            lblCharacterLimit = new Label();
            rbArchived = new CustomControls.CustomRadioButton();
            pnlArchived = new CustomControls.CustomPanel();
            tbFocusHolder = new TextBox();
            pnlArchived.SuspendLayout();
            SuspendLayout();
            // 
            // tbStockName
            // 
            tbStockName.AllowPaste = true;
            tbStockName.Anchor = AnchorStyles.None;
            tbStockName.BackColor = Color.FromArgb(9, 9, 10);
            tbStockName.BorderColor = Color.FromArgb(39, 39, 42);
            tbStockName.BorderThickness = 1F;
            tbStockName.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbStockName.Font = new Font("Bahnschrift", 12F);
            tbStockName.ForeColor = Color.Empty;
            tbStockName.HoverColor = Color.Empty;
            tbStockName.Location = new Point(135, 38);
            tbStockName.Margin = new Padding(5);
            tbStockName.MaxLength = 256;
            tbStockName.MultiLine = false;
            tbStockName.Name = "tbStockName";
            tbStockName.PlaceholderText = "Dettol Spray";
            tbStockName.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbStockName.ReadOnly = false;
            tbStockName.Size = new Size(355, 40);
            tbStockName.TabIndex = 1;
            tbStockName.TextAlign = HorizontalAlignment.Left;
            tbStockName.TextBoxInset = new Padding(9, 10, 9, 10);
            tbStockName.UsePasswordChar = false;
            // 
            // lblStockName
            // 
            lblStockName.Anchor = AnchorStyles.None;
            lblStockName.AutoSize = true;
            lblStockName.Font = new Font("Bahnschrift", 14F);
            lblStockName.ForeColor = Color.White;
            lblStockName.Location = new Point(135, 5);
            lblStockName.Margin = new Padding(5);
            lblStockName.Name = "lblStockName";
            lblStockName.Size = new Size(109, 23);
            lblStockName.TabIndex = 12;
            lblStockName.Text = "Stock name";
            lblStockName.Click += ClearFocusOnClick;
            // 
            // lblSKU
            // 
            lblSku.Anchor = AnchorStyles.None;
            lblSku.AutoSize = true;
            lblSku.Font = new Font("Bahnschrift", 14F);
            lblSku.ForeColor = Color.White;
            lblSku.Location = new Point(135, 88);
            lblSku.Margin = new Padding(5);
            lblSku.Name = "lblSKU";
            lblSku.Size = new Size(45, 23);
            lblSku.TabIndex = 12;
            lblSku.Text = "SKU";
            lblSku.Click += ClearFocusOnClick;
            // 
            // tbSKU
            // 
            tbSku.AllowPaste = true;
            tbSku.Anchor = AnchorStyles.None;
            tbSku.BackColor = Color.FromArgb(9, 9, 10);
            tbSku.BorderColor = Color.FromArgb(39, 39, 42);
            tbSku.BorderThickness = 1F;
            tbSku.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbSku.Font = new Font("Bahnschrift", 12F);
            tbSku.ForeColor = Color.Empty;
            tbSku.HoverColor = Color.Empty;
            tbSku.Location = new Point(135, 121);
            tbSku.Margin = new Padding(5);
            tbSku.MaxLength = 15;
            tbSku.MultiLine = false;
            tbSku.Name = "tbSKU";
            tbSku.PlaceholderText = "DET-123";
            tbSku.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSku.ReadOnly = false;
            tbSku.Size = new Size(355, 40);
            tbSku.TabIndex = 2;
            tbSku.TextAlign = HorizontalAlignment.Left;
            tbSku.TextBoxInset = new Padding(9, 10, 9, 10);
            tbSku.UsePasswordChar = false;
            // 
            // tbStockDescription
            // 
            tbStockDescription.AllowPaste = true;
            tbStockDescription.Anchor = AnchorStyles.None;
            tbStockDescription.BackColor = Color.FromArgb(9, 9, 10);
            tbStockDescription.BorderColor = Color.FromArgb(39, 39, 42);
            tbStockDescription.BorderThickness = 1F;
            tbStockDescription.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbStockDescription.Font = new Font("Bahnschrift", 12F);
            tbStockDescription.ForeColor = Color.Empty;
            tbStockDescription.HoverColor = Color.Empty;
            tbStockDescription.Location = new Point(135, 257);
            tbStockDescription.Margin = new Padding(5);
            tbStockDescription.MaximumSize = new Size(355, 83);
            tbStockDescription.MaxLength = 1000;
            tbStockDescription.MultiLine = true;
            tbStockDescription.Name = "tbStockDescription";
            tbStockDescription.PlaceholderText = "Dettol antibacterial surface cleaning Spray kills 99.9 percent of bacteria";
            tbStockDescription.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbStockDescription.ReadOnly = false;
            tbStockDescription.Size = new Size(355, 83);
            tbStockDescription.TabIndex = 3;
            tbStockDescription.TextAlign = HorizontalAlignment.Left;
            tbStockDescription.TextBoxInset = new Padding(9, 10, 9, 10);
            tbStockDescription.UsePasswordChar = false;
            // 
            // lblStockDescription
            // 
            lblStockDescription.Anchor = AnchorStyles.None;
            lblStockDescription.AutoSize = true;
            lblStockDescription.Font = new Font("Bahnschrift", 14F);
            lblStockDescription.ForeColor = Color.White;
            lblStockDescription.Location = new Point(135, 224);
            lblStockDescription.Margin = new Padding(5);
            lblStockDescription.Name = "lblStockDescription";
            lblStockDescription.Size = new Size(241, 23);
            lblStockDescription.TabIndex = 12;
            lblStockDescription.Text = "Stock description (optional)";
            lblStockDescription.Click += ClearFocusOnClick;
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
            lblArchived.Click += ClearFocusOnClick;
            // 
            // lblNameSKUError
            // 
            lblNameSkuError.Anchor = AnchorStyles.None;
            lblNameSkuError.Font = new Font("Bahnschrift", 12F);
            lblNameSkuError.ForeColor = Color.FromArgb(168, 171, 174);
            lblNameSkuError.Location = new Point(135, 166);
            lblNameSkuError.Name = "lblNameSKUError";
            lblNameSkuError.Size = new Size(355, 53);
            lblNameSkuError.TabIndex = 19;
            lblNameSkuError.TextAlign = ContentAlignment.TopCenter;
            lblNameSkuError.Click += ClearFocusOnClick;
            // 
            // lblCharacterLimit
            // 
            lblCharacterLimit.Anchor = AnchorStyles.None;
            lblCharacterLimit.Font = new Font("Bahnschrift", 12F);
            lblCharacterLimit.ForeColor = Color.FromArgb(168, 171, 174);
            lblCharacterLimit.Location = new Point(340, 345);
            lblCharacterLimit.Margin = new Padding(10, 0, 10, 20);
            lblCharacterLimit.Name = "lblCharacterLimit";
            lblCharacterLimit.Size = new Size(150, 24);
            lblCharacterLimit.TabIndex = 20;
            lblCharacterLimit.Text = "0/1000";
            lblCharacterLimit.TextAlign = ContentAlignment.MiddleRight;
            lblCharacterLimit.Click += ClearFocusOnClick;
            // 
            // rbArchived
            // 
            rbArchived.Anchor = AnchorStyles.Left;
            rbArchived.BorderThickness = 1.7F;
            rbArchived.CheckColor = Color.White;
            rbArchived.Checked = true;
            rbArchived.CheckRadius = 4.99999952F;
            rbArchived.ForeColor = Color.White;
            rbArchived.Location = new Point(324, 12);
            rbArchived.Margin = new Padding(5);
            rbArchived.Name = "rbArchived";
            rbArchived.Size = new Size(17, 17);
            rbArchived.TabIndex = 0;
            rbArchived.Text = "customRadioButton1";
            rbArchived.Click += ClearFocusOnClick;
            // 
            // pnlArchived
            // 
            pnlArchived.Anchor = AnchorStyles.None;
            pnlArchived.BorderColor = Color.FromArgb(39, 39, 42);
            pnlArchived.BorderThickness = 1F;
            pnlArchived.Controls.Add(lblArchived);
            pnlArchived.Controls.Add(rbArchived);
            pnlArchived.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlArchived.Location = new Point(135, 374);
            pnlArchived.Margin = new Padding(5);
            pnlArchived.Name = "pnlArchived";
            pnlArchived.Padding = new Padding(5);
            pnlArchived.Size = new Size(355, 41);
            pnlArchived.TabIndex = 22;
            pnlArchived.Click += ClearFocusOnClick;
            // 
            // tbFocusHolder
            // 
            tbFocusHolder.Location = new Point(0, 0);
            tbFocusHolder.MaximumSize = new Size(0, 4);
            tbFocusHolder.Name = "tbFocusHolder";
            tbFocusHolder.Size = new Size(0, 4);
            tbFocusHolder.TabIndex = 0;
            // 
            // ManageStockDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(tbFocusHolder);
            Controls.Add(pnlArchived);
            Controls.Add(lblCharacterLimit);
            Controls.Add(lblNameSkuError);
            Controls.Add(lblSku);
            Controls.Add(lblStockDescription);
            Controls.Add(lblStockName);
            Controls.Add(tbStockDescription);
            Controls.Add(tbSku);
            Controls.Add(tbStockName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStockDetailsView";
            Text = "Stock Details";
            Click += ClearFocusOnClick;
            pnlArchived.ResumeLayout(false);
            pnlArchived.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomTextBox tbStockName;
        private Label lblStockName;
        private Label lblSku;
        private CustomControls.CustomTextBox tbSku;
        private CustomControls.CustomTextBox tbStockDescription;
        private Label lblStockDescription;
        private Label lblArchived;
        private Label lblNameSkuError;
        private Label lblCharacterLimit;
        private CustomControls.CustomRadioButton rbArchived;
        private CustomControls.CustomPanel pnlArchived;
        private TextBox tbFocusHolder;
    }
}