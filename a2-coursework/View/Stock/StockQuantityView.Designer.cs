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
            lblName = new Label();
            label1 = new Label();
            customTextBox1 = new CustomControls.CustomTextBox();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            numericUpDown1 = new CustomControls.CustomNumericUpDown();
            btnSignIn = new CustomControls.CustomButton();
            customTextBox2 = new CustomControls.CustomTextBox();
            label2 = new Label();
            customButton1 = new CustomControls.CustomButton();
            label3 = new Label();
            customTextBox3 = new CustomControls.CustomTextBox();
            lblCharacterLimit = new Label();
            lblEditPromt = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 14F);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(135, 14);
            lblName.Margin = new Padding(5);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 23);
            lblName.TabIndex = 12;
            lblName.Text = "Quantity";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 94);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 12;
            label1.Text = "Bulk Add";
            // 
            // customTextBox1
            // 
            customTextBox1.Anchor = AnchorStyles.Top;
            customTextBox1.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox1.BorderColor = Color.FromArgb(39, 39, 42);
            customTextBox1.BorderThickness = 1F;
            customTextBox1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox1.Font = new Font("Bahnschrift", 12F);
            customTextBox1.ForeColor = Color.Empty;
            customTextBox1.HoverColor = Color.Empty;
            customTextBox1.Location = new Point(135, 127);
            customTextBox1.Margin = new Padding(5);
            customTextBox1.MaxLength = 256;
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "";
            customTextBox1.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            customTextBox1.ReadOnly = true;
            customTextBox1.Size = new Size(264, 40);
            customTextBox1.TabIndex = 1;
            customTextBox1.TextAlign = HorizontalAlignment.Left;
            customTextBox1.TextBoxInset = new Padding(10);
            customTextBox1.UsePasswordChar = false;
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
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(9, 9, 10);
            numericUpDown1.Location = new Point(135, 45);
            numericUpDown1.Maximum = 1000000;
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(174, 41);
            numericUpDown1.TabIndex = 20;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.Control;
            btnSignIn.BorderColor = Color.Empty;
            btnSignIn.BorderThickness = 0F;
            btnSignIn.ClickedBorderColor = Color.Empty;
            btnSignIn.ClickedColor = Color.FromArgb(226, 226, 226);
            btnSignIn.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.DisabledBorderColor = Color.Empty;
            btnSignIn.DisabledColor = Color.FromArgb(226, 226, 226);
            btnSignIn.Font = new Font("Bahnschrift", 12F);
            btnSignIn.ForeColor = Color.FromArgb(9, 9, 10);
            btnSignIn.HoverBorderColor = Color.Empty;
            btnSignIn.HoverColor = Color.FromArgb(226, 226, 226);
            btnSignIn.Image = null;
            btnSignIn.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnSignIn.Location = new Point(414, 127);
            btnSignIn.Margin = new Padding(10);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(88, 40);
            btnSignIn.TabIndex = 21;
            btnSignIn.Text = "Add";
            btnSignIn.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnSignIn.TextPosition = new Point(25, 10);
            // 
            // customTextBox2
            // 
            customTextBox2.Anchor = AnchorStyles.Top;
            customTextBox2.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox2.BorderColor = Color.FromArgb(39, 39, 42);
            customTextBox2.BorderThickness = 1F;
            customTextBox2.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox2.Font = new Font("Bahnschrift", 12F);
            customTextBox2.ForeColor = Color.Empty;
            customTextBox2.HoverColor = Color.Empty;
            customTextBox2.Location = new Point(135, 210);
            customTextBox2.Margin = new Padding(5);
            customTextBox2.MaxLength = 256;
            customTextBox2.MultiLine = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.PlaceholderText = "";
            customTextBox2.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            customTextBox2.ReadOnly = true;
            customTextBox2.Size = new Size(264, 40);
            customTextBox2.TabIndex = 1;
            customTextBox2.TextAlign = HorizontalAlignment.Left;
            customTextBox2.TextBoxInset = new Padding(10);
            customTextBox2.UsePasswordChar = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(135, 177);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 12;
            label2.Text = "Bulk Remove";
            // 
            // customButton1
            // 
            customButton1.BackColor = SystemColors.Control;
            customButton1.BorderColor = Color.Empty;
            customButton1.BorderThickness = 0F;
            customButton1.ClickedBorderColor = Color.Empty;
            customButton1.ClickedColor = Color.FromArgb(226, 226, 226);
            customButton1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customButton1.Cursor = Cursors.Hand;
            customButton1.DisabledBorderColor = Color.Empty;
            customButton1.DisabledColor = Color.FromArgb(226, 226, 226);
            customButton1.Font = new Font("Bahnschrift", 12F);
            customButton1.ForeColor = Color.FromArgb(9, 9, 10);
            customButton1.HoverBorderColor = Color.Empty;
            customButton1.HoverColor = Color.FromArgb(226, 226, 226);
            customButton1.Image = null;
            customButton1.ImageRectangle = new Rectangle(0, 0, 0, 0);
            customButton1.Location = new Point(414, 210);
            customButton1.Margin = new Padding(10);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(88, 40);
            customButton1.TabIndex = 21;
            customButton1.Text = "Remove";
            customButton1.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            customButton1.TextPosition = new Point(10, 10);
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 14F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(135, 260);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(331, 23);
            label3.TabIndex = 23;
            label3.Text = "Reason for Quantity Change (optional)";
            // 
            // customTextBox3
            // 
            customTextBox3.Anchor = AnchorStyles.Top;
            customTextBox3.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox3.BorderColor = Color.FromArgb(39, 39, 42);
            customTextBox3.BorderThickness = 1F;
            customTextBox3.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox3.Font = new Font("Bahnschrift", 12F);
            customTextBox3.ForeColor = Color.Empty;
            customTextBox3.HoverColor = Color.Empty;
            customTextBox3.Location = new Point(135, 321);
            customTextBox3.Margin = new Padding(5);
            customTextBox3.MaxLength = 256;
            customTextBox3.MultiLine = true;
            customTextBox3.Name = "customTextBox3";
            customTextBox3.PlaceholderText = "";
            customTextBox3.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            customTextBox3.ReadOnly = true;
            customTextBox3.Size = new Size(355, 104);
            customTextBox3.TabIndex = 22;
            customTextBox3.TextAlign = HorizontalAlignment.Left;
            customTextBox3.TextBoxInset = new Padding(10);
            customTextBox3.UsePasswordChar = false;
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
            lblCharacterLimit.Text = "0/256";
            lblCharacterLimit.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblEditPromt
            // 
            lblEditPromt.Anchor = AnchorStyles.Top;
            lblEditPromt.AutoSize = true;
            lblEditPromt.Font = new Font("Bahnschrift", 12F);
            lblEditPromt.ForeColor = Color.FromArgb(168, 171, 174);
            lblEditPromt.Location = new Point(135, 288);
            lblEditPromt.Margin = new Padding(10, 0, 10, 20);
            lblEditPromt.Name = "lblEditPromt";
            lblEditPromt.Size = new Size(366, 19);
            lblEditPromt.TabIndex = 25;
            lblEditPromt.Text = "Your staff account is linked to this quantity update";
            // 
            // StockQuantityView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(lblEditPromt);
            Controls.Add(lblCharacterLimit);
            Controls.Add(label3);
            Controls.Add(customTextBox3);
            Controls.Add(customButton1);
            Controls.Add(btnSignIn);
            Controls.Add(numericUpDown1);
            Controls.Add(approveChangesBar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customTextBox2);
            Controls.Add(lblName);
            Controls.Add(customTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockQuantityView";
            Text = "Stock_Details_view";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label label1;
        private CustomControls.CustomTextBox customTextBox1;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private CustomControls.CustomNumericUpDown numericUpDown1;
        private CustomControls.CustomButton btnSignIn;
        private CustomControls.CustomTextBox customTextBox2;
        private Label label2;
        private CustomControls.CustomButton customButton1;
        private Label label3;
        private CustomControls.CustomTextBox customTextBox3;
        private Label lblCharacterLimit;
        private Label lblEditPromt;
    }
}
