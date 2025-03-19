namespace a2_coursework.User_Controls.DataGrid {
    partial class ApproveSearchBar {
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
            tbSearch = new a2_coursework.CustomControls.CustomTextBox();
            pbSearchBtn = new PictureBox();
            pnlSpacer1 = new Panel();
            btnApprove = new a2_coursework.CustomControls.CustomButton();
            btnReject = new a2_coursework.CustomControls.CustomButton();
            pnlSpacer3 = new Panel();
            btnView = new a2_coursework.CustomControls.CustomButton();
            pnlSpacer2 = new Panel();
            toolTip = new ToolTip(components);
            btnClear = new a2_coursework.CustomControls.CustomButton();
            pnlSpacer4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbSearchBtn).BeginInit();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(9, 9, 10);
            tbSearch.BorderColor = Color.FromArgb(39, 39, 42);
            tbSearch.BorderThickness = 1F;
            tbSearch.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbSearch.Dock = DockStyle.Fill;
            tbSearch.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.ForeColor = Color.FromArgb(250, 250, 250);
            tbSearch.HoverColor = Color.Empty;
            tbSearch.Location = new Point(2, 2);
            tbSearch.MaxLength = 32767;
            tbSearch.MultiLine = false;
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search";
            tbSearch.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSearch.ReadOnly = false;
            tbSearch.Size = new Size(489, 40);
            tbSearch.TabIndex = 8;
            tbSearch.TextAlign = HorizontalAlignment.Left;
            tbSearch.TextBoxInset = new Padding(45, 10, 45, 10);
            tbSearch.ToolTipText = "Press enter to search";
            tbSearch.UsePasswordChar = false;
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // pbSearchBtn
            // 
            pbSearchBtn.Image = Properties.Resources.search_light;
            pbSearchBtn.Location = new Point(10, 9);
            pbSearchBtn.Name = "pbSearchBtn";
            pbSearchBtn.Size = new Size(27, 27);
            pbSearchBtn.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearchBtn.TabIndex = 1;
            pbSearchBtn.TabStop = false;
            toolTip.SetToolTip(pbSearchBtn, "Click to search");
            pbSearchBtn.Click += pbSearchBtn_Click;
            // 
            // pnlSpacer1
            // 
            pnlSpacer1.Dock = DockStyle.Right;
            pnlSpacer1.Location = new Point(491, 2);
            pnlSpacer1.Name = "pnlSpacer1";
            pnlSpacer1.Size = new Size(5, 40);
            pnlSpacer1.TabIndex = 15;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(9, 9, 10);
            btnApprove.BorderColor = Color.FromArgb(39, 39, 42);
            btnApprove.BorderThickness = 1F;
            btnApprove.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnApprove.ClickedColor = Color.FromArgb(39, 39, 42);
            btnApprove.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnApprove.DisabledBorderColor = Color.Empty;
            btnApprove.DisabledColor = Color.Empty;
            btnApprove.Dock = DockStyle.Right;
            btnApprove.ForeColor = Color.FromArgb(250, 250, 250);
            btnApprove.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnApprove.HoverColor = Color.FromArgb(39, 39, 42);
            btnApprove.Image = Properties.Resources.check_light;
            btnApprove.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnApprove.Location = new Point(496, 2);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(40, 40);
            btnApprove.TabIndex = 14;
            btnApprove.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnApprove.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnApprove, "Add");
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(9, 9, 10);
            btnReject.BackgroundImage = Properties.Resources.chevron_right_light;
            btnReject.BorderColor = Color.FromArgb(39, 39, 42);
            btnReject.BorderThickness = 1F;
            btnReject.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnReject.ClickedColor = Color.FromArgb(39, 39, 42);
            btnReject.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnReject.DisabledBorderColor = Color.Empty;
            btnReject.DisabledColor = Color.Empty;
            btnReject.Dock = DockStyle.Right;
            btnReject.ForeColor = Color.FromArgb(250, 250, 250);
            btnReject.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnReject.HoverColor = Color.FromArgb(39, 39, 42);
            btnReject.Image = Properties.Resources.cross_light;
            btnReject.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnReject.Location = new Point(541, 2);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(40, 40);
            btnReject.TabIndex = 13;
            btnReject.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnReject.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnReject, "Edit");
            btnReject.Click += btnReject_Click;
            // 
            // pnlSpacer3
            // 
            pnlSpacer3.Dock = DockStyle.Right;
            pnlSpacer3.Location = new Point(581, 2);
            pnlSpacer3.Name = "pnlSpacer3";
            pnlSpacer3.Size = new Size(5, 40);
            pnlSpacer3.TabIndex = 12;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(9, 9, 10);
            btnView.BorderColor = Color.FromArgb(39, 39, 42);
            btnView.BorderThickness = 1F;
            btnView.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnView.ClickedColor = Color.FromArgb(39, 39, 42);
            btnView.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnView.DisabledBorderColor = Color.Empty;
            btnView.DisabledColor = Color.Empty;
            btnView.Dock = DockStyle.Right;
            btnView.ForeColor = Color.FromArgb(250, 250, 250);
            btnView.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnView.HoverColor = Color.FromArgb(39, 39, 42);
            btnView.Image = Properties.Resources.eye_light;
            btnView.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnView.Location = new Point(586, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(40, 40);
            btnView.TabIndex = 11;
            btnView.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnView.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnView, "Archive");
            btnView.Click += btnView_Click;
            // 
            // pnlSpacer2
            // 
            pnlSpacer2.Dock = DockStyle.Right;
            pnlSpacer2.Location = new Point(536, 2);
            pnlSpacer2.Name = "pnlSpacer2";
            pnlSpacer2.Size = new Size(5, 40);
            pnlSpacer2.TabIndex = 9;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(9, 9, 10);
            btnClear.BorderColor = Color.FromArgb(39, 39, 42);
            btnClear.BorderThickness = 0F;
            btnClear.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnClear.ClickedColor = Color.FromArgb(39, 39, 42);
            btnClear.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(15F, 15F, 15F, 15F);
            btnClear.DisabledBorderColor = Color.Empty;
            btnClear.DisabledColor = Color.Empty;
            btnClear.ForeColor = Color.FromArgb(250, 250, 250);
            btnClear.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnClear.HoverColor = Color.FromArgb(39, 39, 42);
            btnClear.Image = Properties.Resources.cross_light;
            btnClear.ImageRectangle = new Rectangle(3, 3, 24, 24);
            btnClear.Location = new Point(455, 7);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(30, 30);
            btnClear.TabIndex = 16;
            btnClear.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnClear.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnClear, "Clear search");
            btnClear.Visible = false;
            btnClear.Click += btnClear_Click;
            // 
            // pnlSpacer4
            // 
            pnlSpacer4.Dock = DockStyle.Right;
            pnlSpacer4.Location = new Point(626, 2);
            pnlSpacer4.Name = "pnlSpacer4";
            pnlSpacer4.Size = new Size(5, 40);
            pnlSpacer4.TabIndex = 18;
            // 
            // ApproveSearchBar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(btnClear);
            Controls.Add(pbSearchBtn);
            Controls.Add(tbSearch);
            Controls.Add(pnlSpacer1);
            Controls.Add(btnApprove);
            Controls.Add(pnlSpacer2);
            Controls.Add(btnReject);
            Controls.Add(pnlSpacer3);
            Controls.Add(btnView);
            Controls.Add(pnlSpacer4);
            Name = "ApproveSearchBar";
            Padding = new Padding(2);
            Size = new Size(633, 44);
            ((System.ComponentModel.ISupportInitialize)pbSearchBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomTextBox tbSearch;
        private Panel pnlSpacer1;
        private CustomControls.CustomButton btnApprove;
        private CustomControls.CustomButton btnReject;
        private Panel pnlSpacer3;
        private CustomControls.CustomButton btnView;
        private Panel pnlSpacer2;
        private PictureBox pbSearchBtn;
        private ToolTip toolTip;
        private CustomControls.CustomButton btnClear;
        private Panel pnlSpacer4;
    }
}
