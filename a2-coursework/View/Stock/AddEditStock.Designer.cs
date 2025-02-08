namespace a2_coursework.View.Stock {
    partial class AddEditStock {
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
            SuspendLayout();
            // 
            // topMenu
            // 
            topMenu.Anchor = AnchorStyles.None;
            topMenu.Location = new Point(169, 9);
            topMenu.Margin = new Padding(0);
            topMenu.MenuItems = new string[]
    {
    "Stock Details",
    "Quantity",
    "Warnings"
    };
            topMenu.Name = "topMenu";
            topMenu.SelectedIndex = 0;
            topMenu.Size = new Size(449, 49);
            topMenu.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Location = new Point(12, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 455);
            panel1.TabIndex = 25;
            // 
            // AddEditStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(800, 541);
            Controls.Add(panel1);
            Controls.Add(topMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEditStock";
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
    }
}