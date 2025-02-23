namespace a2_coursework.CustomControls {
    partial class CustomMessageBoxView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBoxView));
            pnlDecor = new Panel();
            pnlBottom = new Panel();
            flp = new FlowLayoutPanel();
            btnOk = new CustomButton();
            btnCancel = new CustomButton();
            lblText = new Label();
            lblTitle = new Label();
            pnlBottom.SuspendLayout();
            flp.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDecor
            // 
            pnlDecor.BackColor = Color.FromArgb(39, 39, 42);
            pnlDecor.Dock = DockStyle.Top;
            pnlDecor.Location = new Point(0, 0);
            pnlDecor.Margin = new Padding(0);
            pnlDecor.Name = "pnlDecor";
            pnlDecor.Size = new Size(441, 1);
            pnlDecor.TabIndex = 7;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(flp);
            pnlBottom.Controls.Add(pnlDecor);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 169);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(441, 41);
            pnlBottom.TabIndex = 8;
            // 
            // flp
            // 
            flp.Controls.Add(btnOk);
            flp.Controls.Add(btnCancel);
            flp.Dock = DockStyle.Fill;
            flp.FlowDirection = FlowDirection.RightToLeft;
            flp.Location = new Point(0, 1);
            flp.Name = "flp";
            flp.Size = new Size(441, 40);
            flp.TabIndex = 8;
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.Control;
            btnOk.BorderColor = Color.Empty;
            btnOk.BorderThickness = 0F;
            btnOk.ClickedBorderColor = Color.Empty;
            btnOk.ClickedColor = Color.FromArgb(226, 226, 226);
            btnOk.CornerRadii = new CornerRadiiF(10F, 10F, 10F, 10F);
            btnOk.Cursor = Cursors.Hand;
            btnOk.DisabledBorderColor = Color.Empty;
            btnOk.DisabledColor = Color.FromArgb(226, 226, 226);
            btnOk.Font = new Font("Bahnschrift", 12F);
            btnOk.ForeColor = Color.FromArgb(9, 9, 10);
            btnOk.HoverBorderColor = Color.Empty;
            btnOk.HoverColor = Color.FromArgb(226, 226, 226);
            btnOk.Image = null;
            btnOk.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnOk.Location = new Point(336, 5);
            btnOk.Margin = new Padding(5);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 30);
            btnOk.TabIndex = 8;
            btnOk.Text = "OK";
            btnOk.TextAlign = CustomButtonAlign.MiddleCenter;
            btnOk.TextPosition = new Point(35, 5);
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.BorderColor = Color.Empty;
            btnCancel.BorderThickness = 0F;
            btnCancel.ClickedBorderColor = Color.Empty;
            btnCancel.ClickedColor = Color.FromArgb(226, 226, 226);
            btnCancel.CornerRadii = new CornerRadiiF(10F, 10F, 10F, 10F);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DisabledBorderColor = Color.Empty;
            btnCancel.DisabledColor = Color.FromArgb(226, 226, 226);
            btnCancel.Font = new Font("Bahnschrift", 12F);
            btnCancel.ForeColor = Color.FromArgb(9, 9, 10);
            btnCancel.HoverBorderColor = Color.Empty;
            btnCancel.HoverColor = Color.FromArgb(226, 226, 226);
            btnCancel.Image = null;
            btnCancel.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnCancel.Location = new Point(226, 5);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = CustomButtonAlign.MiddleCenter;
            btnCancel.TextPosition = new Point(20, 5);
            btnCancel.Click += btnCancel_Click;
            // 
            // lblText
            // 
            lblText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblText.Font = new Font("Bahnschrift", 12F);
            lblText.ForeColor = Color.FromArgb(168, 171, 174);
            lblText.Location = new Point(12, 48);
            lblText.Name = "lblText";
            lblText.Size = new Size(417, 95);
            lblText.TabIndex = 9;
            lblText.Text = "Sign in below to access your account";
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Bahnschrift", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 27);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Welcome";
            // 
            // CustomMessageBoxView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(441, 210);
            Controls.Add(lblTitle);
            Controls.Add(lblText);
            Controls.Add(pnlBottom);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CustomMessageBoxView";
            StartPosition = FormStartPosition.CenterParent;
            pnlBottom.ResumeLayout(false);
            flp.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDecor;
        private Panel pnlBottom;
        private CustomButton btnOk;
        private CustomButton btnCancel;
        private FlowLayoutPanel flp;
        private Label lblText;
        private Label lblTitle;
    }
}