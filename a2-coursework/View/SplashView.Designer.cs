namespace a2_coursework.View {
    partial class SplashView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashView));
            pnlProgress = new Panel();
            pb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // pnlProgress
            // 
            pnlProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProgress.BackColor = Color.FromArgb(212, 0, 0);
            pnlProgress.Location = new Point(0, 297);
            pnlProgress.Name = "pnlProgress";
            pnlProgress.Size = new Size(0, 3);
            pnlProgress.TabIndex = 0;
            // 
            // pb
            // 
            pb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb.Image = Properties.Resources.Logo_Title_Condensed;
            pb.Location = new Point(100, 100);
            pb.Name = "pb";
            pb.Size = new Size(300, 100);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.TabIndex = 1;
            pb.TabStop = false;
            // 
            // SplashView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 11);
            ClientSize = new Size(500, 300);
            ControlBox = false;
            Controls.Add(pb);
            Controls.Add(pnlProgress);
            Cursor = Cursors.AppStarting;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "SplashView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlProgress;
        private PictureBox pb;
    }
}