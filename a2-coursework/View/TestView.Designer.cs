namespace a2_coursework.Theming {
    partial class TestView {
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
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            pnlChangePassword = new CustomControls.CustomPanel();
            rbDarkMode = new CustomControls.CustomRadioButton();
            paginator1 = new CustomControls.Paginator();
            customNumericUpDown1 = new CustomControls.CustomNumericUpDown();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            Column3.Width = 81;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.Width = 81;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.Width = 81;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(9, 9, 10);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(5, 5);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(477, 416);
            dataGridView1.TabIndex = 0;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            Column4.Width = 81;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            Column5.Width = 81;
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            Column6.Width = 81;
            // 
            // pnlChangePassword
            // 
            pnlChangePassword.Anchor = AnchorStyles.Top;
            pnlChangePassword.BorderColor = Color.FromArgb(39, 39, 42);
            pnlChangePassword.BorderThickness = 1F;
            pnlChangePassword.Controls.Add(rbDarkMode);
            pnlChangePassword.Controls.Add(dataGridView1);
            pnlChangePassword.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlChangePassword.Location = new Point(14, 14);
            pnlChangePassword.Margin = new Padding(5);
            pnlChangePassword.Name = "pnlChangePassword";
            pnlChangePassword.Padding = new Padding(5);
            pnlChangePassword.Size = new Size(487, 426);
            pnlChangePassword.TabIndex = 3;
            // 
            // rbDarkMode
            // 
            rbDarkMode.Anchor = AnchorStyles.Right;
            rbDarkMode.BorderThickness = 1.7F;
            rbDarkMode.CheckColor = Color.White;
            rbDarkMode.Checked = true;
            rbDarkMode.CheckRadius = 5F;
            rbDarkMode.ForeColor = Color.White;
            rbDarkMode.Location = new Point(744, 403);
            rbDarkMode.Margin = new Padding(5);
            rbDarkMode.Name = "rbDarkMode";
            rbDarkMode.Size = new Size(17, 17);
            rbDarkMode.TabIndex = 0;
            rbDarkMode.Text = "customRadioButton1";
            // 
            // paginator1
            // 
            paginator1.BackColor = Color.Red;
            paginator1.CurrentPage = 0;
            paginator1.Location = new Point(19, 455);
            paginator1.Name = "paginator1";
            paginator1.NumberOfPages = 20;
            paginator1.Padding = new Padding(2);
            paginator1.Size = new Size(482, 44);
            paginator1.TabIndex = 4;
            // 
            // customNumericUpDown1
            // 
            customNumericUpDown1.BackColor = Color.FromArgb(9, 9, 10);
            customNumericUpDown1.Location = new Point(545, 19);
            customNumericUpDown1.Name = "customNumericUpDown1";
            customNumericUpDown1.Size = new Size(174, 41);
            customNumericUpDown1.TabIndex = 5;
            customNumericUpDown1.Value = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(545, 85);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 6;
            // 
            // TestView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(1253, 511);
            Controls.Add(numericUpDown1);
            Controls.Add(customNumericUpDown1);
            Controls.Add(paginator1);
            Controls.Add(pnlChangePassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TestView";
            Text = "TestView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlChangePassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dataGridView1;
        private CustomControls.CustomPanel pnlChangePassword;
        private CustomControls.CustomRadioButton rbDarkMode;
        private CustomControls.Paginator paginator1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private CustomControls.CustomNumericUpDown customNumericUpDown1;
        private NumericUpDown numericUpDown1;
    }
}