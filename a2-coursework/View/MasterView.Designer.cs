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
            SuspendLayout();
            // 
            // MasterView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(784, 461);
            MinimumSize = new Size(800, 500);
            Name = "MasterView";
            Text = "Master";
            Load += MasterView_Load;
            ResumeLayout(false);
        }

        #endregion
        private UserControls.SideMenu.SideMenuDropDown sideMenuDropDown1;
    }
}