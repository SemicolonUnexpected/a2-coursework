namespace a2_coursework.View.Stock {
    partial class EditStockView {
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
            components = new System.ComponentModel.Container();
            topMenu = new UserControls.TopMenu();
            pnlHolder = new Panel();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            pnlMenu = new Panel();
            btnBack = new CustomControls.CustomButton();
            toolTip = new ToolTip(components);
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // topMenu
            // 
            topMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            topMenu.Location = new Point(132, 3);
            topMenu.Margin = new Padding(100);
            topMenu.MenuItems = new string[]
    {
    "Stock Details",
    "Quantity",
    "Warnings"
    };
            topMenu.Name = "topMenu";
            topMenu.SelectedIndex = 0;
            topMenu.Size = new Size(390, 34);
            topMenu.TabIndex = 24;
            // 
            // pnlHolder
            // 
            pnlHolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlHolder.Location = new Point(0, 40);
            pnlHolder.Margin = new Padding(0);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(654, 419);
            pnlHolder.TabIndex = 25;
            // 
            // approveChangesBar
            // 
            approveChangesBar.BackColor = Color.FromArgb(9, 9, 10);
            approveChangesBar.Dock = DockStyle.Bottom;
            approveChangesBar.IsLoading = false;
            approveChangesBar.Location = new Point(0, 459);
            approveChangesBar.Margin = new Padding(0);
            approveChangesBar.Name = "approveChangesBar";
            approveChangesBar.Size = new Size(654, 41);
            approveChangesBar.TabIndex = 0;
            approveChangesBar.ToolTipsActive = true;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnBack);
            pnlMenu.Controls.Add(topMenu);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(654, 40);
            pnlMenu.TabIndex = 26;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(9, 9, 10);
            btnBack.BackgroundImage = Properties.Resources.chevron_right_light;
            btnBack.BorderColor = Color.FromArgb(39, 39, 42);
            btnBack.BorderThickness = 1F;
            btnBack.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnBack.ClickedColor = Color.FromArgb(39, 39, 42);
            btnBack.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnBack.Cursor = Cursors.Hand;
            btnBack.DisabledBorderColor = Color.Empty;
            btnBack.DisabledColor = Color.Empty;
            btnBack.ForeColor = Color.FromArgb(250, 250, 250);
            btnBack.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnBack.HoverColor = Color.FromArgb(39, 39, 42);
            btnBack.Image = Properties.Resources.chevron_left_light;
            btnBack.ImageRectangle = new Rectangle(6, 6, 24, 24);
            btnBack.Location = new Point(4, 4);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(36, 36);
            btnBack.TabIndex = 25;
            btnBack.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnBack.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnBack, "Back");
            // 
            // EditStockView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(pnlHolder);
            Controls.Add(approveChangesBar);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditStockView";
            Text = "AddEditStock";
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UserControls.TopMenu topMenu;
        private Panel pnlHolder;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private Panel pnlMenu;
        private CustomControls.CustomButton btnBack;
        private ToolTip toolTip;
    }
}