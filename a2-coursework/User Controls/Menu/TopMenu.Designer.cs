namespace a2_coursework.UserControls {
    partial class TopMenu {
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
            flp = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flp
            // 
            flp.Dock = DockStyle.Fill;
            flp.Location = new Point(0, 0);
            flp.Name = "flp";
            flp.Size = new Size(533, 150);
            flp.TabIndex = 1;
            // 
            // TopMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(flp);
            Name = "TopMenu";
            Size = new Size(533, 150);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flp;
    }
}
