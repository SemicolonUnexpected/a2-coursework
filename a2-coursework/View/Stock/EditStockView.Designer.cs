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
            panel1 = new Panel();
            approveChangesBar1 = new User_Controls.Settings.ApproveChangesBar();
            SuspendLayout();
            // 
            // topMenu
            // 
            topMenu.Dock = DockStyle.Top;
            topMenu.Location = new Point(0, 0);
            topMenu.Margin = new Padding(0);
            topMenu.MenuItems = new string[]
    {
    "Stock Details",
    "Quantity",
    "Warnings"
    };
            topMenu.Name = "topMenu";
            topMenu.SelectedIndex = 0;
            topMenu.Size = new Size(654, 40);
            topMenu.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 419);
            panel1.TabIndex = 25;
            // 
            // approveChangesBar1
            // 
            approveChangesBar1.BackColor = Color.FromArgb(9, 9, 10);
            approveChangesBar1.Dock = DockStyle.Bottom;
            approveChangesBar1.IsLoading = false;
            approveChangesBar1.Location = new Point(0, 459);
            approveChangesBar1.Name = "approveChangesBar1";
            approveChangesBar1.Size = new Size(654, 41);
            approveChangesBar1.TabIndex = 0;
            approveChangesBar1.ToolTipsActive = true;
            // 
            // EditStockView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(panel1);
            Controls.Add(topMenu);
            Controls.Add(approveChangesBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditStockView";
            Text = "AddEditStock";
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
        private Panel panel1;
        private User_Controls.Settings.ApproveChangesBar approveChangesBar1;
    }
}