﻿namespace a2_coursework.User_Controls.DataGrid {
    partial class ViewArchivedSearchBar {
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
            btnView = new CustomControls.CustomButton();
            pnlSpacer1 = new Panel();
            toolTip = new ToolTip(components);
            btnClear = new CustomControls.CustomButton();
            btnShowArchived = new CustomControls.CustomButton();
            pnlSpacer2 = new Panel();
            tbSearch = new CustomControls.CustomTextBox();
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
            btnView.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnView.DisabledBorderColor = Color.Empty;
            btnView.DisabledColor = Color.Empty;
            btnView.Dock = DockStyle.Right;
            btnView.ForeColor = Color.FromArgb(250, 250, 250);
            btnView.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnView.HoverColor = Color.FromArgb(39, 39, 42);
            btnView.Image = Properties.Resources.eye_light;
            btnView.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnView.Location = new Point(546, 2);
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
            pnlSpacer1.Location = new Point(541, 2);
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
            btnClear.CornerRadii = new CustomControls.CornerRadiiF(15F, 15F, 15F, 15F);
            btnClear.DisabledBorderColor = Color.Empty;
            btnClear.DisabledColor = Color.Empty;
            btnClear.ForeColor = Color.FromArgb(250, 250, 250);
            btnClear.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnClear.HoverColor = Color.FromArgb(39, 39, 42);
            btnClear.Image = Properties.Resources.cross_light;
            btnClear.ImageRectangle = new Rectangle(3, 3, 24, 24);
            btnClear.Location = new Point(505, 7);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(30, 30);
            btnClear.TabIndex = 16;
            btnClear.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnClear.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnClear, "Clear search");
            btnClear.Visible = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnShowArchived
            // 
            btnShowArchived.BackColor = Color.FromArgb(9, 9, 10);
            btnShowArchived.BorderColor = Color.FromArgb(39, 39, 42);
            btnShowArchived.BorderThickness = 1F;
            btnShowArchived.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnShowArchived.ClickedColor = Color.FromArgb(39, 39, 42);
            btnShowArchived.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnShowArchived.DisabledBorderColor = Color.Empty;
            btnShowArchived.DisabledColor = Color.Empty;
            btnShowArchived.Dock = DockStyle.Right;
            btnShowArchived.ForeColor = Color.FromArgb(250, 250, 250);
            btnShowArchived.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnShowArchived.HoverColor = Color.FromArgb(39, 39, 42);
            btnShowArchived.Image = Properties.Resources.package_open_light;
            btnShowArchived.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnShowArchived.Location = new Point(591, 2);
            btnShowArchived.Name = "btnShowArchived";
            btnShowArchived.Size = new Size(40, 40);
            btnShowArchived.TabIndex = 17;
            btnShowArchived.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnShowArchived.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnShowArchived, "Show archived");
            btnShowArchived.Click += btnShowArchived_Click;
            // 
            // pnlSpacer2
            // 
            pnlSpacer2.Dock = DockStyle.Right;
            pnlSpacer2.Location = new Point(586, 2);
            pnlSpacer2.Name = "pnlSpacer2";
            pnlSpacer2.Size = new Size(5, 40);
            pnlSpacer2.TabIndex = 18;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(9, 9, 10);
            tbSearch.BorderColor = Color.FromArgb(39, 39, 42);
            tbSearch.BorderThickness = 1F;
            tbSearch.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
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
            tbSearch.Size = new Size(539, 40);
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
            Controls.Add(pnlSpacer2);
            Controls.Add(btnShowArchived);
            Name = "ViewSearchBar";
            Padding = new Padding(2);
            Size = new Size(633, 44);
            ((System.ComponentModel.ISupportInitialize)pbSearchBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSpacer1;
        private CustomControls.CustomButton btnView;
        private Panel pnlSpacer2;
        private CustomControls.CustomTextBox tbSearch;
        private PictureBox pbSearchBtn;
        private ToolTip toolTip;
        private CustomControls.CustomButton btnClear;
        private CustomControls.CustomButton btnShowArchived;
    }
}
