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
            pnlChangePassword = new CustomControls.CustomPanel();
            rbDarkMode = new CustomControls.CustomRadioButton();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            lblStock = new Label();
            paginator1 = new Custom_Controls.Paginator();
            addEditDeleteSearchBar1 = new User_Controls.DataGrid.AddEditDeleteSearchBar();
            pnlChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlChangePassword
            // 
            pnlChangePassword.Anchor = AnchorStyles.Top;
            pnlChangePassword.BorderColor = Color.FromArgb(39, 39, 42);
            pnlChangePassword.BorderThickness = 1F;
            pnlChangePassword.Controls.Add(rbDarkMode);
            pnlChangePassword.Controls.Add(dataGridView1);
            pnlChangePassword.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlChangePassword.Location = new Point(12, 128);
            pnlChangePassword.Margin = new Padding(5);
            pnlChangePassword.Name = "pnlChangePassword";
            pnlChangePassword.Padding = new Padding(5);
            pnlChangePassword.Size = new Size(561, 258);
            pnlChangePassword.TabIndex = 4;
            // 
            // rbDarkMode
            // 
            rbDarkMode.Anchor = AnchorStyles.Right;
            rbDarkMode.BorderThickness = 1.7F;
            rbDarkMode.CheckColor = Color.White;
            rbDarkMode.Checked = true;
            rbDarkMode.CheckRadius = 5F;
            rbDarkMode.ForeColor = Color.White;
            rbDarkMode.Location = new Point(1100, 482);
            rbDarkMode.Margin = new Padding(5);
            rbDarkMode.Name = "rbDarkMode";
            rbDarkMode.Size = new Size(17, 17);
            rbDarkMode.TabIndex = 0;
            rbDarkMode.Text = "customRadioButton1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(9, 9, 10);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(551, 248);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.None;
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Bahnschrift", 24F);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(232, 19);
            lblStock.Margin = new Padding(10);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(97, 39);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            // 
            // paginator1
            // 
            paginator1.BackColor = Color.FromArgb(9, 9, 10);
            paginator1.CurrentPage = 0;
            paginator1.Location = new Point(12, 394);
            paginator1.Name = "paginator1";
            paginator1.NumberOfPages = 20;
            paginator1.Padding = new Padding(2);
            paginator1.Size = new Size(561, 44);
            paginator1.TabIndex = 10;
            // 
            // addEditDeleteSearchBar1
            // 
            addEditDeleteSearchBar1.BackColor = Color.FromArgb(9, 9, 10);
            addEditDeleteSearchBar1.Location = new Point(17, 71);
            addEditDeleteSearchBar1.Name = "addEditDeleteSearchBar1";
            addEditDeleteSearchBar1.Padding = new Padding(2);
            addEditDeleteSearchBar1.Size = new Size(556, 44);
            addEditDeleteSearchBar1.TabIndex = 11;
            addEditDeleteSearchBar1.Load += addEditDeleteSearchBar1_Load;
            // 
            // StockDisplayView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(589, 450);
            Controls.Add(addEditDeleteSearchBar1);
            Controls.Add(paginator1);
            Controls.Add(lblStock);
            Controls.Add(pnlChangePassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockDisplayView";
            Text = "StockDisplayView";
            pnlChangePassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel pnlChangePassword;
        private CustomControls.CustomRadioButton rbDarkMode;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label lblStock;
        private Custom_Controls.Paginator paginator1;
        private User_Controls.DataGrid.AddEditDeleteSearchBar addEditDeleteSearchBar1;
    }
}