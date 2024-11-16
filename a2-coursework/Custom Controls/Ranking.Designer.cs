namespace AS_Coursework.Custom_Controls {
    partial class Ranking {
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
        private void InitializeComponent()
        {
            rect1 = new CustomRectangle();
            lblExperience = new Label();
            lblUsername = new Label();
            rect1.SuspendLayout();
            SuspendLayout();
            // 
            // rect1
            // 
            rect1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rect1.BackColor = Color.FromArgb(20, 20, 50);
            rect1.BorderColor = Color.White;
            rect1.BorderWidth = 0;
            rect1.Controls.Add(lblExperience);
            rect1.Controls.Add(lblUsername);
            rect1.CornerRadius = 20;
            rect1.Location = new Point(0, 0);
            rect1.Margin = new Padding(0);
            rect1.Name = "rect1";
            rect1.Size = new Size(660, 70);
            rect1.TabIndex = 4;
            rect1.Text = "customRectangle1";
            // 
            // lblExperience
            // 
            lblExperience.Anchor = AnchorStyles.Right;
            lblExperience.AutoEllipsis = true;
            lblExperience.AutoSize = true;
            lblExperience.BackColor = Color.FromArgb(20, 20, 50);
            lblExperience.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblExperience.ForeColor = Color.White;
            lblExperience.Location = new Point(441, 19);
            lblExperience.Margin = new Padding(25, 0, 25, 0);
            lblExperience.MinimumSize = new Size(200, 19);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(200, 34);
            lblExperience.TabIndex = 5;
            lblExperience.Text = "24901 xp";
            lblExperience.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUsername.AutoEllipsis = true;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.FromArgb(20, 20, 50);
            lblUsername.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(25, 19);
            lblUsername.Margin = new Padding(25, 0, 25, 0);
            lblUsername.MinimumSize = new Size(350, 34);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(350, 34);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // Ranking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(rect1);
            Name = "Ranking";
            Size = new Size(660, 70);
            rect1.ResumeLayout(false);
            rect1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CustomRectangle rect1;
        private Label lblExperience;
        private Label lblUsername;
    }
}
