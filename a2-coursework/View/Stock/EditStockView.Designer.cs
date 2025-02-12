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
            topMenu = new UserControls.TopMenu();
            pnlHolder = new Panel();
            approveChangesBar = new User_Controls.Settings.ApproveChangesBar();
            pnlMenu = new Panel();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // topMenu
            // 
            topMenu.Anchor = AnchorStyles.None;
            topMenu.Location = new Point(100, 0);
            topMenu.Margin = new Padding(100);
            topMenu.MenuItems = new string[]
    {
    "Stock Details",
    "Quantity",
    "Warnings"
    };
            topMenu.Name = "topMenu";
            topMenu.SelectedIndex = 0;
            topMenu.Size = new Size(516, 34);
            topMenu.TabIndex = 24;
            // 
            // pnlHolder
            // 
            pnlHolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlHolder.Location = new Point(0, 34);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(716, 425);
            pnlHolder.TabIndex = 25;
            // 
            // approveChangesBar
            // 
            approveChangesBar.BackColor = Color.FromArgb(9, 9, 10);
            approveChangesBar.Dock = DockStyle.Bottom;
            approveChangesBar.IsLoading = false;
            approveChangesBar.Location = new Point(0, 459);
            approveChangesBar.Name = "approveChangesBar";
            approveChangesBar.Size = new Size(716, 41);
            approveChangesBar.TabIndex = 0;
            approveChangesBar.ToolTipsActive = true;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(topMenu);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(716, 34);
            pnlMenu.TabIndex = 26;
            // 
            // EditStockView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(716, 500);
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

        private Label lblStock;
        private Label lblEditPromt;
        private CustomControls.CustomTextBox customTextBox2;
        private CustomControls.CustomPanel pnlDarkMode;
        private Label lblDarkModeDescription;
        private CustomControls.CustomRadioButton rbDarkMode;
        private Label lblDarkMode;
        private CustomControls.CustomRadioButton customRadioButton1;
        private UserControls.TopMenu topMenu;
        private Panel pnlHolder;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar;
        private Panel pnlMenu;
    }
}