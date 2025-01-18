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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterView));
            topBar = new UserControls.TopBar();
            sideMenu = new User_Controls.SideMenu.MainSideMenu();
            pnlDisplayHolder = new Panel();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.BackColor = Color.FromArgb(9, 9, 10);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(784, 40);
            topBar.TabIndex = 0;
            topBar.UsernameText = "test";
            // 
            // sideMenu
            // 
            sideMenu.BackColor = Color.FromArgb(9, 9, 10);
            sideMenu.Dock = DockStyle.Left;
            sideMenu.Location = new Point(0, 40);
            sideMenu.Name = "sideMenu";
            sideMenu.Size = new Size(202, 421);
            sideMenu.TabIndex = 1;
            // 
            // pnlDisplayHolder
            // 
            pnlDisplayHolder.Dock = DockStyle.Fill;
            pnlDisplayHolder.Location = new Point(202, 40);
            pnlDisplayHolder.Name = "pnlDisplayHolder";
            pnlDisplayHolder.Size = new Size(582, 421);
            pnlDisplayHolder.TabIndex = 2;
            // 
            // MasterView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(784, 461);
            Controls.Add(pnlDisplayHolder);
            Controls.Add(sideMenu);
            Controls.Add(topBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 500);
            Name = "MasterView";
            Text = "Master";
            Load += MasterView_Load;
            ResumeLayout(false);
        }

        #endregion
        private UserControls.SideMenu.SideMenuDropdown sideMenuDropDown1;
        private UserControls.TopBar topBar;
        private User_Controls.SideMenu.MainSideMenu sideMenu;
        private Panel pnlDisplayHolder;
    }
}