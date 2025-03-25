namespace a2_coursework.View.Order {
    partial class ManageCleaningJobOptionsView {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlData = new a2_coursework.CustomControls.CustomPanel();
            lblError = new Label();
            dataGridView = new DataGridView();
            columnId = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnUnitCost = new DataGridViewTextBoxColumn();
            sb = new a2_coursework.CustomControls.CustomScrollBar();
            searchBar = new a2_coursework.User_Controls.DataGrid.SearchBar();
            nudQuantity = new a2_coursework.CustomControls.CustomNumericUpDown();
            pnlDetails = new a2_coursework.CustomControls.CustomPanel();
            lblSubtotal = new Label();
            lblQuantity = new Label();
            tbDescription = new a2_coursework.CustomControls.CustomTextBox();
            lblDescription = new Label();
            lblName = new Label();
            tbSubtotal = new a2_coursework.CustomControls.CustomTextBox();
            tbName = new a2_coursework.CustomControls.CustomTextBox();
            tbQuantity = new a2_coursework.CustomControls.CustomTextBox();
            tbTotal = new a2_coursework.CustomControls.CustomTextBox();
            lblTotal = new Label();
            pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlData
            // 
            pnlData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlData.BorderColor = Color.FromArgb(39, 39, 42);
            pnlData.BorderThickness = 1F;
            pnlData.Controls.Add(lblError);
            pnlData.Controls.Add(dataGridView);
            pnlData.Controls.Add(sb);
            pnlData.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlData.Location = new Point(14, 64);
            pnlData.Margin = new Padding(5);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(5);
            pnlData.Size = new Size(347, 341);
            pnlData.TabIndex = 4;
            pnlData.Resize += pnlData_Resize;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top;
            lblError.Font = new Font("Bahnschrift", 20F);
            lblError.ForeColor = Color.FromArgb(168, 171, 174);
            lblError.Location = new Point(7, 135);
            lblError.Margin = new Padding(10, 0, 10, 20);
            lblError.Name = "lblError";
            lblError.Size = new Size(322, 103);
            lblError.TabIndex = 26;
            lblError.Text = "No items to display";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(9, 9, 10);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 60;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { columnId, columnName, columnUnitCost });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift", 10F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(39, 39, 42);
            dataGridView.Location = new Point(5, 5);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 30;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(39, 39, 42);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowTemplate.Height = 30;
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(327, 331);
            dataGridView.TabIndex = 1;
            dataGridView.ColumnHeaderMouseClick += dataGridView_ColumnHeaderMouseClick;
            dataGridView.Resize += dataGridView_Resize;
            // 
            // columnId
            // 
            columnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnId.HeaderText = "ID";
            columnId.Name = "columnId";
            columnId.SortMode = DataGridViewColumnSortMode.Programmatic;
            columnId.Width = 47;
            // 
            // columnName
            // 
            columnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnName.DefaultCellStyle = dataGridViewCellStyle2;
            columnName.HeaderText = "Name";
            columnName.Name = "columnName";
            columnName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnUnitCost
            // 
            columnUnitCost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnUnitCost.HeaderText = "Unit Cost";
            columnUnitCost.Name = "columnUnitCost";
            columnUnitCost.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // sb
            // 
            sb.BackColor = Color.FromArgb(9, 9, 10);
            sb.Dock = DockStyle.Right;
            sb.LargeChange = 50;
            sb.Location = new Point(332, 5);
            sb.Maximum = 100;
            sb.Minimum = 0;
            sb.MinimumThumbHeight = 30;
            sb.Name = "sb";
            sb.Padding = new Padding(2);
            sb.Size = new Size(10, 331);
            sb.SmallChange = 10;
            sb.TabIndex = 28;
            sb.Text = "customScrollBar1";
            sb.ThumbClickedColor = Color.FromArgb(39, 39, 42);
            sb.ThumbColor = Color.FromArgb(39, 39, 42);
            sb.ThumbCorderRadii = new a2_coursework.CustomControls.CornerRadiiF(3F, 3F, 3F, 3F);
            sb.ThumbHoverColor = Color.FromArgb(39, 39, 42);
            sb.Visible = false;
            sb.ValueChanged += sb_ValueChanged;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.FromArgb(9, 9, 10);
            searchBar.Location = new Point(14, 12);
            searchBar.Name = "searchBar";
            searchBar.Padding = new Padding(2);
            searchBar.SearchText = "";
            searchBar.Size = new Size(337, 44);
            searchBar.TabIndex = 10;
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.FromArgb(9, 9, 10);
            nudQuantity.Location = new Point(10, 239);
            nudQuantity.Maximum = 100;
            nudQuantity.Minimum = 1;
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(249, 40);
            nudQuantity.TabIndex = 11;
            nudQuantity.Value = 1;
            // 
            // pnlDetails
            // 
            pnlDetails.Anchor = AnchorStyles.Right;
            pnlDetails.BorderColor = Color.FromArgb(39, 39, 42);
            pnlDetails.BorderThickness = 1F;
            pnlDetails.Controls.Add(lblSubtotal);
            pnlDetails.Controls.Add(lblQuantity);
            pnlDetails.Controls.Add(tbDescription);
            pnlDetails.Controls.Add(lblDescription);
            pnlDetails.Controls.Add(lblName);
            pnlDetails.Controls.Add(tbSubtotal);
            pnlDetails.Controls.Add(tbName);
            pnlDetails.Controls.Add(nudQuantity);
            pnlDetails.Controls.Add(tbQuantity);
            pnlDetails.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlDetails.Location = new Point(371, 12);
            pnlDetails.Margin = new Padding(5);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Padding = new Padding(5);
            pnlDetails.Size = new Size(269, 344);
            pnlDetails.TabIndex = 12;
            pnlDetails.Resize += pnlDetails_Resize;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Bahnschrift", 14F);
            lblSubtotal.ForeColor = Color.White;
            lblSubtotal.Location = new Point(10, 303);
            lblSubtotal.Margin = new Padding(5);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(85, 23);
            lblSubtotal.TabIndex = 24;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Bahnschrift", 14F);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(10, 208);
            lblQuantity.Margin = new Padding(5);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(80, 23);
            lblQuantity.TabIndex = 24;
            lblQuantity.Text = "Quantity";
            // 
            // tbDescription
            // 
            tbDescription.BackColor = Color.FromArgb(9, 9, 10);
            tbDescription.BorderColor = Color.FromArgb(39, 39, 42);
            tbDescription.BorderThickness = 1F;
            tbDescription.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbDescription.Font = new Font("Bahnschrift", 12F);
            tbDescription.ForeColor = Color.Empty;
            tbDescription.HoverColor = Color.Empty;
            tbDescription.Location = new Point(10, 93);
            tbDescription.Margin = new Padding(5);
            tbDescription.MaximumSize = new Size(249, 105);
            tbDescription.MaxLength = 256;
            tbDescription.MultiLine = true;
            tbDescription.Name = "tbDescription";
            tbDescription.PlaceholderText = "";
            tbDescription.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbDescription.ReadOnly = true;
            tbDescription.Size = new Size(249, 105);
            tbDescription.TabIndex = 23;
            tbDescription.TextAlign = HorizontalAlignment.Left;
            tbDescription.TextBoxInset = new Padding(10);
            tbDescription.UsePasswordChar = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Bahnschrift", 14F);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(10, 60);
            lblDescription.Margin = new Padding(5);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(106, 23);
            lblDescription.TabIndex = 24;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 14F);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(10, 19);
            lblName.Margin = new Padding(5);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 23);
            lblName.TabIndex = 24;
            lblName.Text = "Name";
            // 
            // tbSubtotal
            // 
            tbSubtotal.BackColor = Color.FromArgb(9, 9, 10);
            tbSubtotal.BorderColor = Color.FromArgb(39, 39, 42);
            tbSubtotal.BorderThickness = 1F;
            tbSubtotal.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbSubtotal.Font = new Font("Bahnschrift", 12F);
            tbSubtotal.ForeColor = Color.Empty;
            tbSubtotal.HoverColor = Color.Empty;
            tbSubtotal.Location = new Point(101, 294);
            tbSubtotal.Margin = new Padding(5);
            tbSubtotal.MaximumSize = new Size(355, 79);
            tbSubtotal.MaxLength = 256;
            tbSubtotal.MultiLine = false;
            tbSubtotal.Name = "tbSubtotal";
            tbSubtotal.PlaceholderText = "";
            tbSubtotal.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSubtotal.ReadOnly = true;
            tbSubtotal.Size = new Size(158, 40);
            tbSubtotal.TabIndex = 23;
            tbSubtotal.TextAlign = HorizontalAlignment.Left;
            tbSubtotal.TextBoxInset = new Padding(10);
            tbSubtotal.UsePasswordChar = false;
            // 
            // tbName
            // 
            tbName.BackColor = Color.FromArgb(9, 9, 10);
            tbName.BorderColor = Color.FromArgb(39, 39, 42);
            tbName.BorderThickness = 1F;
            tbName.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbName.Font = new Font("Bahnschrift", 12F);
            tbName.ForeColor = Color.Empty;
            tbName.HoverColor = Color.Empty;
            tbName.Location = new Point(77, 10);
            tbName.Margin = new Padding(5);
            tbName.MaximumSize = new Size(355, 79);
            tbName.MaxLength = 256;
            tbName.MultiLine = false;
            tbName.Name = "tbName";
            tbName.PlaceholderText = "";
            tbName.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbName.ReadOnly = false;
            tbName.Size = new Size(182, 40);
            tbName.TabIndex = 23;
            tbName.TextAlign = HorizontalAlignment.Left;
            tbName.TextBoxInset = new Padding(10);
            tbName.UsePasswordChar = false;
            // 
            // tbQuantity
            // 
            tbQuantity.Anchor = AnchorStyles.Right;
            tbQuantity.BackColor = Color.FromArgb(9, 9, 10);
            tbQuantity.BorderColor = Color.FromArgb(39, 39, 42);
            tbQuantity.BorderThickness = 1F;
            tbQuantity.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbQuantity.Font = new Font("Bahnschrift", 12F);
            tbQuantity.ForeColor = Color.Empty;
            tbQuantity.HoverColor = Color.Empty;
            tbQuantity.Location = new Point(10, 239);
            tbQuantity.Margin = new Padding(5);
            tbQuantity.MaximumSize = new Size(355, 79);
            tbQuantity.MaxLength = 256;
            tbQuantity.MultiLine = false;
            tbQuantity.Name = "tbQuantity";
            tbQuantity.PlaceholderText = "";
            tbQuantity.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbQuantity.ReadOnly = true;
            tbQuantity.Size = new Size(249, 40);
            tbQuantity.TabIndex = 23;
            tbQuantity.TextAlign = HorizontalAlignment.Left;
            tbQuantity.TextBoxInset = new Padding(10);
            tbQuantity.UsePasswordChar = false;
            tbQuantity.Visible = false;
            // 
            // tbTotal
            // 
            tbTotal.Anchor = AnchorStyles.Right;
            tbTotal.BackColor = Color.FromArgb(9, 9, 10);
            tbTotal.BorderColor = Color.FromArgb(39, 39, 42);
            tbTotal.BorderThickness = 1F;
            tbTotal.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbTotal.Font = new Font("Bahnschrift", 12F);
            tbTotal.ForeColor = Color.Empty;
            tbTotal.HoverColor = Color.Empty;
            tbTotal.Location = new Point(472, 366);
            tbTotal.Margin = new Padding(5);
            tbTotal.MaximumSize = new Size(355, 79);
            tbTotal.MaxLength = 256;
            tbTotal.MultiLine = false;
            tbTotal.Name = "tbTotal";
            tbTotal.PlaceholderText = "";
            tbTotal.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(158, 40);
            tbTotal.TabIndex = 23;
            tbTotal.TextAlign = HorizontalAlignment.Left;
            tbTotal.TextBoxInset = new Padding(10);
            tbTotal.UsePasswordChar = false;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Bahnschrift", 14F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(386, 375);
            lblTotal.Margin = new Padding(5);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(54, 23);
            lblTotal.TabIndex = 24;
            lblTotal.Text = "Total:";
            // 
            // ManageCleaningJobOptionsView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(tbTotal);
            Controls.Add(searchBar);
            Controls.Add(lblTotal);
            Controls.Add(pnlData);
            Controls.Add(pnlDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCleaningJobOptionsView";
            Text = "Cleaning Job Option Quantities";
            pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnlData;
        private DataGridView dataGridView;
        private Label lblError;
        private CustomControls.CustomScrollBar sb;
        private User_Controls.DataGrid.SearchBar searchBar;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnUnitCost;
        private CustomControls.CustomNumericUpDown nudQuantity;
        private CustomControls.CustomPanel pnlDetails;
        private CustomControls.CustomTextBox tbTotal;
        private Label lblQuantity;
        private CustomControls.CustomTextBox tbDescription;
        private Label lblDescription;
        private Label lblName;
        private CustomControls.CustomTextBox tbName;
        private Label lblTotal;
        private Label lblSubtotal;
        private CustomControls.CustomTextBox tbSubtotal;
        private CustomControls.CustomTextBox tbQuantity;
    }
}