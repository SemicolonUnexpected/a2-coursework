namespace a2_coursework.View.Order {
    partial class SubmitOrderView {
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
            btnSubmit = new a2_coursework.CustomControls.CustomButton();
            SuspendLayout();
            // 
            // tbAddress
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
            tbDescription.MaxLength = 500;
            tbDescription.MultiLine = true;
            tbDescription.Name = "tbAddress";
            tbDescription.PlaceholderText = "Cleaning stock needs replenished after a deep cleaning job";
            tbDescription.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbDescription.ReadOnly = false;
            tbDescription.Size = new Size(355, 166);
            tbDescription.TabIndex = 22;
            tbDescription.TextAlign = HorizontalAlignment.Left;
            tbDescription.TextBoxInset = new Padding(10);
            tbDescription.UsePasswordChar = false;
            // 
            // lblAddressTitle
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Bahnschrift", 14F);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(145, 61);
            lblDescription.Margin = new Padding(5);
            lblDescription.Name = "lblAddressTitle";
            lblDescription.Size = new Size(191, 23);
            lblDescription.TabIndex = 23;
            lblDescription.Text = "Description (optional)";
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
            lblCharacterLimit.Text = "0/256";
            lblCharacterLimit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.Control;
            btnSubmit.BorderColor = Color.Empty;
            btnSubmit.BorderThickness = 0F;
            btnSubmit.ClickedBorderColor = Color.Empty;
            btnSubmit.ClickedColor = Color.FromArgb(226, 226, 226);
            btnSubmit.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.DisabledBorderColor = Color.Empty;
            btnSubmit.DisabledColor = Color.FromArgb(226, 226, 226);
            btnSubmit.Font = new Font("Bahnschrift", 12F);
            btnSubmit.ForeColor = Color.FromArgb(9, 9, 10);
            btnSubmit.HoverBorderColor = Color.Empty;
            btnSubmit.HoverColor = Color.FromArgb(226, 226, 226);
            btnSubmit.Image = null;
            btnSubmit.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnSubmit.Location = new Point(181, 317);
            btnSubmit.Margin = new Padding(10);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(282, 40);
            btnSubmit.TabIndex = 24;
            btnSubmit.Text = "Submit";
            btnSubmit.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnSubmit.TextPosition = new Point(111, 10);
            // 
            // SubmitOrderView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(btnSubmit);
            Controls.Add(tbDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblCharacterLimit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubmitOrderView";
            Text = "Contact Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.CustomTextBox tbDescription;
        private Label lblDescription;
        private Label lblCharacterLimit;
        private CustomControls.CustomButton btnSubmit;
    }
}