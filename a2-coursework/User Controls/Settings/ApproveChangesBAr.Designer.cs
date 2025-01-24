namespace a2_coursework.User_Controls.Settings {
    partial class ApproveChangesBar {
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
            pnlDecor = new Panel();
            btnSignIn = new CustomControls.CustomButton();
            customButton1 = new CustomControls.CustomButton();
            SuspendLayout();
            // 
            // pnlDecor
            // 
            pnlDecor.BackColor = Color.FromArgb(39, 39, 42);
            pnlDecor.Dock = DockStyle.Top;
            pnlDecor.Location = new Point(0, 0);
            pnlDecor.Name = "pnlDecor";
            pnlDecor.Size = new Size(528, 1);
            pnlDecor.TabIndex = 12;
            // 
            // btnSignIn
            // 
            btnSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSignIn.BackColor = SystemColors.Control;
            btnSignIn.BorderColor = Color.Empty;
            btnSignIn.BorderThickness = 0F;
            btnSignIn.ClickedBorderColor = Color.Empty;
            btnSignIn.ClickedColor = Color.FromArgb(226, 226, 226);
            btnSignIn.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.DisabledBorderColor = Color.Empty;
            btnSignIn.DisabledColor = Color.FromArgb(226, 226, 226);
            btnSignIn.Font = new Font("Bahnschrift", 12F);
            btnSignIn.ForeColor = Color.FromArgb(9, 9, 10);
            btnSignIn.HoverBorderColor = Color.Empty;
            btnSignIn.HoverColor = Color.FromArgb(226, 226, 226);
            btnSignIn.Image = null;
            btnSignIn.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnSignIn.Location = new Point(390, 5);
            btnSignIn.Margin = new Padding(5);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(128, 30);
            btnSignIn.TabIndex = 13;
            btnSignIn.Text = "Sign in";
            btnSignIn.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnSignIn.TextPosition = new Point(35, 5);
            // 
            // customButton1
            // 
            customButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton1.BackColor = SystemColors.Control;
            customButton1.BorderColor = Color.Empty;
            customButton1.BorderThickness = 0F;
            customButton1.ClickedBorderColor = Color.Empty;
            customButton1.ClickedColor = Color.FromArgb(226, 226, 226);
            customButton1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customButton1.Cursor = Cursors.Hand;
            customButton1.DisabledBorderColor = Color.Empty;
            customButton1.DisabledColor = Color.FromArgb(226, 226, 226);
            customButton1.Font = new Font("Bahnschrift", 12F);
            customButton1.ForeColor = Color.FromArgb(9, 9, 10);
            customButton1.HoverBorderColor = Color.Empty;
            customButton1.HoverColor = Color.FromArgb(226, 226, 226);
            customButton1.Image = null;
            customButton1.ImageRectangle = new Rectangle(0, 0, 0, 0);
            customButton1.Location = new Point(252, 5);
            customButton1.Margin = new Padding(5);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(128, 30);
            customButton1.TabIndex = 14;
            customButton1.Text = "Sign in";
            customButton1.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            customButton1.TextPosition = new Point(35, 5);
            // 
            // ApproveChangesBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(customButton1);
            Controls.Add(btnSignIn);
            Controls.Add(pnlDecor);
            Name = "ApproveChangesBar";
            Size = new Size(528, 40);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDecor;
        private CustomControls.CustomButton btnSignIn;
        private CustomControls.CustomButton customButton1;
    }
}
