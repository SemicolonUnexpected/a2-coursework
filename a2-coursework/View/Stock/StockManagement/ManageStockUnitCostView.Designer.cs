namespace a2_coursework.View.Stock.StockManagement {
    partial class ManageStockUnitCostView {
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
            nudUnitCost = new NumericUpDown();
            lblUnitCost = new Label();
            pnlUnitCost = new a2_coursework.CustomControls.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).BeginInit();
            pnlUnitCost.SuspendLayout();
            SuspendLayout();
            // 
            // nudUnitCost
            // 
            nudUnitCost.BorderStyle = BorderStyle.FixedSingle;
            nudUnitCost.DecimalPlaces = 2;
            nudUnitCost.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudUnitCost.Location = new Point(116, 13);
            nudUnitCost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudUnitCost.Name = "nudUnitCost";
            nudUnitCost.Size = new Size(228, 27);
            nudUnitCost.TabIndex = 17;
            nudUnitCost.TextAlign = HorizontalAlignment.Center;
            // 
            // lblUnitCost
            // 
            lblUnitCost.Anchor = AnchorStyles.None;
            lblUnitCost.AutoSize = true;
            lblUnitCost.Font = new Font("Bahnschrift", 14F);
            lblUnitCost.ForeColor = Color.White;
            lblUnitCost.Location = new Point(5, 13);
            lblUnitCost.Margin = new Padding(5);
            lblUnitCost.Name = "lblUnitCost";
            lblUnitCost.Size = new Size(103, 23);
            lblUnitCost.TabIndex = 11;
            lblUnitCost.Text = "Unit Cost £";
            // 
            // pnlUnitCost
            // 
            pnlUnitCost.Anchor = AnchorStyles.None;
            pnlUnitCost.BorderColor = Color.FromArgb(39, 39, 42);
            pnlUnitCost.BorderThickness = 1F;
            pnlUnitCost.Controls.Add(nudUnitCost);
            pnlUnitCost.Controls.Add(lblUnitCost);
            pnlUnitCost.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            pnlUnitCost.Location = new Point(146, 44);
            pnlUnitCost.Name = "pnlUnitCost";
            pnlUnitCost.Size = new Size(355, 49);
            pnlUnitCost.TabIndex = 18;
            // 
            // ManageStockUnitCostView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 419);
            Controls.Add(pnlUnitCost);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStockUnitCostView";
            Text = "Unit Cost";
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).EndInit();
            pnlUnitCost.ResumeLayout(false);
            pnlUnitCost.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown nudUnitCost;
        private Label lblUnitCost;
        private CustomControls.CustomPanel pnlUnitCost;
    }
}