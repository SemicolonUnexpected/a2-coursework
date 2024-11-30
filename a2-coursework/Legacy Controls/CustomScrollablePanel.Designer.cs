namespace AS_Coursework.Custom_Controls {
    partial class CustomScrollablePanel {
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
            pnlChild = new Panel();
            sb = new VScrollBar();
            SuspendLayout();
            // 
            // pnlChild
            // 
            pnlChild.Dock = DockStyle.Fill;
            pnlChild.Location = new Point(0, 0);
            pnlChild.Name = "pnlChild";
            pnlChild.Size = new Size(643, 600);
            pnlChild.TabIndex = 2;
            // 
            // sb
            // 
            sb.Dock = DockStyle.Right;
            sb.Location = new Point(643, 0);
            sb.Name = "sb";
            sb.Size = new Size(17, 600);
            sb.TabIndex = 3;
            // 
            // CustomScrollablePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            Controls.Add(pnlChild);
            Controls.Add(sb);
            Name = "CustomScrollablePanel";
            Size = new Size(660, 600);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlChild;
        private VScrollBar sb;
    }
}
