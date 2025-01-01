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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            improvedTextbox1 = new CustomControls.ImprovedTextbox();
            SuspendLayout();
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox1.BorderColor = Color.DarkGray;
            customTextBox1.BorderThickness = 1.5F;
            customTextBox1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox1.ForeColor = Color.AliceBlue;
            customTextBox1.InternalBackColor = Color.FromArgb(9, 9, 10);
            customTextBox1.InternalHoverColor = Color.Empty;
            customTextBox1.Location = new Point(207, 115);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Size = new Size(336, 35);
            customTextBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 197);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Test";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(342, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 43);
            textBox2.TabIndex = 2;
            textBox2.Text = "Test";
            // 
            // improvedTextbox1
            // 
            improvedTextbox1.AcceptsReturn = true;
            improvedTextbox1.BackColor = SystemColors.HotTrack;
            improvedTextbox1.Font = new Font("Segoe UI", 15F);
            improvedTextbox1.ForeColor = Color.FromArgb(255, 255, 128);
            improvedTextbox1.Location = new Point(78, 54);
            improvedTextbox1.Name = "improvedTextbox1";
            improvedTextbox1.PlaceholderText = "What the sigma";
            improvedTextbox1.PlaceholderTextColor = Color.Brown;
            improvedTextbox1.Size = new Size(652, 34);
            improvedTextbox1.TabIndex = 3;
            improvedTextbox1.Text = "Test";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(784, 461);
            Controls.Add(improvedTextbox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(customTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 500);
            Name = "LoginView";
            Padding = new Padding(20);
            Text = "LoginView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomTextBox customTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private CustomControls.ImprovedTextbox improvedTextbox1;
    }
}