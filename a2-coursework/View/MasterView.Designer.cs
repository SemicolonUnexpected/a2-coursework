namespace a2_coursework.View {
    partial class MasterView {
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
            topBar1 = new UserControls.TopBar();
            sideMenu1 = new UserControls.SideMenuTwo();
            SuspendLayout();
            // 
            // topBar1
            // 
            topBar1.BackColor = Color.FromArgb(9, 9, 10);
            topBar1.Dock = DockStyle.Top;
            topBar1.Location = new Point(0, 0);
            topBar1.Name = "topBar1";
            topBar1.Size = new Size(784, 40);
            topBar1.TabIndex = 0;
            topBar1.UsernameText = "test";
            // 
            // sideMenu1
            // 
            sideMenu1.AutoScroll = true;
            sideMenu1.BackColor = Color.FromArgb(9, 9, 10);
            sideMenu1.Dock = DockStyle.Left;
            sideMenu1.Location = new Point(0, 40);
            sideMenu1.Name = "sideMenu1";
            sideMenu1.Size = new Size(210, 421);
            sideMenu1.TabIndex = 1;
            // 
            // MasterView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(784, 461);
            Controls.Add(sideMenu1);
            Controls.Add(topBar1);
            MinimumSize = new Size(800, 500);
            Name = "MasterView";
            Text = "Master";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.TopBar topBar1;
        private UserControls.SideMenuTwo sideMenu1;
    }
}