namespace a2_coursework.Theming {
    partial class TestView {
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
            customComboBox1 = new Custom_Controls.CustomComboBox();
            SuspendLayout();
            // 
            // customComboBox1
            // 
            customComboBox1.BackColor = Color.Black;
            customComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            customComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            customComboBox1.Font = new Font("Segoe UI", 12F);
            customComboBox1.ForeColor = Color.White;
            customComboBox1.FormattingEnabled = true;
            customComboBox1.Location = new Point(181, 49);
            customComboBox1.Name = "customComboBox1";
            customComboBox1.Size = new Size(140, 30);
            customComboBox1.TabIndex = 0;
            // 
            // TestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 242);
            Controls.Add(customComboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TestView";
            Text = "TestView";
            ResumeLayout(false);
        }

        #endregion

        private Custom_Controls.CustomComboBox customComboBox1;
    }
}