﻿namespace a2_coursework.Custom_Controls.Composed_Controls {
    partial class TextButton {
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
            customBindingButton1 = new CustomBindingButton();
            SuspendLayout();
            // 
            // customBindingButton1
            // 
            customBindingButton1.BackColor = Color.Cyan;
            customBindingButton1.BorderClickedColor = Color.Empty;
            customBindingButton1.BorderColor = Color.Empty;
            customBindingButton1.BorderHoverColor = Color.Empty;
            customBindingButton1.BorderWidth = 0F;
            customBindingButton1.ClickedColor = Color.Empty;
            customBindingButton1.CornerRadius = 5;
            customBindingButton1.Dock = DockStyle.Fill;
            customBindingButton1.HoverColor = Color.Empty;
            customBindingButton1.Location = new Point(0, 0);
            customBindingButton1.Name = "customBindingButton1";
            customBindingButton1.Size = new Size(150, 150);
            customBindingButton1.TabIndex = 0;
            customBindingButton1.Text = "customBindingButton1";
            // 
            // TextButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(customBindingButton1);
            Name = "TextButton";
            ResumeLayout(false);
        }

        #endregion

        private CustomBindingButton customBindingButton1;
    }
}
