namespace a2_coursework.View {
    partial class StockDisplayView {
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlData = new CustomControls.CustomPanel();
            lblError = new Label();
            dataGridView = new DataGridView();
            sb = new CustomControls.CustomScrollBar();
            lblStock = new Label();
            topBar = new User_Controls.DataGrid.AddEditArchiveSearchBar();
            columnID = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnSKU = new DataGridViewTextBoxColumn();
            columnQuantity = new DataGridViewTextBoxColumn();
            columnQuantityLevel = new DataGridViewTextBoxColumn();
            columnArchived = new DataGridViewTextBoxColumn();
            pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
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
            pnlData.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlData.Location = new Point(14, 127);
            pnlData.Margin = new Padding(5);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(5);
            pnlData.Size = new Size(621, 359);
            pnlData.TabIndex = 4;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top;
            lblError.Font = new Font("Bahnschrift", 20F);
            lblError.ForeColor = Color.FromArgb(168, 171, 174);
            lblError.Location = new Point(5, 134);
            lblError.Margin = new Padding(10, 0, 10, 20);
            lblError.Name = "lblError";
            lblError.Size = new Size(611, 103);
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
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 60;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { columnID, columnName, columnSKU, columnQuantity, columnQuantityLevel, columnArchived });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle4.Font = new Font("Bahnschrift", 10F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(39, 39, 42);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowTemplate.Height = 30;
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(601, 349);
            dataGridView.TabIndex = 1;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.Resize += dataGridView_Resize;
            // 
            // sb
            // 
            sb.BackColor = Color.FromArgb(9, 9, 10);
            sb.Dock = DockStyle.Right;
            sb.LargeChange = 50;
            sb.Location = new Point(606, 5);
            sb.Maximum = 100;
            sb.Minimum = 0;
            sb.MinimumThumbHeight = 30;
            sb.Name = "sb";
            sb.Padding = new Padding(2);
            sb.Size = new Size(10, 349);
            sb.SmallChange = 10;
            sb.TabIndex = 28;
            sb.Text = "customScrollBar1";
            sb.ThumbClickedColor = Color.FromArgb(39, 39, 42);
            sb.ThumbColor = Color.FromArgb(39, 39, 42);
            sb.ThumbCorderRadii = new CustomControls.CornerRadiiF(3F, 3F, 3F, 3F);
            sb.ThumbHoverColor = Color.FromArgb(39, 39, 42);
            sb.Visible = false;
            sb.ValueChanged += sb_ValueChanged;
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.Top;
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Bahnschrift", 24F);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(276, 23);
            lblStock.Margin = new Padding(10);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(97, 39);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            // 
            // topBar
            // 
            topBar.AddEnabled = true;
            topBar.Anchor = AnchorStyles.Top;
            topBar.ArchiveEnabled = true;
            topBar.BackColor = Color.FromArgb(9, 9, 10);
            topBar.EditEnabled = true;
            topBar.Location = new Point(12, 75);
            topBar.Name = "topBar";
            topBar.Padding = new Padding(0, 2, 0, 2);
            topBar.SearchEnabled = true;
            topBar.SearchText = "";
            topBar.ShowArchivedEnabled = true;
            topBar.Size = new Size(625, 44);
            topBar.TabIndex = 11;
            // 
            // columnID
            // 
            columnID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnID.HeaderText = "ID";
            columnID.Name = "columnID";
            columnID.Width = 47;
            // 
            // columnName
            // 
            columnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnName.DefaultCellStyle = dataGridViewCellStyle2;
            columnName.HeaderText = "Name";
            columnName.Name = "columnName";
            // 
            // columnSKU
            // 
            columnSKU.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnSKU.HeaderText = "SKU";
            columnSKU.Name = "columnSKU";
            columnSKU.Width = 62;
            // 
            // columnQuantity
            // 
            columnQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnQuantity.HeaderText = "Quantity";
            columnQuantity.Name = "columnQuantity";
            columnQuantity.Width = 92;
            // 
            // columnQuantityLevel
            // 
            columnQuantityLevel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnQuantityLevel.HeaderText = "Quantity Level";
            columnQuantityLevel.Name = "columnQuantityLevel";
            columnQuantityLevel.SortMode = DataGridViewColumnSortMode.Programmatic;
            columnQuantityLevel.Width = 124;
            // 
            // columnArchived
            // 
            columnArchived.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnArchived.DataPropertyName = "IsArchived";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopRight;
            columnArchived.DefaultCellStyle = dataGridViewCellStyle3;
            columnArchived.HeaderText = "Archived";
            columnArchived.Name = "columnArchived";
            columnArchived.Width = 96;
            // 
            // StockDisplayView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(649, 500);
            Controls.Add(topBar);
            Controls.Add(lblStock);
            Controls.Add(pnlData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockDisplayView";
            Text = "StockDisplayView";
            pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnlData;
        private Label lblStock;
        private User_Controls.DataGrid.AddEditArchiveSearchBar topBar;
        private DataGridView dataGridView;
        private Label lblError;
        private CustomControls.CustomScrollBar sb;
        private DataGridViewTextBoxColumn columnID;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnSKU;
        private DataGridViewTextBoxColumn columnQuantity;
        private DataGridViewTextBoxColumn columnQuantityLevel;
        private DataGridViewTextBoxColumn columnArchived;
    }
}