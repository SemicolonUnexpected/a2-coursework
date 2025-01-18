namespace a2_coursework.UserControls.SideMenu {
    partial class SideMenuDropdown {
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
            btn = new SideMenuButton();
            pnlDropDown = new Panel();
            pnlChildHolder = new Panel();
            pnlSpacer = new Panel();
            pnlDecor = new Panel();
            pnlDropDown.SuspendLayout();
            pnlSpacer.SuspendLayout();
            SuspendLayout();
            // 
            // btn
            // 
            btn.BackColor = Color.FromArgb(9, 9, 10);
            btn.Dock = DockStyle.Top;
            btn.IconImage = null;
            btn.Location = new Point(0, 0);
            btn.Margin = new Padding(41, 19, 41, 19);
            btn.Name = "btn";
            btn.Padding = new Padding(3);
            btn.Size = new Size(320, 40);
            btn.TabIndex = 9;
            btn.Click += btn_Click;
            btn.DoubleClick += btn_DoubleClick;
            // 
            // pnlDropDown
            // 
            pnlDropDown.BackColor = Color.FromArgb(9, 9, 10);
            pnlDropDown.Controls.Add(pnlChildHolder);
            pnlDropDown.Controls.Add(pnlSpacer);
            pnlDropDown.Dock = DockStyle.Top;
            pnlDropDown.Location = new Point(0, 40);
            pnlDropDown.Margin = new Padding(41, 19, 41, 19);
            pnlDropDown.Name = "pnlDropDown";
            pnlDropDown.Size = new Size(320, 40);
            pnlDropDown.TabIndex = 11;
            pnlDropDown.Visible = false;
            // 
            // pnlChildHolder
            // 
            pnlChildHolder.Dock = DockStyle.Fill;
            pnlChildHolder.Location = new Point(30, 0);
            pnlChildHolder.Margin = new Padding(41, 19, 41, 19);
            pnlChildHolder.Name = "pnlChildHolder";
            pnlChildHolder.Size = new Size(290, 40);
            pnlChildHolder.TabIndex = 9;
            // 
            // pnlSpacer
            // 
            pnlSpacer.Controls.Add(pnlDecor);
            pnlSpacer.Dock = DockStyle.Left;
            pnlSpacer.Location = new Point(0, 0);
            pnlSpacer.Margin = new Padding(41, 19, 41, 19);
            pnlSpacer.Name = "pnlSpacer";
            pnlSpacer.Padding = new Padding(10, 10, 5, 10);
            pnlSpacer.Size = new Size(30, 40);
            pnlSpacer.TabIndex = 8;
            // 
            // pnlDecor
            // 
            pnlDecor.BackColor = Color.FromArgb(39, 39, 42);
            pnlDecor.Dock = DockStyle.Right;
            pnlDecor.Location = new Point(24, 10);
            pnlDecor.Margin = new Padding(41, 19, 41, 19);
            pnlDecor.Name = "pnlDecor";
            pnlDecor.Size = new Size(1, 20);
            pnlDecor.TabIndex = 3;
            // 
            // SideMenuDropDown
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(pnlDropDown);
            Controls.Add(btn);
            Margin = new Padding(41, 19, 41, 19);
            Name = "SideMenuDropDown";
            Size = new Size(320, 80);
            pnlDropDown.ResumeLayout(false);
            pnlSpacer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SideMenuButton btn;
        private Panel pnlDropDown;
        private Panel pnlSpacer;
        private Panel pnlDecor;
        private Panel pnlChildHolder;
    }
}
