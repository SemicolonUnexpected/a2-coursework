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
            dataGridView1 = new DataGridView();
            rbDarkMode = new CustomControls.CustomRadioButton();
            lblStock = new Label();
            paginator = new CustomControls.Paginator();
            topBar = new User_Controls.DataGrid.AddEditArchiveSearchBar();
            columnID = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnSKU = new DataGridViewTextBoxColumn();
            columnQuantity = new DataGridViewTextBoxColumn();
            columnStockHealth = new DataGridViewTextBoxColumn();
            columnArchived = new DataGridViewTextBoxColumn();
            pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlData
            // 
            pnlData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlData.BorderColor = Color.FromArgb(39, 39, 42);
            pnlData.BorderThickness = 1F;
            pnlData.Controls.Add(dataGridView1);
            pnlData.Controls.Add(rbDarkMode);
            pnlData.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlData.Location = new Point(14, 123);
            pnlData.Margin = new Padding(5);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(5);
            pnlData.Size = new Size(621, 309);
            pnlData.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(9, 9, 10);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columnID, columnName, columnSKU, columnQuantity, columnStockHealth, columnArchived });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle4.Font = new Font("Bahnschrift", 10F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(39, 39, 42);
            dataGridView1.Location = new Point(5, 5);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(611, 299);
            dataGridView1.TabIndex = 1;
            dataGridView1.VirtualMode = true;
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
            topBar.BackColor = Color.FromArgb(9, 9, 10);
            topBar.ArchiveEnabled = true;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnName.DefaultCellStyle = dataGridViewCellStyle2;
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
            // columnStockHealth
            // 
            columnStockHealth.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnStockHealth.HeaderText = "Stock Health";
            columnStockHealth.Name = "columnStockHealth";
            columnStockHealth.SortMode = DataGridViewColumnSortMode.Programmatic;
            columnStockHealth.Width = 120;
            // 
            // columnArchived
            // 
            columnArchived.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopRight;
            columnArchived.DefaultCellStyle = dataGridViewCellStyle3;
            columnArchived.HeaderText = "Archived";
            columnArchived.Name = "columnArchived";
            columnArchived.Width = 90;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnlData;
        private CustomControls.CustomRadioButton rbDarkMode;
        private Label lblStock;
        private CustomControls.Paginator paginator;
        private User_Controls.DataGrid.AddEditArchiveSearchBar topBar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn columnID;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnSKU;
        private DataGridViewTextBoxColumn columnQuantity;
        private DataGridViewTextBoxColumn columnStockHealth;
        private DataGridViewTextBoxColumn columnArchived;
    }
}