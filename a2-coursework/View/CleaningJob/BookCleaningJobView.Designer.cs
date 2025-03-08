namespace a2_coursework.View.Users {
    partial class BookCleaningJobView {
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
            sb = new a2_coursework.CustomControls.CustomScrollBar();
            monthCalendar = new a2_coursework.CustomControls.CustomMonthCalendar();
            lblCleaningJobs = new Label();
            dateInput = new a2_coursework.CustomControls.DateInput();
            topBar = new a2_coursework.User_Controls.DataGrid.AddEditDeleteSearchBar();
            pnlDate = new a2_coursework.CustomControls.CustomPanel();
            columnJobId = new DataGridViewTextBoxColumn();
            columnAddress = new DataGridViewTextBoxColumn();
            columnTime = new DataGridViewTextBoxColumn();
            pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            pnlDate.SuspendLayout();
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
            pnlData.Location = new Point(316, 127);
            pnlData.Margin = new Padding(5);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(5);
            pnlData.Size = new Size(321, 359);
            pnlData.TabIndex = 4;
            pnlData.Resize += pnlData_Resize;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top;
            lblError.Font = new Font("Bahnschrift", 20F);
            lblError.ForeColor = Color.FromArgb(168, 171, 174);
            lblError.Location = new Point(4, 134);
            lblError.Margin = new Padding(10, 0, 10, 20);
            lblError.Name = "lblError";
            lblError.Size = new Size(313, 103);
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
            dataGridView.ColumnHeadersHeight = 30;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { columnJobId, columnAddress, columnTime });
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
            dataGridView.Size = new Size(301, 349);
            dataGridView.TabIndex = 1;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.ColumnHeaderMouseClick += dataGridView_ColumnHeaderMouseClick;
            dataGridView.Resize += dataGridView_Resize;
            // 
            // sb
            // 
            sb.BackColor = Color.FromArgb(9, 9, 10);
            sb.Dock = DockStyle.Right;
            sb.LargeChange = 50;
            sb.Location = new Point(306, 5);
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
            // monthCalendar
            // 
            monthCalendar.BackColor = Color.FromArgb(9, 9, 10);
            monthCalendar.ClickedColor = Color.Empty;
            monthCalendar.Date = new DateTime(2025, 2, 28, 0, 0, 0, 0);
            monthCalendar.DateCornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            monthCalendar.DisabledForeColor = Color.FromArgb(168, 171, 174);
            monthCalendar.DisplayedDate = new DateTime(2025, 2, 8, 0, 0, 0, 0);
            monthCalendar.Dock = DockStyle.Fill;
            monthCalendar.ForeColor = Color.FromArgb(250, 250, 250);
            monthCalendar.HoverColor = Color.FromArgb(64, 64, 64);
            monthCalendar.Location = new Point(5, 5);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.SelectedDateBackColor = Color.FromArgb(64, 64, 64);
            monthCalendar.Size = new Size(280, 320);
            monthCalendar.TabIndex = 15;
            monthCalendar.DateChanged += customMonthCalendar_DateChanged;
            // 
            // lblCleaningJobs
            // 
            lblCleaningJobs.Anchor = AnchorStyles.Top;
            lblCleaningJobs.AutoSize = true;
            lblCleaningJobs.Font = new Font("Bahnschrift", 24F);
            lblCleaningJobs.ForeColor = Color.White;
            lblCleaningJobs.Location = new Point(208, 23);
            lblCleaningJobs.Margin = new Padding(10);
            lblCleaningJobs.Name = "lblCleaningJobs";
            lblCleaningJobs.Size = new Size(217, 39);
            lblCleaningJobs.TabIndex = 9;
            lblCleaningJobs.Text = "Cleaning Jobs";
            // 
            // dateInput
            // 
            dateInput.Anchor = AnchorStyles.Left;
            dateInput.BorderColor = Color.FromArgb(39, 39, 42);
            dateInput.BorderErrorColor = Color.Red;
            dateInput.BorderThickness = 1F;
            dateInput.Day = null;
            dateInput.DayToolTip = "";
            dateInput.Location = new Point(72, 78);
            dateInput.MaxDate = null;
            dateInput.MaximumSize = new Size(180, 70);
            dateInput.MinDate = null;
            dateInput.MinimumSize = new Size(180, 70);
            dateInput.Month = null;
            dateInput.MonthToolTip = "";
            dateInput.Name = "dateInput";
            dateInput.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            dateInput.ReadOnly = false;
            dateInput.Size = new Size(180, 70);
            dateInput.TabIndex = 12;
            dateInput.ToolTipsActive = true;
            dateInput.Year = null;
            dateInput.YearToolTip = "";
            dateInput.DateTextChanged += dateInput_DateTextChanged;
            // 
            // topBar
            // 
            topBar.AddEnabled = true;
            topBar.BackColor = Color.FromArgb(9, 9, 10);
            topBar.DeleteEnabled = true;
            topBar.EditEnabled = true;
            topBar.Location = new Point(316, 75);
            topBar.MinimumSize = new Size(321, 44);
            topBar.Name = "topBar";
            topBar.Padding = new Padding(2);
            topBar.SearchEnabled = true;
            topBar.SearchText = "";
            topBar.Size = new Size(321, 44);
            topBar.TabIndex = 13;
            topBar.ViewMode = true;
            // 
            // pnlDate
            // 
            pnlDate.Anchor = AnchorStyles.Left;
            pnlDate.BorderColor = Color.FromArgb(39, 39, 42);
            pnlDate.BorderThickness = 1F;
            pnlDate.Controls.Add(monthCalendar);
            pnlDate.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlDate.Location = new Point(14, 156);
            pnlDate.Margin = new Padding(5);
            pnlDate.Name = "pnlDate";
            pnlDate.Padding = new Padding(5);
            pnlDate.Size = new Size(290, 330);
            pnlDate.TabIndex = 16;
            // 
            // columnJobId
            // 
            columnJobId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnJobId.DefaultCellStyle = dataGridViewCellStyle2;
            columnJobId.HeaderText = "ID";
            columnJobId.Name = "columnJobId";
            columnJobId.SortMode = DataGridViewColumnSortMode.Programmatic;
            columnJobId.Width = 47;
            // 
            // columnAddress
            // 
            columnAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnAddress.HeaderText = "Address";
            columnAddress.Name = "columnAddress";
            // 
            // columnTime
            // 
            columnTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnTime.HeaderText = "Time";
            columnTime.Name = "columnTime";
            columnTime.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // BookCleaningJobView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(649, 500);
            Controls.Add(pnlDate);
            Controls.Add(topBar);
            Controls.Add(dateInput);
            Controls.Add(lblCleaningJobs);
            Controls.Add(pnlData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookCleaningJobView";
            Text = "UserDisplayView";
            pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            pnlDate.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnlData;
        private Label lblCleaningJobs;
        private DataGridView dataGridView;
        private Label lblError;
        private CustomControls.CustomScrollBar sb;
        private CustomControls.DateInput dateInput;
        private User_Controls.DataGrid.AddEditDeleteSearchBar topBar;
        private CustomControls.CustomMonthCalendar monthCalendar;
        private CustomControls.CustomPanel pnlDate;
        private DataGridViewTextBoxColumn columnJobId;
        private DataGridViewTextBoxColumn columnAddress;
        private DataGridViewTextBoxColumn columnTime;
    }
}
