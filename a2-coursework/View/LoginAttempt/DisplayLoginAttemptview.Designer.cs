﻿namespace a2_coursework.View.Users {
    partial class DisplayLoginAttemptView {
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
            lblLoginAttempt = new Label();
            searchBar = new User_Controls.DataGrid.SearchBar();
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
            dataGridView.Size = new Size(601, 349);
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
            // lblLoginAttempt
            // 
            lblLoginAttempt.Anchor = AnchorStyles.Top;
            lblLoginAttempt.AutoSize = true;
            lblLoginAttempt.Font = new Font("Bahnschrift", 24F);
            lblLoginAttempt.ForeColor = Color.White;
            lblLoginAttempt.Location = new Point(208, 23);
            lblLoginAttempt.Margin = new Padding(10);
            lblLoginAttempt.Name = "lblLoginAttempt";
            lblLoginAttempt.Size = new Size(233, 39);
            lblLoginAttempt.TabIndex = 9;
            lblLoginAttempt.Text = "Login Attempts";
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.Top;
            searchBar.BackColor = Color.FromArgb(9, 9, 10);
            searchBar.Location = new Point(12, 75);
            searchBar.Name = "searchBar";
            searchBar.Padding = new Padding(2);
            searchBar.SearchText = "";
            searchBar.Size = new Size(623, 44);
            searchBar.TabIndex = 10;
            // 
            // DisplayLoginAttemptView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(649, 500);
            Controls.Add(searchBar);
            Controls.Add(lblLoginAttempt);
            Controls.Add(pnlData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayLoginAttemptView";
            Text = "UserDisplayView";
            pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnlData;
        private Label lblLoginAttempt;
        private DataGridView dataGridView;
        private Label lblError;
        private CustomControls.CustomScrollBar sb;
        private User_Controls.DataGrid.SearchBar searchBar;
        private DataGridViewTextBoxColumn columnUsername;
        private DataGridViewTextBoxColumn columnAttemptTime;
        private DataGridViewTextBoxColumn columnSuccessful;
    }
}
