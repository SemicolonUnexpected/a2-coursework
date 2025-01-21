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
            sideMenu = new UserControls.SideMenu.SideMenu();
            sb = new CustomControls.CustomScrollBar();
            pnlHolder = new Panel();
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
            // 
            // sb
            // 
            sb.BackColor = Color.FromArgb(9, 9, 10);
            sb.Dock = DockStyle.Right;
            sb.LargeChange = 50;
            sb.Location = new Point(874, 40);
            sb.Maximum = 100;
            sb.Minimum = 0;
            sb.MinimumThumbHeight = 30;
            sb.Name = "sb";
            sb.Padding = new Padding(2);
            sb.Size = new Size(10, 571);
            sb.SmallChange = 10;
            sb.TabIndex = 11;
            sb.Text = "customScrollBar1";
            sb.ThumbClickedColor = Color.FromArgb(39, 39, 42);
            sb.ThumbColor = Color.FromArgb(39, 39, 42);
            sb.ThumbCorderRadii = new CustomControls.CornerRadiiF(3F, 3F, 3F, 3F);
            sb.ThumbHoverColor = Color.FromArgb(39, 39, 42);
            sb.Visible = false;
            sb.ValueChanged += sb_ValueChanged;
            // 
            // pnlHolder
            // 
            pnlHolder.Dock = DockStyle.Fill;
            pnlHolder.Location = new Point(230, 40);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(644, 571);
            pnlHolder.TabIndex = 12;
            // 
            // MasterView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(884, 611);
            Controls.Add(pnlHolder);
            Controls.Add(sb);
            Controls.Add(sideMenu);
            Controls.Add(topBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 650);
            Name = "MasterView";
            Text = "Master";
            ResumeLayout(false);
        }

        #endregion
        private UserControls.SideMenu.SideMenuDropdown sideMenuDropDown1;
        private UserControls.TopBar topBar;
        private UserControls.SideMenu.SideMenu sideMenu;
        private CustomControls.CustomScrollBar sb;
        private Panel pnlHolder;
    }
}