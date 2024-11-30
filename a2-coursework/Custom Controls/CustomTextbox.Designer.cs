using AS_Coursework.Custom_Controls;

namespace AS_Coursework.Custom_Controls {
    partial class CustomTextbox {
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
            tb = new ImprovedTextbox();
            SuspendLayout();
            // 
            // tb
            // 
            tb.BackColor = Color.FromArgb(20, 20, 50);
            tb.BorderStyle = BorderStyle.None;
            tb.Dock = DockStyle.Fill;
            tb.Location = new Point(7, 7);
            tb.Name = "tb";
            tb.Size = new Size(236, 23);
            tb.TabIndex = 0;
            // 
            // CustomTextbox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(20, 20, 50);
            Controls.Add(tb);
            Font = new Font("Bahnschrift", 14F);
            ForeColor = Color.White;
            Margin = new Padding(25);
            Name = "CustomTextbox";
            Padding = new Padding(7);
            Size = new Size(250, 33);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImprovedTextbox tb;
    }
}
