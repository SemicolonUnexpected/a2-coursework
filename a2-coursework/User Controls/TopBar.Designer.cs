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
            btnSignOut = new CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlRight.SuspendLayout();
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
            lblUsername.Dock = DockStyle.Right;
            lblUsername.Font = new Font("Bahnschrift", 16F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(323, 0);
            lblUsername.Margin = new Padding(5, 5, 10, 5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(366, 40);
            lblUsername.TabIndex = 3;
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
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
            pnlRight.Controls.Add(btnSignOut);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(689, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(5);
            pnlRight.Size = new Size(104, 40);
            pnlRight.TabIndex = 8;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = SystemColors.Control;
            btnSignOut.BorderColor = Color.Empty;
            btnSignOut.BorderThickness = 0F;
            btnSignOut.ClickedBorderColor = Color.Empty;
            btnSignOut.ClickedColor = Color.FromArgb(226, 226, 226);
            btnSignOut.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnSignOut.Cursor = Cursors.Hand;
            btnSignOut.DisabledBorderColor = Color.Empty;
            btnSignOut.DisabledColor = Color.FromArgb(226, 226, 226);
            btnSignOut.Dock = DockStyle.Fill;
            btnSignOut.Font = new Font("Bahnschrift", 12F);
            btnSignOut.ForeColor = Color.FromArgb(9, 9, 10);
            btnSignOut.HoverBorderColor = Color.Empty;
            btnSignOut.HoverColor = Color.FromArgb(226, 226, 226);
            btnSignOut.Image = null;
            btnSignOut.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnSignOut.Location = new Point(5, 5);
            btnSignOut.Margin = new Padding(10);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(94, 30);
            btnSignOut.TabIndex = 9;
            btnSignOut.Text = "Sign out";
            btnSignOut.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnSignOut.TextPosition = new Point(13, 5);
            btnSignOut.Click += btnLogOut_Click;
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
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblUsername;
        private Panel pnlDecor;
        private Panel pnlLeft;
        private Panel pnlRight;
        private CustomControls.CustomButton btnSignOut;
    }
}
