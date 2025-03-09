namespace a2_coursework.View.Order {
    partial class ManageCustomerPersonalDetailsView {
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
            tbForename = new CustomControls.CustomTextBox();
            tbSurname = new CustomControls.CustomTextBox();
            lblSurnameTitle = new Label();
            lblForenameTitle = new Label();
            pnlArchived = new CustomControls.CustomPanel();
            lblArchived = new Label();
            rbArchived = new CustomControls.CustomRadioButton();
            lblNameError = new Label();
            pnlArchived.SuspendLayout();
            SuspendLayout();
            // 
            // tbForename
            // 
            tbForename.Anchor = AnchorStyles.None;
            tbForename.BackColor = Color.FromArgb(9, 9, 10);
            tbForename.BorderColor = Color.FromArgb(39, 39, 42);
            tbForename.BorderThickness = 1F;
            tbForename.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbForename.Font = new Font("Bahnschrift", 12F);
            tbForename.ForeColor = Color.Empty;
            tbForename.HoverColor = Color.Empty;
            tbForename.Location = new Point(151, 47);
            tbForename.Margin = new Padding(5);
            tbForename.MaxLength = 256;
            tbForename.MultiLine = false;
            tbForename.Name = "tbForename";
            tbForename.PlaceholderText = "John";
            tbForename.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbForename.ReadOnly = false;
            tbForename.Size = new Size(355, 40);
            tbForename.TabIndex = 7;
            tbForename.TextAlign = HorizontalAlignment.Left;
            tbForename.TextBoxInset = new Padding(10);
            tbForename.ToolTipText = "Type in your forname";
            tbForename.UsePasswordChar = false;
            // 
            // tbSurname
            // 
            tbSurname.Anchor = AnchorStyles.None;
            tbSurname.BackColor = Color.FromArgb(9, 9, 10);
            tbSurname.BorderColor = Color.FromArgb(39, 39, 42);
            tbSurname.BorderThickness = 1F;
            tbSurname.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbSurname.Font = new Font("Bahnschrift", 12F);
            tbSurname.ForeColor = Color.Empty;
            tbSurname.HoverColor = Color.Empty;
            tbSurname.Location = new Point(151, 130);
            tbSurname.Margin = new Padding(5);
            tbSurname.MaxLength = 256;
            tbSurname.MultiLine = false;
            tbSurname.Name = "tbSurname";
            tbSurname.PlaceholderText = "Doe";
            tbSurname.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSurname.ReadOnly = false;
            tbSurname.Size = new Size(355, 40);
            tbSurname.TabIndex = 8;
            tbSurname.TextAlign = HorizontalAlignment.Left;
            tbSurname.TextBoxInset = new Padding(10);
            tbSurname.ToolTipText = "Type in your surname";
            tbSurname.UsePasswordChar = false;
            // 
            // lblSurnameTitle
            // 
            lblSurnameTitle.Anchor = AnchorStyles.None;
            lblSurnameTitle.AutoSize = true;
            lblSurnameTitle.Font = new Font("Bahnschrift", 14F);
            lblSurnameTitle.ForeColor = Color.White;
            lblSurnameTitle.Location = new Point(149, 97);
            lblSurnameTitle.Margin = new Padding(5);
            lblSurnameTitle.Name = "lblSurnameTitle";
            lblSurnameTitle.Size = new Size(88, 23);
            lblSurnameTitle.TabIndex = 10;
            lblSurnameTitle.Text = "Surname";
            // 
            // lblForenameTitle
            // 
            lblForenameTitle.Anchor = AnchorStyles.None;
            lblForenameTitle.AutoSize = true;
            lblForenameTitle.Font = new Font("Bahnschrift", 14F);
            lblForenameTitle.ForeColor = Color.White;
            lblForenameTitle.Location = new Point(149, 14);
            lblForenameTitle.Margin = new Padding(5);
            lblForenameTitle.Name = "lblForenameTitle";
            lblForenameTitle.Size = new Size(96, 23);
            lblForenameTitle.TabIndex = 9;
            lblForenameTitle.Text = "Forename";
            // 
            // pnlArchived
            // 
            pnlArchived.Anchor = AnchorStyles.None;
            pnlArchived.BorderColor = Color.FromArgb(39, 39, 42);
            pnlArchived.BorderThickness = 1F;
            pnlArchived.Controls.Add(lblArchived);
            pnlArchived.Controls.Add(rbArchived);
            pnlArchived.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlArchived.Location = new Point(151, 218);
            pnlArchived.Margin = new Padding(5);
            pnlArchived.Name = "pnlArchived";
            pnlArchived.Padding = new Padding(5);
            pnlArchived.Size = new Size(355, 41);
            pnlArchived.TabIndex = 23;
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Left;
            lblArchived.AutoSize = true;
            lblArchived.Font = new Font("Bahnschrift", 14F);
            lblArchived.ForeColor = Color.White;
            lblArchived.Location = new Point(10, 10);
            lblArchived.Margin = new Padding(5);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(85, 23);
            lblArchived.TabIndex = 12;
            lblArchived.Text = "Archived";
            // 
            // rbArchived
            // 
            rbArchived.Anchor = AnchorStyles.Left;
            rbArchived.BorderThickness = 1.7F;
            rbArchived.CheckColor = Color.White;
            rbArchived.Checked = true;
            rbArchived.CheckRadius = 4.99999952F;
            rbArchived.ForeColor = Color.White;
            rbArchived.Location = new Point(328, 12);
            rbArchived.Margin = new Padding(5);
            rbArchived.Name = "rbArchived";
            rbArchived.Size = new Size(17, 17);
            rbArchived.TabIndex = 0;
            rbArchived.Text = "customRadioButton1";
            // 
            // lblNameError
            // 
            lblNameError.Anchor = AnchorStyles.None;
            lblNameError.Font = new Font("Bahnschrift", 12F);
            lblNameError.ForeColor = Color.FromArgb(168, 171, 174);
            lblNameError.Location = new Point(149, 175);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(355, 38);
            lblNameError.TabIndex = 24;
            lblNameError.TextAlign = ContentAlignment.TopCenter;
            // 
            // ManageCustomerPersonalDetailsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(lblNameError);
            Controls.Add(pnlArchived);
            Controls.Add(tbForename);
            Controls.Add(tbSurname);
            Controls.Add(lblSurnameTitle);
            Controls.Add(lblForenameTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomerPersonalDetailsView";
            Text = "Personal Details";
            pnlArchived.ResumeLayout(false);
            pnlArchived.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomTextBox tbForename;
        private CustomControls.CustomTextBox tbSurname;
        private Label lblSurnameTitle;
        private Label lblForenameTitle;
        private CustomControls.CustomPanel pnlArchived;
        private Label lblArchived;
        private CustomControls.CustomRadioButton rbArchived;
        private Label lblNameError;
    }
}