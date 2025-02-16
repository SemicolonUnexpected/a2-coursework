namespace a2_coursework.User_Controls.DataGrid {
    partial class AddEditArchiveSearchBar {
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
            tbSearch = new CustomControls.CustomTextBox();
            pbSearchBtn = new PictureBox();
            pnlSpacer1 = new Panel();
            btnAdd = new CustomControls.CustomButton();
            btnEdit = new CustomControls.CustomButton();
            pnlSpacer3 = new Panel();
            btnArchive = new CustomControls.CustomButton();
            pnlSpacer2 = new Panel();
            toolTip = new ToolTip(components);
            btnClear = new CustomControls.CustomButton();
            btnShowArchived = new CustomControls.CustomButton();
            pnlSpacer4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbSearchBtn).BeginInit();
            SuspendLayout();
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
            tbSearch.Size = new Size(449, 40);
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
            pnlSpacer1.Location = new Point(451, 2);
            pnlSpacer1.Name = "pnlSpacer1";
            pnlSpacer1.Size = new Size(5, 40);
            pnlSpacer1.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(9, 9, 10);
            btnAdd.BorderColor = Color.FromArgb(39, 39, 42);
            btnAdd.BorderThickness = 1F;
            btnAdd.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnAdd.ClickedColor = Color.FromArgb(39, 39, 42);
            btnAdd.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnAdd.DisabledBorderColor = Color.Empty;
            btnAdd.DisabledColor = Color.Empty;
            btnAdd.Dock = DockStyle.Right;
            btnAdd.ForeColor = Color.FromArgb(250, 250, 250);
            btnAdd.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnAdd.HoverColor = Color.FromArgb(39, 39, 42);
            btnAdd.Image = Properties.Resources.plus_light;
            btnAdd.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnAdd.Location = new Point(456, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(40, 40);
            btnAdd.TabIndex = 14;
            btnAdd.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnAdd.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnAdd, "Add");
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(9, 9, 10);
            btnEdit.BackgroundImage = Properties.Resources.chevron_right_light;
            btnEdit.BorderColor = Color.FromArgb(39, 39, 42);
            btnEdit.BorderThickness = 1F;
            btnEdit.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnEdit.ClickedColor = Color.FromArgb(39, 39, 42);
            btnEdit.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnEdit.DisabledBorderColor = Color.Empty;
            btnEdit.DisabledColor = Color.Empty;
            btnEdit.Dock = DockStyle.Right;
            btnEdit.ForeColor = Color.FromArgb(250, 250, 250);
            btnEdit.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnEdit.HoverColor = Color.FromArgb(39, 39, 42);
            btnEdit.Image = Properties.Resources.pencil_light;
            btnEdit.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnEdit.Location = new Point(501, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(40, 40);
            btnEdit.TabIndex = 13;
            btnEdit.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnEdit.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnEdit, "Edit");
            btnEdit.Click += btnEdit_Click;
            // 
            // pnlSpacer3
            // 
            pnlSpacer3.Dock = DockStyle.Right;
            pnlSpacer3.Location = new Point(541, 2);
            pnlSpacer3.Name = "pnlSpacer3";
            pnlSpacer3.Size = new Size(5, 40);
            pnlSpacer3.TabIndex = 12;
            // 
            // btnArchive
            // 
            btnArchive.BackColor = Color.FromArgb(9, 9, 10);
            btnArchive.BorderColor = Color.FromArgb(39, 39, 42);
            btnArchive.BorderThickness = 1F;
            btnArchive.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnArchive.ClickedColor = Color.FromArgb(39, 39, 42);
            btnArchive.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnArchive.DisabledBorderColor = Color.Empty;
            btnArchive.DisabledColor = Color.Empty;
            btnArchive.Dock = DockStyle.Right;
            btnArchive.ForeColor = Color.FromArgb(250, 250, 250);
            btnArchive.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnArchive.HoverColor = Color.FromArgb(39, 39, 42);
            btnArchive.Image = Properties.Resources.archive_restore_light;
            btnArchive.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnArchive.Location = new Point(546, 2);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(40, 40);
            btnArchive.TabIndex = 11;
            btnArchive.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnArchive.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnArchive, "Archive");
            btnArchive.Click += btnArchive_Click;
            // 
            // pnlSpacer2
            // 
            pnlSpacer2.Dock = DockStyle.Right;
            pnlSpacer2.Location = new Point(496, 2);
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
            btnClear.CornerRadii = new CustomControls.CornerRadiiF(15F, 15F, 15F, 15F);
            btnClear.DisabledBorderColor = Color.Empty;
            btnClear.DisabledColor = Color.Empty;
            btnClear.ForeColor = Color.FromArgb(250, 250, 250);
            btnClear.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnClear.HoverColor = Color.FromArgb(39, 39, 42);
            btnClear.Image = Properties.Resources.cross_light;
            btnClear.ImageRectangle = new Rectangle(3, 3, 24, 24);
            btnClear.Location = new Point(413, 8);
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
            // pnlSpacer4
            // 
            pnlSpacer4.Dock = DockStyle.Right;
            pnlSpacer4.Location = new Point(586, 2);
            pnlSpacer4.Name = "pnlSpacer4";
            pnlSpacer4.Size = new Size(5, 40);
            pnlSpacer4.TabIndex = 18;
            // 
            // AddEditArchiveSearchBar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(btnClear);
            Controls.Add(pbSearchBtn);
            Controls.Add(tbSearch);
            Controls.Add(pnlSpacer1);
            Controls.Add(btnAdd);
            Controls.Add(pnlSpacer2);
            Controls.Add(btnEdit);
            Controls.Add(pnlSpacer3);
            Controls.Add(btnArchive);
            Controls.Add(pnlSpacer4);
            Controls.Add(btnShowArchived);
            Name = "AddEditArchiveSearchBar";
            Padding = new Padding(2);
            Size = new Size(633, 44);
            ((System.ComponentModel.ISupportInitialize)pbSearchBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomTextBox tbSearch;
        private Panel pnlSpacer1;
        private CustomControls.CustomButton btnAdd;
        private CustomControls.CustomButton btnEdit;
        private Panel pnlSpacer3;
        private CustomControls.CustomButton btnArchive;
        private Panel pnlSpacer2;
        private PictureBox pbSearchBtn;
        private ToolTip toolTip;
        private CustomControls.CustomButton btnClear;
        private CustomControls.CustomButton btnShowArchived;
        private Panel pnlSpacer4;
    }
}
