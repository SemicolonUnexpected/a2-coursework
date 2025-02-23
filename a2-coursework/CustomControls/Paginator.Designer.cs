namespace a2_coursework.CustomControls {
    partial class Paginator {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            pnlInfo = new Panel();
            lblGoToPage = new Label();
            tbPage = new CustomControls.CustomTextBox();
            lblNumber = new Label();
            btnFirst = new CustomControls.CustomButton();
            btnPrevious = new CustomControls.CustomButton();
            btnNext = new CustomControls.CustomButton();
            btnLast = new CustomControls.CustomButton();
            toolTip = new ToolTip(components);
            tbFocusHolder = new TextBox();
            pnlLeftSpacer = new Panel();
            pnlRightSpacer = new Panel();
            pnlInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInfo
            // 
            pnlInfo.Anchor = AnchorStyles.None;
            pnlInfo.Controls.Add(lblGoToPage);
            pnlInfo.Controls.Add(tbPage);
            pnlInfo.Controls.Add(lblNumber);
            pnlInfo.Location = new Point(233, 2);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(206, 40);
            pnlInfo.TabIndex = 29;
            // 
            // lblGoToPage
            // 
            lblGoToPage.Anchor = AnchorStyles.None;
            lblGoToPage.AutoSize = true;
            lblGoToPage.Font = new Font("Bahnschrift", 14F);
            lblGoToPage.ForeColor = Color.White;
            lblGoToPage.Location = new Point(0, 9);
            lblGoToPage.Margin = new Padding(0, 0, 5, 0);
            lblGoToPage.Name = "lblGoToPage";
            lblGoToPage.Size = new Size(52, 23);
            lblGoToPage.TabIndex = 23;
            lblGoToPage.Text = "Page";
            // 
            // tbPage
            // 
            tbPage.Anchor = AnchorStyles.None;
            tbPage.BackColor = Color.FromArgb(9, 9, 10);
            tbPage.BorderColor = Color.FromArgb(39, 39, 42);
            tbPage.BorderThickness = 1F;
            tbPage.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbPage.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPage.ForeColor = Color.FromArgb(250, 250, 250);
            tbPage.HoverColor = Color.Empty;
            tbPage.Location = new Point(60, 0);
            tbPage.Margin = new Padding(5, 0, 5, 0);
            tbPage.MaxLength = 32767;
            tbPage.MultiLine = false;
            tbPage.Name = "tbPage";
            tbPage.PlaceholderText = "";
            tbPage.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbPage.ReadOnly = false;
            tbPage.Size = new Size(55, 40);
            tbPage.TabIndex = 2;
            tbPage.Text = "1";
            tbPage.TextAlign = HorizontalAlignment.Center;
            tbPage.TextBoxInset = new Padding(10);
            tbPage.UsePasswordChar = false;
            tbPage.Leave += tbPage_Leave;
            // 
            // lblNumber
            // 
            lblNumber.Anchor = AnchorStyles.None;
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Bahnschrift", 14F);
            lblNumber.ForeColor = Color.White;
            lblNumber.Location = new Point(125, 9);
            lblNumber.Margin = new Padding(5, 0, 0, 0);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(72, 23);
            lblNumber.TabIndex = 23;
            lblNumber.Text = "of 6345";
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.FromArgb(9, 9, 10);
            btnFirst.BorderColor = Color.FromArgb(39, 39, 42);
            btnFirst.BorderThickness = 1F;
            btnFirst.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnFirst.ClickedColor = Color.FromArgb(39, 39, 42);
            btnFirst.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnFirst.DisabledBorderColor = Color.Empty;
            btnFirst.DisabledColor = Color.Empty;
            btnFirst.Dock = DockStyle.Left;
            btnFirst.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFirst.ForeColor = Color.White;
            btnFirst.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnFirst.HoverColor = Color.FromArgb(39, 39, 42);
            btnFirst.Image = Properties.Resources.chevrons_left_light;
            btnFirst.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnFirst.Location = new Point(2, 2);
            btnFirst.Margin = new Padding(0, 0, 5, 0);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(40, 40);
            btnFirst.TabIndex = 25;
            btnFirst.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnFirst.TextPosition = new Point(20, 20);
            toolTip.SetToolTip(btnFirst, "First page");
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(9, 9, 10);
            btnPrevious.BorderColor = Color.FromArgb(39, 39, 42);
            btnPrevious.BorderThickness = 1F;
            btnPrevious.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnPrevious.ClickedColor = Color.FromArgb(39, 39, 42);
            btnPrevious.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnPrevious.DisabledBorderColor = Color.Empty;
            btnPrevious.DisabledColor = Color.Empty;
            btnPrevious.Dock = DockStyle.Left;
            btnPrevious.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnPrevious.HoverColor = Color.FromArgb(39, 39, 42);
            btnPrevious.Image = Properties.Resources.chevron_left_light;
            btnPrevious.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnPrevious.Location = new Point(47, 2);
            btnPrevious.Margin = new Padding(0);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(40, 40);
            btnPrevious.TabIndex = 26;
            btnPrevious.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnPrevious.TextPosition = new Point(20, 20);
            toolTip.SetToolTip(btnPrevious, "Previous page");
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(9, 9, 10);
            btnNext.BorderColor = Color.FromArgb(39, 39, 42);
            btnNext.BorderThickness = 1F;
            btnNext.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnNext.ClickedColor = Color.FromArgb(39, 39, 42);
            btnNext.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnNext.DisabledBorderColor = Color.Empty;
            btnNext.DisabledColor = Color.Empty;
            btnNext.Dock = DockStyle.Right;
            btnNext.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnNext.HoverColor = Color.FromArgb(39, 39, 42);
            btnNext.Image = Properties.Resources.chevron_right_light;
            btnNext.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnNext.Location = new Point(585, 2);
            btnNext.Margin = new Padding(0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 40);
            btnNext.TabIndex = 27;
            btnNext.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnNext.TextPosition = new Point(20, 20);
            toolTip.SetToolTip(btnNext, "Next page");
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.FromArgb(9, 9, 10);
            btnLast.BorderColor = Color.FromArgb(39, 39, 42);
            btnLast.BorderThickness = 1F;
            btnLast.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnLast.ClickedColor = Color.FromArgb(39, 39, 42);
            btnLast.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnLast.DisabledBorderColor = Color.Empty;
            btnLast.DisabledColor = Color.Empty;
            btnLast.Dock = DockStyle.Right;
            btnLast.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLast.ForeColor = Color.White;
            btnLast.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnLast.HoverColor = Color.FromArgb(39, 39, 42);
            btnLast.Image = Properties.Resources.chevrons_right_light;
            btnLast.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnLast.Location = new Point(630, 2);
            btnLast.Margin = new Padding(5, 0, 0, 0);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(40, 40);
            btnLast.TabIndex = 28;
            btnLast.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnLast.TextPosition = new Point(20, 20);
            toolTip.SetToolTip(btnLast, "Last page");
            btnLast.Click += btnLast_Click;
            // 
            // tbFocusHolder
            // 
            tbFocusHolder.Location = new Point(0, 0);
            tbFocusHolder.Name = "tbFocusHolder";
            tbFocusHolder.Size = new Size(0, 23);
            tbFocusHolder.TabIndex = 30;
            // 
            // pnlLeftSpacer
            // 
            pnlLeftSpacer.Dock = DockStyle.Left;
            pnlLeftSpacer.Location = new Point(42, 2);
            pnlLeftSpacer.Name = "pnlLeftSpacer";
            pnlLeftSpacer.Size = new Size(5, 40);
            pnlLeftSpacer.TabIndex = 31;
            // 
            // pnlRightSpacer
            // 
            pnlRightSpacer.Dock = DockStyle.Right;
            pnlRightSpacer.Location = new Point(625, 2);
            pnlRightSpacer.Name = "pnlRightSpacer";
            pnlRightSpacer.Size = new Size(5, 40);
            pnlRightSpacer.TabIndex = 32;
            // 
            // Paginator
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(btnPrevious);
            Controls.Add(pnlLeftSpacer);
            Controls.Add(tbFocusHolder);
            Controls.Add(pnlInfo);
            Controls.Add(btnFirst);
            Controls.Add(btnNext);
            Controls.Add(pnlRightSpacer);
            Controls.Add(btnLast);
            Name = "Paginator";
            Padding = new Padding(2);
            Size = new Size(672, 44);
            Click += Paginator_Click;
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlInfo;
        private Label lblGoToPage;
        private CustomControls.CustomTextBox tbPage;
        private Label lblNumber;
        private CustomControls.CustomButton btnFirst;
        private CustomControls.CustomButton btnPrevious;
        private CustomControls.CustomButton btnNext;
        private CustomControls.CustomButton btnLast;
        private ToolTip toolTip;
        private TextBox tbFocusHolder;
        private Panel pnlLeftSpacer;
        private Panel pnlRightSpacer;
    }
}
