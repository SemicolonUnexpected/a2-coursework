namespace a2_coursework.CustomControls {
    partial class CustomTextBox {
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
            components = new System.ComponentModel.Container();
            pnl = new CustomPanel();
            tb = new ImprovedTextBox();
            toolTip = new ToolTip(components);
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // pnl
            // 
            pnl.BackColor = Color.FromArgb(9, 9, 10);
            pnl.BorderColor = Color.Empty;
            pnl.BorderThickness = 0F;
            pnl.Controls.Add(tb);
            pnl.CornerRadii = new CornerRadiiF(10F, 10F, 10F, 10F);
            pnl.Location = new Point(0, 0);
            pnl.Name = "pnl";
            pnl.Padding = new Padding(10);
            pnl.Size = new Size(336, 36);
            pnl.TabIndex = 0;
            pnl.MouseHover += AnyHover;
            // 
            // tb
            // 
            tb.BackColor = Color.FromArgb(9, 9, 10);
            tb.BorderStyle = BorderStyle.None;
            tb.Dock = DockStyle.Fill;
            tb.ForeColor = Color.White;
            tb.Location = new Point(10, 10);
            tb.Name = "tb";
            tb.PlaceholderTextColor = Color.Empty;
            tb.Size = new Size(316, 16);
            tb.TabIndex = 0;
            tb.MouseHover += AnyHover;
            // 
            // CustomTextBox
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(pnl);
            Name = "CustomTextBox";
            Size = new Size(336, 36);
            Click += CustomTextBox_Click;
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomPanel pnl;
        private ImprovedTextBox tb;
        private ToolTip toolTip;
    }
}
