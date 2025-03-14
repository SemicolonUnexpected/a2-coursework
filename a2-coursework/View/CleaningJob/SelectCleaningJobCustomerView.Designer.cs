﻿namespace a2_coursework.View.Order {
    partial class SelectCleaningJobCustomerView {
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlData = new a2_coursework.CustomControls.CustomPanel();
            lblError = new Label();
            dataGridView = new DataGridView();
            columnId = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnEmail = new DataGridViewTextBoxColumn();
            columnPhoneNumber = new DataGridViewTextBoxColumn();
            sb = new a2_coursework.CustomControls.CustomScrollBar();
            topBar = new a2_coursework.User_Controls.DataGrid.SearchBar();
            lblInfo = new Label();
            tbSelectedCustomer = new a2_coursework.CustomControls.CustomTextBox();
            lblSelectedCustomer = new Label();
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
            pnlData.Location = new Point(14, 146);
            pnlData.Margin = new Padding(5);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(5);
            pnlData.Size = new Size(621, 259);
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
            dataGridViewCellStyle5.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle5.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.ColumnHeadersHeight = 60;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { columnId, columnName, columnEmail, columnPhoneNumber });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle7.Font = new Font("Bahnschrift", 10F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(39, 39, 42);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.RowTemplate.Height = 30;
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(601, 249);
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
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnName.DefaultCellStyle = dataGridViewCellStyle6;
            columnName.HeaderText = "Name";
            columnName.Name = "columnName";
            columnName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnEmail
            // 
            columnEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnEmail.HeaderText = "Email";
            columnEmail.Name = "columnEmail";
            columnEmail.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnPhoneNumber
            // 
            columnPhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnPhoneNumber.HeaderText = "Phone Number";
            columnPhoneNumber.Name = "columnPhoneNumber";
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
            sb.Size = new Size(10, 249);
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
            // topBar
            // 
            topBar.Anchor = AnchorStyles.Top;
            topBar.BackColor = Color.FromArgb(9, 9, 10);
            topBar.Location = new Point(19, 94);
            topBar.Name = "topBar";
            topBar.Padding = new Padding(2);
            topBar.SearchText = "";
            topBar.Size = new Size(623, 44);
            topBar.TabIndex = 12;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.Top;
            lblInfo.Font = new Font("Bahnschrift", 12F);
            lblInfo.ForeColor = Color.FromArgb(168, 171, 174);
            lblInfo.Location = new Point(14, 9);
            lblInfo.Margin = new Padding(10, 0, 10, 20);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(621, 30);
            lblInfo.TabIndex = 27;
            lblInfo.Text = "Select the customer for the job below";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUsername
            // 
            tbSelectedCustomer.Anchor = AnchorStyles.Top;
            tbSelectedCustomer.BackColor = Color.FromArgb(9, 9, 10);
            tbSelectedCustomer.BorderColor = Color.FromArgb(39, 39, 42);
            tbSelectedCustomer.BorderThickness = 1F;
            tbSelectedCustomer.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbSelectedCustomer.Font = new Font("Bahnschrift", 12F);
            tbSelectedCustomer.ForeColor = Color.Empty;
            tbSelectedCustomer.HoverColor = Color.Empty;
            tbSelectedCustomer.Location = new Point(240, 46);
            tbSelectedCustomer.Margin = new Padding(5, 5, 50, 5);
            tbSelectedCustomer.MaxLength = 256;
            tbSelectedCustomer.MultiLine = false;
            tbSelectedCustomer.Name = "tbUsername";
            tbSelectedCustomer.PlaceholderText = "";
            tbSelectedCustomer.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSelectedCustomer.ReadOnly = false;
            tbSelectedCustomer.Size = new Size(350, 40);
            tbSelectedCustomer.TabIndex = 28;
            tbSelectedCustomer.TextAlign = HorizontalAlignment.Left;
            tbSelectedCustomer.TextBoxInset = new Padding(10);
            tbSelectedCustomer.UsePasswordChar = false;
            // 
            // lblUsername
            // 
            lblSelectedCustomer.Anchor = AnchorStyles.Top;
            lblSelectedCustomer.AutoSize = true;
            lblSelectedCustomer.Font = new Font("Bahnschrift", 14F);
            lblSelectedCustomer.ForeColor = Color.White;
            lblSelectedCustomer.Location = new Point(59, 55);
            lblSelectedCustomer.Margin = new Padding(50, 5, 5, 5);
            lblSelectedCustomer.Name = "lblUsername";
            lblSelectedCustomer.Size = new Size(171, 23);
            lblSelectedCustomer.TabIndex = 29;
            lblSelectedCustomer.Text = "Selected Customer";
            // 
            // SelectCleaningJobCustomerView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(649, 419);
            Controls.Add(tbSelectedCustomer);
            Controls.Add(lblSelectedCustomer);
            Controls.Add(lblInfo);
            Controls.Add(topBar);
            Controls.Add(pnlData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectCleaningJobCustomerView";
            Text = "StockDisplayView";
            pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnlData;
        private DataGridView dataGridView;
        private Label lblError;
        private CustomControls.CustomScrollBar sb;
        private User_Controls.DataGrid.SearchBar topBar;
        private Label lblInfo;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnEmail;
        private DataGridViewTextBoxColumn columnPhoneNumber;
        private CustomControls.CustomTextBox tbSelectedCustomer;
        private Label lblSelectedCustomer;
    }
}