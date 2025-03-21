﻿namespace a2_coursework.View.Stock {
    partial class DisplayStockQuantityChangesView {
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
            pnlData = new a2_coursework.CustomControls.CustomPanel();
            lblError = new Label();
            dataGridView = new DataGridView();
            columnUsername = new DataGridViewTextBoxColumn();
            columnStockName = new DataGridViewTextBoxColumn();
            columnSku = new DataGridViewTextBoxColumn();
            columnQuantity = new DataGridViewTextBoxColumn();
            columnDate = new DataGridViewTextBoxColumn();
            columnArchived = new DataGridViewTextBoxColumn();
            sb = new a2_coursework.CustomControls.CustomScrollBar();
            lblStockQuantityChanges = new Label();
            topBar = new a2_coursework.User_Controls.DataGrid.ViewArchivedSearchBar();
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
            pnlData.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
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
            dataGridViewCellStyle6.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle6.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.ColumnHeadersHeight = 60;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { columnUsername, columnStockName, columnSku, columnQuantity, columnDate, columnArchived });
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
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(39, 39, 42);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView.RowTemplate.Height = 30;
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(601, 349);
            dataGridView.TabIndex = 1;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.ColumnHeaderMouseClick += dataGridView_ColumnHeaderMouseClick;
            dataGridView.Resize += dataGridView_Resize;
            // 
            // columnUsername
            // 
            columnUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnUsername.DefaultCellStyle = dataGridViewCellStyle7;
            columnUsername.HeaderText = "Username";
            columnUsername.Name = "columnUsername";
            columnUsername.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnStockName
            // 
            columnStockName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnStockName.HeaderText = "Stock Name";
            columnStockName.Name = "columnStockName";
            columnStockName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnSku
            // 
            columnSku.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnSku.HeaderText = "SKU";
            columnSku.Name = "columnSku";
            columnSku.SortMode = DataGridViewColumnSortMode.Programmatic;
            columnSku.Width = 62;
            // 
            // columnQuantity
            // 
            columnQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnQuantity.HeaderText = "Quantity";
            columnQuantity.Name = "columnQuantity";
            columnQuantity.SortMode = DataGridViewColumnSortMode.Programmatic;
            columnQuantity.Width = 92;
            // 
            // columnDate
            // 
            columnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnDate.HeaderText = "Date";
            columnDate.Name = "columnDate";
            columnDate.SortMode = DataGridViewColumnSortMode.Programmatic;
            columnDate.Width = 66;
            // 
            // columnArchived
            // 
            columnArchived.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.TopRight;
            columnArchived.DefaultCellStyle = dataGridViewCellStyle8;
            columnArchived.HeaderText = "Archived";
            columnArchived.Name = "columnArchived";
            columnArchived.SortMode = DataGridViewColumnSortMode.Programmatic;
            columnArchived.Width = 96;
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
            sb.ThumbCorderRadii = new a2_coursework.CustomControls.CornerRadiiF(3F, 3F, 3F, 3F);
            sb.ThumbHoverColor = Color.FromArgb(39, 39, 42);
            sb.Visible = false;
            sb.ValueChanged += sb_ValueChanged;
            // 
            // lblStockQuantityChanges
            // 
            lblStockQuantityChanges.Anchor = AnchorStyles.Top;
            lblStockQuantityChanges.AutoSize = true;
            lblStockQuantityChanges.Font = new Font("Bahnschrift", 24F);
            lblStockQuantityChanges.ForeColor = Color.White;
            lblStockQuantityChanges.Location = new Point(146, 23);
            lblStockQuantityChanges.Margin = new Padding(10);
            lblStockQuantityChanges.Name = "lblStockQuantityChanges";
            lblStockQuantityChanges.Size = new Size(356, 39);
            lblStockQuantityChanges.TabIndex = 9;
            lblStockQuantityChanges.Text = "Stock Quantity Changes";
            // 
            // topBar
            // 
            topBar.Anchor = AnchorStyles.Top;
            topBar.BackColor = Color.FromArgb(9, 9, 10);
            topBar.Location = new Point(19, 75);
            topBar.Name = "topBar";
            topBar.Padding = new Padding(2);
            topBar.SearchText = "";
            topBar.Size = new Size(616, 44);
            topBar.TabIndex = 10;
            // 
            // DisplayStockQuantityChangesView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(649, 500);
            Controls.Add(topBar);
            Controls.Add(lblStockQuantityChanges);
            Controls.Add(pnlData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayStockQuantityChangesView";
            Text = "Stock DisplayView";
            pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnlData;
        private Label lblStockQuantityChanges;
        private DataGridView dataGridView;
        private Label lblError;
        private CustomControls.CustomScrollBar sb;
        private DataGridViewTextBoxColumn columnUsername;
        private DataGridViewTextBoxColumn columnStockName;
        private DataGridViewTextBoxColumn columnSku;
        private DataGridViewTextBoxColumn columnQuantity;
        private DataGridViewTextBoxColumn columnDate;
        private DataGridViewTextBoxColumn columnArchived;
        private User_Controls.DataGrid.ViewArchivedSearchBar topBar;
    }
}