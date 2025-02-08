namespace a2_coursework.CustomControls {
    partial class CustomNumericUpDown {
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
            btnDecrement = new CustomButton();
            btnIncrement = new CustomButton();
            tbValue = new CustomTextBox();
            SuspendLayout();
            // 
            // btnDecrement
            // 
            btnDecrement.BackColor = Color.FromArgb(9, 9, 10);
            btnDecrement.BorderColor = Color.FromArgb(39, 39, 42);
            btnDecrement.BorderThickness = 1F;
            btnDecrement.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnDecrement.ClickedColor = Color.FromArgb(39, 39, 42);
            btnDecrement.CornerRadii = new CornerRadiiF(10F, 10F, 10F, 10F);
            btnDecrement.DisabledBorderColor = Color.Empty;
            btnDecrement.DisabledColor = Color.Empty;
            btnDecrement.ForeColor = Color.FromArgb(250, 250, 250);
            btnDecrement.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnDecrement.HoverColor = Color.FromArgb(39, 39, 42);
            btnDecrement.Image = Properties.Resources.minus_light;
            btnDecrement.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnDecrement.Location = new Point(131, 0);
            btnDecrement.Name = "btnDecrement";
            btnDecrement.Size = new Size(40, 40);
            btnDecrement.TabIndex = 23;
            btnDecrement.TextAlign = CustomButtonAlign.TopLeft;
            btnDecrement.TextPosition = new Point(0, 0);
            // 
            // btnIncrement
            // 
            btnIncrement.BackColor = Color.FromArgb(9, 9, 10);
            btnIncrement.BorderColor = Color.FromArgb(39, 39, 42);
            btnIncrement.BorderThickness = 1F;
            btnIncrement.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnIncrement.ClickedColor = Color.FromArgb(39, 39, 42);
            btnIncrement.CornerRadii = new CornerRadiiF(10F, 10F, 10F, 10F);
            btnIncrement.DisabledBorderColor = Color.Empty;
            btnIncrement.DisabledColor = Color.Empty;
            btnIncrement.ForeColor = Color.FromArgb(250, 250, 250);
            btnIncrement.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnIncrement.HoverColor = Color.FromArgb(39, 39, 42);
            btnIncrement.Image = Properties.Resources.plus_light;
            btnIncrement.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnIncrement.Location = new Point(0, 0);
            btnIncrement.Name = "btnIncrement";
            btnIncrement.Size = new Size(40, 40);
            btnIncrement.TabIndex = 22;
            btnIncrement.TextAlign = CustomButtonAlign.TopLeft;
            btnIncrement.TextPosition = new Point(0, 0);
            // 
            // tbValue
            // 
            tbValue.BackColor = Color.FromArgb(9, 9, 10);
            tbValue.BorderColor = Color.FromArgb(39, 39, 42);
            tbValue.BorderThickness = 1F;
            tbValue.CornerRadii = new CornerRadiiF(10F, 10F, 10F, 10F);
            tbValue.Font = new Font("Bahnschrift", 12F);
            tbValue.ForeColor = Color.Empty;
            tbValue.HoverColor = Color.Empty;
            tbValue.Location = new Point(48, 0);
            tbValue.Margin = new Padding(5);
            tbValue.MaxLength = 256;
            tbValue.MultiLine = false;
            tbValue.Name = "tbValue";
            tbValue.PlaceholderText = "";
            tbValue.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbValue.ReadOnly = false;
            tbValue.Size = new Size(75, 40);
            tbValue.TabIndex = 21;
            tbValue.TextAlign = HorizontalAlignment.Center;
            tbValue.TextBoxInset = new Padding(10);
            tbValue.UsePasswordChar = false;
            tbValue.TextChanged += tbValue_TextChanged;
            tbValue.KeyPress += tbValue_KeyPress;
            tbValue.KeyDown += tbValue_KeyDown;
            tbValue.PreviewKeyDown += tbValue_PreviewKeyDown;
            tbValue.Leave += tbValue_Leave;
            // 
            // CustomNumericUpDown
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(btnDecrement);
            Controls.Add(btnIncrement);
            Controls.Add(tbValue);
            Name = "CustomNumericUpDown";
            Size = new Size(174, 41);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomButton btnDecrement;
        private CustomControls.CustomButton btnIncrement;
        private CustomControls.CustomTextBox tbValue;
    }
}
