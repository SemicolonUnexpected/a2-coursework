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
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(9, 9, 10);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(2);
            btnDashboard.Size = new Size(202, 40);
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
            smdBooking.DropDownToggled = true;
            smdBooking.Location = new Point(0, 40);
            smdBooking.Name = "smdBooking";
            smdBooking.ParentName = "Bookings";
            smdBooking.Size = new Size(202, 160);
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
            smdCustomers.DropDownToggled = true;
            smdCustomers.Location = new Point(0, 200);
            smdCustomers.Name = "smdCustomers";
            smdCustomers.ParentName = "Customers";
            smdCustomers.Size = new Size(202, 160);
            smdCustomers.TabIndex = 2;
            // 
            // smdOrders
            // 
            smdOrders.BackColor = Color.FromArgb(9, 9, 10);
            smdOrders.ChildNames = new string[]
    {
    "Current stock",
    "Pending orders",
    "Manage stock"
    };
            smdOrders.Dock = DockStyle.Top;
            smdOrders.DropDownToggled = true;
            smdOrders.Location = new Point(0, 360);
            smdOrders.Name = "smdOrders";
            smdOrders.ParentName = "Orders";
            smdOrders.Size = new Size(202, 160);
            smdOrders.TabIndex = 3;
            // 
            // smdAnalytics
            // 
            smdAnalytics.BackColor = Color.FromArgb(9, 9, 10);
            smdAnalytics.ChildNames = new string[]
    {
    "Recent bookings",
    "Upcoming bookings",
    "Calendar"
    };
            smdAnalytics.Dock = DockStyle.Top;
            smdAnalytics.DropDownToggled = true;
            smdAnalytics.Location = new Point(0, 520);
            smdAnalytics.Name = "smdAnalytics";
            smdAnalytics.ParentName = "Analytics";
            smdAnalytics.Size = new Size(202, 160);
            smdAnalytics.TabIndex = 4;
            // 
            // smdUsers
            // 
            smdUsers.BackColor = Color.FromArgb(9, 9, 10);
            smdUsers.ChildNames = new string[]
    {
    "Recent bookings",
    "Upcoming bookings",
    "Calendar"
    };
            smdUsers.Dock = DockStyle.Top;
            smdUsers.DropDownToggled = true;
            smdUsers.Location = new Point(0, 680);
            smdUsers.Name = "smdUsers";
            smdUsers.ParentName = "Staff";
            smdUsers.Size = new Size(202, 160);
            smdUsers.TabIndex = 5;
            // 
            // smdSecurity
            // 
            smdSecurity.BackColor = Color.FromArgb(9, 9, 10);
            smdSecurity.ChildNames = new string[]
    {
    "Recent bookings",
    "Upcoming bookings",
    "Calendar"
    };
            smdSecurity.Dock = DockStyle.Top;
            smdSecurity.DropDownToggled = true;
            smdSecurity.Location = new Point(0, 840);
            smdSecurity.Name = "smdSecurity";
            smdSecurity.ParentName = "Security";
            smdSecurity.Size = new Size(202, 160);
            smdSecurity.TabIndex = 6;
            // 
            // smdSettings
            // 
            smdSettings.BackColor = Color.FromArgb(9, 9, 10);
            smdSettings.ChildNames = new string[]
    {
    "Recent bookings",
    "Upcoming bookings",
    "Calendar"
    };
            smdSettings.Dock = DockStyle.Top;
            smdSettings.DropDownToggled = true;
            smdSettings.Location = new Point(0, 1000);
            smdSettings.Name = "smdSettings";
            smdSettings.ParentName = "Settings";
            smdSettings.Size = new Size(202, 160);
            smdSettings.TabIndex = 7;
            // 
            // MainSideMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(smdSettings);
            Controls.Add(smdSecurity);
            Controls.Add(smdUsers);
            Controls.Add(smdAnalytics);
            Controls.Add(smdOrders);
            Controls.Add(smdCustomers);
            Controls.Add(smdBooking);
            Controls.Add(btnDashboard);
            DoubleBuffered = true;
            Name = "MainSideMenu";
            Size = new Size(202, 416);
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
    }
}
