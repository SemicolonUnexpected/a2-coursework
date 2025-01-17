namespace a2_coursework.User_Controls.SideMenu {
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
            smdBooking = new UserControls.SideMenu.SideMenuDropDown();
            smdCustomers = new UserControls.SideMenu.SideMenuDropDown();
            smdOrders = new UserControls.SideMenu.SideMenuDropDown();
            smdAnalytics = new UserControls.SideMenu.SideMenuDropDown();
            smdUsers = new UserControls.SideMenu.SideMenuDropDown();
            smdSecurity = new UserControls.SideMenu.SideMenuDropDown();
            smdSettings = new UserControls.SideMenu.SideMenuDropDown();
            pnlMenuHolder = new Panel();
            customScrollBar1 = new CustomControls.CustomScrollBar();
            pnlMenuHolder.SuspendLayout();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(9, 9, 10);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(2);
            btnDashboard.Size = new Size(139, 40);
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
            smdBooking.Name = "smdBooking";
            smdBooking.ParentName = "Bookings";
            smdBooking.Size = new Size(139, 40);
            smdBooking.TabIndex = 1;
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
            smdCustomers.Name = "smdCustomers";
            smdCustomers.ParentName = "Customers";
            smdCustomers.Size = new Size(139, 40);
            smdCustomers.TabIndex = 2;
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
            smdOrders.Name = "smdOrders";
            smdOrders.ParentName = "Orders";
            smdOrders.Size = new Size(139, 40);
            smdOrders.TabIndex = 3;
            // 
            // smdAnalytics
            // 
            smdAnalytics.BackColor = Color.FromArgb(9, 9, 10);
            smdAnalytics.ChildNames = new string[]
    {
    "Stock",
    "Upcoming bookings",
    "Calendar",
    "Holidays"
    };
            smdAnalytics.Dock = DockStyle.Top;
            smdAnalytics.DropDownToggled = false;
            smdAnalytics.Location = new Point(0, 160);
            smdAnalytics.Name = "smdAnalytics";
            smdAnalytics.ParentName = "Analytics";
            smdAnalytics.Size = new Size(139, 40);
            smdAnalytics.TabIndex = 4;
            // 
            // smdUsers
            // 
            smdUsers.BackColor = Color.FromArgb(9, 9, 10);
            smdUsers.ChildNames = new string[]
    {
    "View staff",
    "Change password"
    };
            smdUsers.Dock = DockStyle.Top;
            smdUsers.DropDownToggled = false;
            smdUsers.Location = new Point(0, 200);
            smdUsers.Name = "smdUsers";
            smdUsers.ParentName = "Staff";
            smdUsers.Size = new Size(139, 40);
            smdUsers.TabIndex = 5;
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
            smdSecurity.Name = "smdSecurity";
            smdSecurity.ParentName = "Security";
            smdSecurity.Size = new Size(139, 40);
            smdSecurity.TabIndex = 6;
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
            smdSettings.Name = "smdSettings";
            smdSettings.ParentName = "Settings";
            smdSettings.Size = new Size(139, 40);
            smdSettings.TabIndex = 7;
            // 
            // pnlMenuHolder
            // 
            pnlMenuHolder.Controls.Add(smdSettings);
            pnlMenuHolder.Controls.Add(smdSecurity);
            pnlMenuHolder.Controls.Add(smdUsers);
            pnlMenuHolder.Controls.Add(smdAnalytics);
            pnlMenuHolder.Controls.Add(smdOrders);
            pnlMenuHolder.Controls.Add(smdCustomers);
            pnlMenuHolder.Controls.Add(smdBooking);
            pnlMenuHolder.Controls.Add(btnDashboard);
            pnlMenuHolder.Location = new Point(3, 3);
            pnlMenuHolder.Name = "pnlMenuHolder";
            pnlMenuHolder.Size = new Size(139, 401);
            pnlMenuHolder.TabIndex = 8;
            // 
            // customScrollBar1
            // 
            customScrollBar1.LargeChange = 50;
            customScrollBar1.Location = new Point(164, 43);
            customScrollBar1.Maximum = 100;
            customScrollBar1.Minimum = 0;
            customScrollBar1.MinimumThumbHeight = 30;
            customScrollBar1.Name = "customScrollBar1";
            customScrollBar1.Padding = new Padding(2);
            customScrollBar1.Size = new Size(23, 657);
            customScrollBar1.SmallChange = 10;
            customScrollBar1.TabIndex = 9;
            customScrollBar1.Text = "customScrollBar1";
            customScrollBar1.ThumbClickedColor = Color.FromArgb(39, 39, 42);
            customScrollBar1.ThumbColor = Color.FromArgb(39, 39, 42);
            customScrollBar1.ThumbCorderRadii = new CustomControls.CornerRadiiF(3F, 3F, 3F, 3F);
            customScrollBar1.ThumbHoverColor = Color.FromArgb(39, 39, 42);
            customScrollBar1.Value = 0;
            // 
            // MainSideMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(customScrollBar1);
            Controls.Add(pnlMenuHolder);
            DoubleBuffered = true;
            Name = "MainSideMenu";
            Size = new Size(202, 1018);
            pnlMenuHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UserControls.SideMenu.SideMenuToggleButton btnDashboard;
        private UserControls.SideMenu.SideMenuDropDown smdBooking;
        private UserControls.SideMenu.SideMenuDropDown smdCustomers;
        private UserControls.SideMenu.SideMenuDropDown smdOrders;
        private UserControls.SideMenu.SideMenuDropDown smdAnalytics;
        private UserControls.SideMenu.SideMenuDropDown smdUsers;
        private UserControls.SideMenu.SideMenuDropDown smdSecurity;
        private UserControls.SideMenu.SideMenuDropDown smdSettings;
        private Panel pnlMenuHolder;
        private CustomControls.CustomScrollBar customScrollBar1;
    }
}
