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
            btn = new a2_coursework.CustomControls.CustomButton();
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
            tbDescription.PlaceholderText = "Cleaning stock needs replenished after a deep cleaning job";
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
            btn.Anchor = AnchorStyles.None;
            btn.BackColor = SystemColors.Control;
            btn.BorderColor = Color.Empty;
            btn.BorderThickness = 0F;
            btn.ClickedBorderColor = Color.Empty;
            btn.ClickedColor = Color.FromArgb(226, 226, 226);
            btn.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btn.Cursor = Cursors.Hand;
            btn.DisabledBorderColor = Color.Empty;
            btn.DisabledColor = Color.FromArgb(226, 226, 226);
            btn.Font = new Font("Bahnschrift", 12F);
            btn.ForeColor = Color.FromArgb(9, 9, 10);
            btn.HoverBorderColor = Color.Empty;
            btn.HoverColor = Color.FromArgb(226, 226, 226);
            btn.Image = null;
            btn.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btn.Location = new Point(181, 317);
            btn.Margin = new Padding(10);
            btn.Name = "btnSubmit";
            btn.Size = new Size(282, 40);
            btn.TabIndex = 24;
            btn.Text = "Submit";
            btn.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btn.TextPosition = new Point(111, 10);
            // 
            // SubmitOrderView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(btn);
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
        private CustomControls.CustomButton btn;
    }
}