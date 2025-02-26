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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlData = new CustomControls.CustomPanel();
            lblError = new Label();
            dataGridView = new DataGridView();
            columnUsername = new DataGridViewTextBoxColumn();
            columnAttemptTime = new DataGridViewTextBoxColumn();
            columnSuccessful = new DataGridViewTextBoxColumn();
            sb = new CustomControls.CustomScrollBar();
            lblCleaningJobs = new Label();
            monthCalendar1 = new MonthCalendar();
            dateInput1 = new CustomControls.DateInput();
            searchBar = new User_Controls.DataGrid.AddEditDeleteSearchBar();
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
            pnlData.Location = new Point(292, 127);
            pnlData.Margin = new Padding(5);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(5);
            pnlData.Size = new Size(343, 359);
            pnlData.TabIndex = 4;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top;
            lblError.Font = new Font("Bahnschrift", 20F);
            lblError.ForeColor = Color.FromArgb(168, 171, 174);
            lblError.Location = new Point(15, 134);
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
            dataGridViewCellStyle5.BackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle5.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(9, 9, 10);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.ColumnHeadersHeight = 30;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { columnUsername, columnAttemptTime, columnSuccessful });
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
            dataGridView.Size = new Size(323, 349);
            dataGridView.TabIndex = 1;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.ColumnHeaderMouseClick += dataGridView_ColumnHeaderMouseClick;
            dataGridView.Resize += dataGridView_Resize;
            // 
            // columnUsername
            // 
            columnUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnUsername.DefaultCellStyle = dataGridViewCellStyle6;
            columnUsername.HeaderText = "Username";
            columnUsername.Name = "columnUsername";
            columnUsername.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnAttemptTime
            // 
            columnAttemptTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnAttemptTime.HeaderText = "Attempt Time";
            columnAttemptTime.Name = "columnAttemptTime";
            columnAttemptTime.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnSuccessful
            // 
            columnSuccessful.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnSuccessful.HeaderText = "Successful";
            columnSuccessful.Name = "columnSuccessful";
            columnSuccessful.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // sb
            // 
            sb.BackColor = Color.FromArgb(9, 9, 10);
            sb.Dock = DockStyle.Right;
            sb.LargeChange = 50;
            sb.Location = new Point(328, 5);
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
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(1, 2);
            monthCalendar1.Location = new Point(18, 157);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            // 
            // dateInput1
            // 
            dateInput1.BorderColor = Color.Empty;
            dateInput1.BorderErrorColor = Color.Red;
            dateInput1.BorderThickness = 1F;
            dateInput1.Day = null;
            dateInput1.DayToolTip = "";
            dateInput1.Location = new Point(18, 75);
            dateInput1.MaxDate = null;
            dateInput1.MaximumSize = new Size(180, 70);
            dateInput1.MinDate = null;
            dateInput1.MinimumSize = new Size(180, 70);
            dateInput1.Month = null;
            dateInput1.MonthToolTip = "";
            dateInput1.Name = "dateInput1";
            dateInput1.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            dateInput1.ReadOnly = false;
            dateInput1.Size = new Size(180, 70);
            dateInput1.TabIndex = 12;
            dateInput1.ToolTipsActive = true;
            dateInput1.Year = null;
            dateInput1.YearToolTip = "";
            // 
            // searchBar
            // 
            searchBar.AddEnabled = true;
            searchBar.BackColor = Color.FromArgb(9, 9, 10);
            searchBar.DeleteEnabled = true;
            searchBar.EditEnabled = true;
            searchBar.Location = new Point(292, 75);
            searchBar.Name = "searchBar";
            searchBar.Padding = new Padding(2);
            searchBar.SearchEnabled = true;
            searchBar.SearchText = "";
            searchBar.Size = new Size(343, 44);
            searchBar.TabIndex = 13;
            // 
            // BookCleaningJobView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(649, 500);
            Controls.Add(searchBar);
            Controls.Add(dateInput1);
            Controls.Add(monthCalendar1);
            Controls.Add(lblCleaningJobs);
            Controls.Add(pnlData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookCleaningJobView";
            Text = "UserDisplayView";
            pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnlData;
        private Label lblCleaningJobs;
        private DataGridView dataGridView;
        private Label lblError;
        private CustomControls.CustomScrollBar sb;
        private DataGridViewTextBoxColumn columnUsername;
        private DataGridViewTextBoxColumn columnAttemptTime;
        private DataGridViewTextBoxColumn columnSuccessful;
        private MonthCalendar monthCalendar1;
        private CustomControls.DateInput dateInput1;
        private User_Controls.DataGrid.AddEditDeleteSearchBar searchBar;
    }
}
