namespace a2_coursework.UserControls {
    partial class TopBar {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pbLogo = new PictureBox();
            lblUsername = new Label();
            pnlDecor = new Panel();
            pnlLeft = new Panel();
            pnlRight = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Dock = DockStyle.Left;
            pbLogo.Image = Properties.Resources.Logo_Title_Condensed;
            pbLogo.Location = new Point(14, 0);
            pbLogo.Margin = new Padding(5);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(142, 40);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 16F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(669, 6);
            lblUsername.Margin = new Padding(5, 5, 10, 5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 27);
            lblUsername.TabIndex = 3;
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDecor
            // 
            pnlDecor.BackColor = Color.FromArgb(39, 39, 42);
            pnlDecor.Dock = DockStyle.Bottom;
            pnlDecor.Location = new Point(0, 40);
            pnlDecor.Margin = new Padding(0);
            pnlDecor.Name = "pnlDecor";
            pnlDecor.Size = new Size(793, 1);
            pnlDecor.TabIndex = 6;
            // 
            // pnlLeft
            // 
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(14, 40);
            pnlLeft.TabIndex = 7;
            // 
            // pnlRight
            // 
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(779, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(14, 40);
            pnlRight.TabIndex = 8;
            // 
            // TopBar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(lblUsername);
            Controls.Add(pbLogo);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Controls.Add(pnlDecor);
            Name = "TopBar";
            Size = new Size(793, 41);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblUsername;
        private Panel pnlDecor;
        private Panel pnlLeft;
        private Panel pnlRight;
    }
}
