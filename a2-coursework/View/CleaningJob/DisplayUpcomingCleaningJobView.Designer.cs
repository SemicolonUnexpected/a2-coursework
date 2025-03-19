namespace a2_coursework.View.CleaningJob {
    partial class DisplayUpcomingCleaningJobView {
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            pnlData = new a2_coursework.CustomControls.CustomPanel();
            lblError = new Label();
            dataGridView = new DataGridView();
            columnId = new DataGridViewTextBoxColumn();
            columnTimes = new DataGridViewTextBoxColumn();
            columnAddress = new DataGridViewTextBoxColumn();
            sb = new a2_coursework.CustomControls.CustomScrollBar();
            lblStock = new Label();
            toolTip = new ToolTip(components);
            topBar = new a2_coursework.User_Controls.DataGrid.ViewSearchBar();
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
            dataGridViewCellStyle9.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle9.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.ColumnHeadersHeight = 60;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { columnId, columnTimes, columnAddress });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle11.Font = new Font("Bahnschrift", 10F);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(39, 39, 42);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView.RowTemplate.Height = 30;
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(601, 349);
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
            // columnTimes
            // 
            columnTimes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnTimes.DefaultCellStyle = dataGridViewCellStyle10;
            columnTimes.HeaderText = "Times";
            columnTimes.Name = "columnTimes";
            columnTimes.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnAddress
            // 
            columnAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnAddress.HeaderText = "Address";
            columnAddress.Name = "columnAddress";
            columnAddress.SortMode = DataGridViewColumnSortMode.Programmatic;
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
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.Top;
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Bahnschrift", 24F);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(141, 23);
            lblStock.Margin = new Padding(10);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(367, 39);
            lblStock.TabIndex = 9;
            lblStock.Text = "Upcoming Cleaning Jobs";
            // 
            // topBar
            // 
            topBar.Anchor = AnchorStyles.Top;
            topBar.BackColor = Color.FromArgb(9, 9, 10);
            topBar.Location = new Point(14, 75);
            topBar.Name = "topBar";
            topBar.Padding = new Padding(2);
            topBar.SearchText = "";
            topBar.Size = new Size(621, 44);
            topBar.TabIndex = 10;
            // 
            // DisplayUpcomingCleaningJobView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(649, 500);
            Controls.Add(topBar);
            Controls.Add(lblStock);
            Controls.Add(pnlData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayUpcomingCleaningJobView";
            Text = "StockDisplayView";
            pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnlData;
        private Label lblStock;
        private DataGridView dataGridView;
        private Label lblError;
        private CustomControls.CustomScrollBar sb;
        private ToolTip toolTip;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnTimes;
        private DataGridViewTextBoxColumn columnAddress;
        private User_Controls.DataGrid.ViewSearchBar topBar;
    }
}