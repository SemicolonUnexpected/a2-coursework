namespace a2_coursework.User_Controls.Menu {
    partial class TopMenuItem {
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
            pnlDecor = new Panel();
            lbl = new Label();
            SuspendLayout();
            // 
            // pnlDecor
            // 
            pnlDecor.BackColor = Color.FromArgb(39, 39, 42);
            pnlDecor.Dock = DockStyle.Bottom;
            pnlDecor.Location = new Point(0, 45);
            pnlDecor.Margin = new Padding(41, 19, 41, 19);
            pnlDecor.Name = "pnlDecor";
            pnlDecor.Size = new Size(263, 2);
            pnlDecor.TabIndex = 4;
            pnlDecor.Visible = false;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl.Font = new Font("Bahnschrift", 14F);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(0, 12);
            lbl.Margin = new Padding(5);
            lbl.Name = "lbl";
            lbl.Size = new Size(263, 23);
            lbl.TabIndex = 19;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TopMenuItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(lbl);
            Controls.Add(pnlDecor);
            Name = "TopMenuItem";
            Size = new Size(263, 47);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDecor;
        private Label lbl;
    }
}
