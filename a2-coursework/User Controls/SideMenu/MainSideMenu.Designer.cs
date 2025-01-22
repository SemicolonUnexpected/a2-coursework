namespace a2_coursework.UserControls.SideMenu {
    partial class MainSideMenu {
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
            btnDashboard = new UserControls.SideMenu.SideMenuToggleButton();
            smdBooking = new UserControls.SideMenu.MenuDropdown();
            smdCustomers = new UserControls.SideMenu.MenuDropdown();
            smdOrders = new UserControls.SideMenu.MenuDropdown();
            smdAnalytics = new UserControls.SideMenu.MenuDropdown();
            smdUsers = new UserControls.SideMenu.MenuDropdown();
            smdSecurity = new UserControls.SideMenu.MenuDropdown();
            smdSettings = new UserControls.SideMenu.MenuDropdown();
            pnlMenuHolder = new Panel();
            sb = new CustomControls.CustomScrollBar();
            pnlDecor = new Panel();
            pnlHolder = new Panel();
            pnlMenuHolder.SuspendLayout();
            pnlHolder.SuspendLayout();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(9, 9, 10);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(2);
            btnDashboard.Size = new Size(191, 40);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.Toggled = true;
            // 
            // smdBooking
            // 
            smdBooking.BackColor = Color.FromArgb(9, 9, 10);
            smdBooking.ChildNames = new string[]
    {
    "Recent bookings",
    "Upcoming bookings",
    "Calendar"
    };
            smdBooking.Dock = DockStyle.Top;
            smdBooking.DropDownToggled = false;
            smdBooking.Location = new Point(0, 40);
            smdBooking.Margin = new Padding(0);
            smdBooking.Name = "smdBooking";
            smdBooking.ParentName = "Bookings";
            smdBooking.Size = new Size(191, 40);
            smdBooking.TabIndex = 1;
            smdBooking.DropDownItemToggleChanged += DropdownToggleChanged;
            // 
            // smdCustomers
            // 
            smdCustomers.BackColor = Color.FromArgb(9, 9, 10);
            smdCustomers.ChildNames = new string[]
    {
    "Recent customers",
    "View customers",
    "View locations"
    };
            smdCustomers.Dock = DockStyle.Top;
            smdCustomers.DropDownToggled = false;
            smdCustomers.Location = new Point(0, 80);
            smdCustomers.Margin = new Padding(0);
            smdCustomers.Name = "smdCustomers";
            smdCustomers.ParentName = "Customers";
            smdCustomers.Size = new Size(191, 40);
            smdCustomers.TabIndex = 2;
            smdCustomers.DropDownItemToggleChanged += DropdownToggleChanged;
            // 
            // smdOrders
            // 
            smdOrders.BackColor = Color.FromArgb(9, 9, 10);
            smdOrders.ChildNames = new string[]
    {
    "Current stock",
    "Pending orders",
    "Manage stock",
    "Stock usage"
    };
            smdOrders.Dock = DockStyle.Top;
            smdOrders.DropDownToggled = false;
            smdOrders.Location = new Point(0, 120);
            smdOrders.Margin = new Padding(0);
            smdOrders.Name = "smdOrders";
            smdOrders.ParentName = "Orders";
            smdOrders.Size = new Size(191, 40);
            smdOrders.TabIndex = 3;
            smdOrders.DropDownItemToggleChanged += DropdownToggleChanged;
            // 
            // smdAnalytics
            // 
            smdAnalytics.BackColor = Color.FromArgb(9, 9, 10);
            smdAnalytics.ChildNames = new string[]
    {
    "Overview",
    "Cleaning",
    "Cleaning Stock",
    };
            smdAnalytics.Dock = DockStyle.Top;
            smdAnalytics.DropDownToggled = false;
            smdAnalytics.Location = new Point(0, 160);
            smdAnalytics.Margin = new Padding(0);
            smdAnalytics.Name = "smdAnalytics";
            smdAnalytics.ParentName = "Analytics";
            smdAnalytics.Size = new Size(191, 40);
            smdAnalytics.TabIndex = 4;
            smdAnalytics.DropDownItemToggleChanged += DropdownToggleChanged;
            // 
            // smdUsers
            // 
            smdUsers.BackColor = Color.FromArgb(9, 9, 10);
            smdUsers.ChildNames = new string[]
    {
    "View staff",
    "Change password",
    "Business closure"
    };
            smdUsers.Dock = DockStyle.Top;
            smdUsers.DropDownToggled = false;
            smdUsers.Location = new Point(0, 200);
            smdUsers.Margin = new Padding(0);
            smdUsers.Name = "smdUsers";
            smdUsers.ParentName = "Staff";
            smdUsers.Size = new Size(191, 40);
            smdUsers.TabIndex = 5;
            smdUsers.DropDownItemToggleChanged += DropdownToggleChanged;
            // 
            // smdSecurity
            // 
            smdSecurity.BackColor = Color.FromArgb(9, 9, 10);
            smdSecurity.ChildNames = new string[]
    {
    "Login attempts",
    "Passwords"
    };
            smdSecurity.Dock = DockStyle.Top;
            smdSecurity.DropDownToggled = false;
            smdSecurity.Location = new Point(0, 240);
            smdSecurity.Margin = new Padding(0);
            smdSecurity.Name = "smdSecurity";
            smdSecurity.ParentName = "Security";
            smdSecurity.Size = new Size(191, 40);
            smdSecurity.TabIndex = 6;
            smdSecurity.TabStop = false;
            smdSecurity.DropDownItemToggleChanged += DropdownToggleChanged;
            // 
            // smdSettings
            // 
            smdSettings.BackColor = Color.FromArgb(9, 9, 10);
            smdSettings.ChildNames = new string[]
    {
    "Personal information",
    "Account statistics",
    "Appearance"
    };
            smdSettings.Dock = DockStyle.Top;
            smdSettings.DropDownToggled = false;
            smdSettings.Location = new Point(0, 280);
            smdSettings.Margin = new Padding(0);
            smdSettings.Name = "smdSettings";
            smdSettings.ParentName = "Settings";
            smdSettings.Size = new Size(191, 40);
            smdSettings.TabIndex = 7;
            smdSettings.DropDownItemToggleChanged += DropdownToggleChanged;
            // 
            // pnlMenuHolder
            // 
            pnlMenuHolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMenuHolder.BackColor = Color.FromArgb(9, 9, 10);
            pnlMenuHolder.Controls.Add(smdSettings);
            pnlMenuHolder.Controls.Add(smdSecurity);
            pnlMenuHolder.Controls.Add(smdUsers);
            pnlMenuHolder.Controls.Add(smdAnalytics);
            pnlMenuHolder.Controls.Add(smdOrders);
            pnlMenuHolder.Controls.Add(smdCustomers);
            pnlMenuHolder.Controls.Add(smdBooking);
            pnlMenuHolder.Controls.Add(btnDashboard);
            pnlMenuHolder.Location = new Point(0, 0);
            pnlMenuHolder.Name = "pnlMenuHolder";
            pnlMenuHolder.Size = new Size(191, 320);
            pnlMenuHolder.TabIndex = 8;
            // 
            // sb
            // 
            sb.Dock = DockStyle.Right;
            sb.LargeChange = 50;
            sb.Location = new Point(191, 0);
            sb.Maximum = 100;
            sb.Minimum = 0;
            sb.MinimumThumbHeight = 30;
            sb.Name = "sb";
            sb.Padding = new Padding(2);
            sb.Size = new Size(10, 320);
            sb.SmallChange = 10;
            sb.TabIndex = 9;
            sb.Text = "customScrollBar1";
            sb.ThumbClickedColor = Color.FromArgb(39, 39, 42);
            sb.ThumbColor = Color.FromArgb(39, 39, 42);
            sb.ThumbCorderRadii = new CustomControls.CornerRadiiF(3F, 3F, 3F, 3F);
            sb.ThumbHoverColor = Color.FromArgb(39, 39, 42);
            sb.ValueChanged += sb_ValueChanged;
            // 
            // pnlDecor
            // 
            pnlDecor.BackColor = Color.FromArgb(39, 39, 42);
            pnlDecor.Dock = DockStyle.Right;
            pnlDecor.Location = new Point(201, 0);
            pnlDecor.Name = "pnlDecor";
            pnlDecor.Size = new Size(1, 320);
            pnlDecor.TabIndex = 8;
            // 
            // pnlHolder
            // 
            pnlHolder.Controls.Add(pnlMenuHolder);
            pnlHolder.Dock = DockStyle.Fill;
            pnlHolder.Location = new Point(0, 0);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(191, 320);
            pnlHolder.TabIndex = 8;
            // 
            // MainSideMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(pnlHolder);
            Controls.Add(sb);
            Controls.Add(pnlDecor);
            DoubleBuffered = true;
            Name = "MainSideMenu";
            Size = new Size(202, 320);
            pnlMenuHolder.ResumeLayout(false);
            pnlHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UserControls.SideMenu.SideMenuToggleButton btnDashboard;
        private UserControls.SideMenu.MenuDropdown smdBooking;
        private UserControls.SideMenu.MenuDropdown smdCustomers;
        private UserControls.SideMenu.MenuDropdown smdOrders;
        private UserControls.SideMenu.MenuDropdown smdAnalytics;
        private UserControls.SideMenu.MenuDropdown smdUsers;
        private UserControls.SideMenu.MenuDropdown smdSecurity;
        private UserControls.SideMenu.MenuDropdown smdSettings;
        private Panel pnlMenuHolder;
        private CustomControls.CustomScrollBar sb;
        private Panel pnlDecor;
        private Panel pnlHolder;
    }
}
