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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlData = new CustomControls.CustomPanel();
            dataGridView = new DataGridView();
            rbDarkMode = new CustomControls.CustomRadioButton();
            lblStock = new Label();
            paginator = new CustomControls.Paginator();
            topBar = new User_Controls.DataGrid.AddEditArchiveSearchBar();
            columnID = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnSKU = new DataGridViewTextBoxColumn();
            columnQuantity = new DataGridViewTextBoxColumn();
            columnQuantityLevel = new DataGridViewTextBoxColumn();
            columnArchived = new DataGridViewTextBoxColumn();
            lblStockResult = new Label();
            pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // pnlData
            // 
            pnlData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlData.BorderColor = Color.FromArgb(39, 39, 42);
            pnlData.BorderThickness = 1F;
            pnlData.Controls.Add(lblStockResult);
            pnlData.Controls.Add(dataGridView);
            pnlData.Controls.Add(rbDarkMode);
            pnlData.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlData.Location = new Point(14, 123);
            pnlData.Margin = new Padding(5);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(5);
            pnlData.Size = new Size(621, 309);
            pnlData.TabIndex = 4;
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
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle6.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.ColumnHeadersHeight = 30;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { columnID, columnName, columnSKU, columnQuantity, columnQuantityLevel, columnArchived });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle9.Font = new Font("Bahnschrift", 10F);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(611, 299);
            dataGridView.TabIndex = 1;
            dataGridView.VirtualMode = true;
            // 
            // rbDarkMode
            // 
            rbDarkMode.Anchor = AnchorStyles.Right;
            rbDarkMode.BorderThickness = 1.7F;
            rbDarkMode.CheckColor = Color.White;
            rbDarkMode.Checked = true;
            rbDarkMode.CheckRadius = 5F;
            rbDarkMode.ForeColor = Color.White;
            rbDarkMode.Location = new Point(1160, 507);
            rbDarkMode.Margin = new Padding(5);
            rbDarkMode.Name = "rbDarkMode";
            rbDarkMode.Size = new Size(17, 17);
            rbDarkMode.TabIndex = 0;
            rbDarkMode.Text = "customRadioButton1";
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.Top;
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Bahnschrift", 24F);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(276, 19);
            lblStock.Margin = new Padding(10);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(97, 39);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            // 
            // paginator
            // 
            paginator.Anchor = AnchorStyles.Bottom;
            paginator.BackColor = Color.FromArgb(9, 9, 10);
            paginator.CurrentPage = 0;
            paginator.Location = new Point(44, 444);
            paginator.Name = "paginator";
            paginator.NumberOfPages = 20;
            paginator.Padding = new Padding(0, 2, 0, 2);
            paginator.Size = new Size(561, 44);
            paginator.TabIndex = 10;
            // 
            // topBar
            // 
            topBar.AddEnabled = true;
            topBar.Anchor = AnchorStyles.Top;
            topBar.ArchiveEnabled = true;
            topBar.BackColor = Color.FromArgb(9, 9, 10);
            topBar.EditEnabled = true;
            topBar.Location = new Point(19, 78);
            topBar.Name = "topBar";
            topBar.Padding = new Padding(0, 2, 0, 2);
            topBar.SearchText = "";
            topBar.Size = new Size(611, 44);
            topBar.TabIndex = 11;
            // 
            // columnID
            // 
            columnID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnID.HeaderText = "ID";
            columnID.Name = "columnID";
            columnID.Width = 40;
            // 
            // columnName
            // 
            columnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnName.DefaultCellStyle = dataGridViewCellStyle7;
            columnName.HeaderText = "Name";
            columnName.Name = "columnName";
            // 
            // columnSKU
            // 
            columnSKU.HeaderText = "SKU";
            columnSKU.Name = "columnSKU";
            columnSKU.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnQuantity
            // 
            columnQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnQuantity.HeaderText = "Quantity";
            columnQuantity.Name = "columnQuantity";
            columnQuantity.Width = 90;
            // 
            // columnQuantityLevel
            // 
            columnQuantityLevel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnQuantityLevel.HeaderText = "Quantity Level";
            columnQuantityLevel.Name = "columnQuantityLevel";
            columnQuantityLevel.SortMode = DataGridViewColumnSortMode.Programmatic;
            columnQuantityLevel.Width = 120;
            // 
            // columnArchived
            // 
            columnArchived.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.TopRight;
            columnArchived.DefaultCellStyle = dataGridViewCellStyle8;
            columnArchived.HeaderText = "Archived";
            columnArchived.Name = "columnArchived";
            columnArchived.Width = 90;
            // 
            // lblStockResult
            // 
            lblStockResult.Anchor = AnchorStyles.Top;
            lblStockResult.Font = new Font("Bahnschrift", 20F);
            lblStockResult.ForeColor = Color.FromArgb(168, 171, 174);
            lblStockResult.Location = new Point(5, 103);
            lblStockResult.Margin = new Padding(10, 0, 10, 20);
            lblStockResult.Name = "lblStockResult";
            lblStockResult.Size = new Size(611, 103);
            lblStockResult.TabIndex = 26;
            lblStockResult.Text = "No items to display";
            lblStockResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StockDisplayView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(649, 500);
            Controls.Add(topBar);
            Controls.Add(paginator);
            Controls.Add(lblStock);
            Controls.Add(pnlData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockDisplayView";
            Text = "StockDisplayView";
            Load += StockDisplayView_Load;
            pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnlData;
        private CustomControls.CustomRadioButton rbDarkMode;
        private Label lblStock;
        private CustomControls.Paginator paginator;
        private User_Controls.DataGrid.AddEditArchiveSearchBar topBar;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn columnID;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnSKU;
        private DataGridViewTextBoxColumn columnQuantity;
        private DataGridViewTextBoxColumn columnQuantityLevel;
        private DataGridViewTextBoxColumn columnArchived;
        private Label lblStockResult;
    }
}