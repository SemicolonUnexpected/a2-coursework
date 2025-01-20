namespace a2_coursework.UserControls.SideMenu {
    partial class SideMenu {
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
            pnlHolder = new Panel();
            sb = new CustomControls.CustomScrollBar();
            pnlMenuHolder = new Panel();
            pnlHolder.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHolder
            // 
            pnlHolder.Controls.Add(sb);
            pnlHolder.Controls.Add(pnlMenuHolder);
            pnlHolder.Dock = DockStyle.Fill;
            pnlHolder.Location = new Point(0, 0);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(230, 294);
            pnlHolder.TabIndex = 9;
            // 
            // sb
            // 
            sb.BackColor = Color.FromArgb(9, 9, 10);
            sb.Dock = DockStyle.Right;
            sb.LargeChange = 50;
            sb.Location = new Point(220, 0);
            sb.Maximum = 100;
            sb.Minimum = 0;
            sb.MinimumThumbHeight = 30;
            sb.Name = "sb";
            sb.Padding = new Padding(2);
            sb.Size = new Size(10, 294);
            sb.SmallChange = 10;
            sb.TabIndex = 10;
            sb.Text = "customScrollBar1";
            sb.ThumbClickedColor = Color.FromArgb(39, 39, 42);
            sb.ThumbColor = Color.FromArgb(39, 39, 42);
            sb.ThumbCorderRadii = new CustomControls.CornerRadiiF(3F, 3F, 3F, 3F);
            sb.ThumbHoverColor = Color.FromArgb(39, 39, 42);
            sb.ValueChanged += sb_ValueChanged;
            // 
            // pnlMenuHolder
            // 
            pnlMenuHolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMenuHolder.BackColor = Color.FromArgb(9, 9, 10);
            pnlMenuHolder.Location = new Point(0, 0);
            pnlMenuHolder.Name = "pnlMenuHolder";
            pnlMenuHolder.Size = new Size(221, 320);
            pnlMenuHolder.TabIndex = 8;
            // 
            // SideMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlHolder);
            Name = "SideMenu";
            Size = new Size(230, 294);
            pnlHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHolder;
        private Panel pnlMenuHolder;
        private CustomControls.CustomScrollBar sb;
    }
}
