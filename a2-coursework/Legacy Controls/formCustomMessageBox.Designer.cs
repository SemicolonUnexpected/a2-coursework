namespace AS_Coursework.Custom_Controls {
    partial class formCustomMessageBox {
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
            pnlBottom = new Panel();
            btnOk = new CustomButton();
            btnCancel = new CustomButton();
            lblText = new Label();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.FromArgb(30, 30, 60);
            pnlBottom.Controls.Add(btnOk);
            pnlBottom.Controls.Add(btnCancel);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 161);
            pnlBottom.Margin = new Padding(2, 2, 2, 2);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(405, 45);
            pnlBottom.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.None;
            btnOk.BackColor = Color.FromArgb(0, 150, 255);
            btnOk.BorderColor = Color.White;
            btnOk.BorderWidth = 2;
            btnOk.CornerRadius = 10;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.Image = null;
            btnOk.ImageSize = new Size(150, 40);
            btnOk.Location = new Point(228, 8);
            btnOk.Margin = new Padding(7, 6, 7, 6);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(70, 30);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(0, 150, 255);
            btnCancel.BorderColor = Color.White;
            btnCancel.BorderWidth = 2;
            btnCancel.CornerRadius = 10;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = null;
            btnCancel.ImageSize = new Size(150, 40);
            btnCancel.Location = new Point(312, 8);
            btnCancel.Margin = new Padding(7, 6, 7, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 30);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblText.ForeColor = Color.White;
            lblText.ImageAlign = ContentAlignment.TopCenter;
            lblText.Location = new Point(7, 6);
            lblText.Margin = new Padding(2, 0, 2, 0);
            lblText.MaximumSize = new Size(391, 149);
            lblText.MinimumSize = new Size(391, 149);
            lblText.Name = "lblText";
            lblText.Size = new Size(391, 149);
            lblText.TabIndex = 2;
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formCustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(405, 206);
            Controls.Add(lblText);
            Controls.Add(pnlBottom);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            Name = "formCustomMessageBox";
            StartPosition = FormStartPosition.CenterParent;
            Text = "formCustomMessageBox";
            TopMost = true;
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBottom;
        private CustomButton btnOk;
        private CustomButton btnCancel;
        private Label lblText;
    }
}