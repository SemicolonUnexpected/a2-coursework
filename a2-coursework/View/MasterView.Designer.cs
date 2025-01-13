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
            topBar1 = new User_Controls.TopBar();
            SuspendLayout();
            // 
            // topBar1
            // 
            topBar1.BackButtonVisible = true;
            topBar1.BackColor = Color.FromArgb(9, 9, 10);
            topBar1.Dock = DockStyle.Top;
            topBar1.Gap = 0;
            topBar1.Location = new Point(0, 0);
            topBar1.Name = "topBar1";
            topBar1.SettingsButtonVisible = true;
            topBar1.Size = new Size(784, 40);
            topBar1.TabIndex = 0;
            topBar1.UsernameText = "test";
            // 
            // MasterView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(784, 461);
            Controls.Add(topBar1);
            MinimumSize = new Size(800, 500);
            Name = "MasterView";
            Text = "Master";
            ResumeLayout(false);
        }

        #endregion

        private User_Controls.TopBar topBar1;
    }
}