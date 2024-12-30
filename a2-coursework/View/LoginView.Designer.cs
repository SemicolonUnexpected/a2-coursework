namespace a2_coursework.View {
    partial class LoginView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            customTextBox1 = new CustomControls.CustomTextBox();
            SuspendLayout();
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox1.BorderColor = Color.DarkGray;
            customTextBox1.BorderThickness = 1.5F;
            customTextBox1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox1.InternalBackColor = Color.FromArgb(9, 9, 10);
            customTextBox1.Location = new Point(207, 115);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Size = new Size(336, 35);
            customTextBox1.TabIndex = 0;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(784, 461);
            Controls.Add(customTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 500);
            Name = "LoginView";
            Padding = new Padding(20);
            Text = "LoginView";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomTextBox customTextBox1;
    }
}