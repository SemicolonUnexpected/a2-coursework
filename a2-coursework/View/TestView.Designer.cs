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
            dateInput1 = new CustomControls.DateInput();
            button1 = new Button();
            SuspendLayout();
            // 
            // dateInput1
            // 
            dateInput1.BackColor = Color.FromArgb(255, 255, 192);
            dateInput1.BorderColor = Color.Gray;
            dateInput1.BorderErrorColor = Color.Red;
            dateInput1.BorderThickness = 1F;
            dateInput1.Day = 3;
            dateInput1.ForeColor = Color.RoyalBlue;
            dateInput1.Location = new Point(102, 121);
            dateInput1.MaxDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateInput1.MaximumSize = new Size(180, 68);
            dateInput1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateInput1.MinimumSize = new Size(180, 68);
            dateInput1.Month = 32;
            dateInput1.Name = "dateInput1";
            dateInput1.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            dateInput1.Size = new Size(180, 68);
            dateInput1.TabIndex = 5;
            dateInput1.Year = 0;
            // 
            // button1
            // 
            button1.Location = new Point(389, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 242);
            Controls.Add(button1);
            Controls.Add(dateInput1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TestView";
            Text = "TestView";
            ResumeLayout(false);
        }

        #endregion
        private CustomControls.DateInput dateInput1;
        private Button button1;
    }
}