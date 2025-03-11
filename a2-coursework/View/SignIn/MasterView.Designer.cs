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
            topBar = new a2_coursework.UserControls.TopBar();
            sideMenu = new a2_coursework.UserControls.SideMenu.SideMenu();
            pnlHolder = new Panel();
            pnlCover = new Panel();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.BackColor = Color.FromArgb(9, 9, 10);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(884, 40);
            topBar.TabIndex = 0;
            topBar.UsernameText = "test";
            // 
            // sideMenu
            // 
            sideMenu.Dock = DockStyle.Left;
            sideMenu.Location = new Point(0, 40);
            sideMenu.Name = "sideMenu";
            sideMenu.Size = new Size(230, 571);
            sideMenu.TabIndex = 1;
            sideMenu.PreviewSideMenuToggleChanged += sideMenu_PreviewSideMenuToggleChanged;
            // 
            // pnlHolder
            // 
            pnlHolder.Dock = DockStyle.Fill;
            pnlHolder.Location = new Point(230, 40);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(654, 571);
            pnlHolder.TabIndex = 12;
            // 
            // pnlCover
            // 
            pnlCover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCover.Location = new Point(0, 0);
            pnlCover.Name = "pnlCover";
            pnlCover.Size = new Size(916, 649);
            pnlCover.TabIndex = 13;
            // 
            // MasterView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(884, 611);
            Controls.Add(pnlCover);
            Controls.Add(pnlHolder);
            Controls.Add(sideMenu);
            Controls.Add(topBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 650);
            Name = "MasterView";
            Text = "Master";
            Shown += MasterView_Shown;
            ResumeLayout(false);
        }

        #endregion
        private UserControls.SideMenu.MenuDropdown sideMenuDropDown1;
        private UserControls.TopBar topBar;
        private UserControls.SideMenu.SideMenu sideMenu;
        private Panel pnlHolder;
        private Panel pnlCover;
    }
}