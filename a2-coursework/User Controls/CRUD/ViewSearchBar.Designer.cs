namespace a2_coursework.User_Controls.DataGrid {
    partial class ViewSearchBar {
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
            pbSearchBtn = new PictureBox();
            btnView = new a2_coursework.CustomControls.CustomButton();
            pnlSpacer1 = new Panel();
            toolTip = new ToolTip(components);
            btnClear = new a2_coursework.CustomControls.CustomButton();
            tbSearch = new a2_coursework.CustomControls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)pbSearchBtn).BeginInit();
            SuspendLayout();
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
            btnView.Location = new Point(591, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(40, 40);
            btnView.TabIndex = 11;
            btnView.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnView.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnView, "View");
            btnView.Click += btnView_Click;
            // 
            // pnlSpacer1
            // 
            pnlSpacer1.Dock = DockStyle.Right;
            pnlSpacer1.Location = new Point(586, 2);
            pnlSpacer1.Name = "pnlSpacer1";
            pnlSpacer1.Size = new Size(5, 40);
            pnlSpacer1.TabIndex = 9;
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
            btnClear.Location = new Point(550, 8);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(30, 30);
            btnClear.TabIndex = 16;
            btnClear.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnClear.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnClear, "Clear search");
            btnClear.Visible = false;
            btnClear.Click += btnClear_Click;
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
            tbSearch.Size = new Size(584, 40);
            tbSearch.TabIndex = 8;
            tbSearch.TextAlign = HorizontalAlignment.Left;
            tbSearch.TextBoxInset = new Padding(45, 10, 45, 10);
            tbSearch.ToolTipText = "Press enter to search";
            tbSearch.UsePasswordChar = false;
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // ViewSearchBar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(btnClear);
            Controls.Add(pbSearchBtn);
            Controls.Add(tbSearch);
            Controls.Add(pnlSpacer1);
            Controls.Add(btnView);
            Name = "ViewSearchBar";
            Padding = new Padding(2);
            Size = new Size(633, 44);
            ((System.ComponentModel.ISupportInitialize)pbSearchBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSpacer1;
        private CustomControls.CustomButton btnView;
        private CustomControls.CustomTextBox tbSearch;
        private PictureBox pbSearchBtn;
        private ToolTip toolTip;
        private CustomControls.CustomButton btnClear;
    }
}
