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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.Left;
            pbLogo.Image = Properties.Resources.Logo_Title_Condensed;
            pbLogo.Location = new Point(17, 5);
            pbLogo.Margin = new Padding(5);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(127, 30);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 16F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(672, 6);
            lblUsername.Margin = new Padding(5, 5, 10, 5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(111, 27);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "username";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            lblUsername.Click += lblUsername_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 42);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 1);
            panel1.TabIndex = 6;
            // 
            // TopBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(lblUsername);
            Controls.Add(pbLogo);
            Controls.Add(panel1);
            Name = "TopBar";
            Size = new Size(793, 41);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblUsername;
        private Panel panel1;
    }
}
