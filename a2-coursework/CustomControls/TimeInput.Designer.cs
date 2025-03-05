namespace a2_coursework.CustomControls {
    partial class TimeInput {
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
            tbMinute = new CustomTextBox();
            tbHour = new CustomTextBox();
            lblDivider = new Label();
            SuspendLayout();
            // 
            // tbMinute
            // 
            tbMinute.BackColor = Color.FromArgb(9, 9, 10);
            tbMinute.BorderColor = Color.FromArgb(39, 39, 42);
            tbMinute.BorderThickness = 1F;
            tbMinute.CornerRadii = new CornerRadiiF(10F, 10F, 10F, 10F);
            tbMinute.Font = new Font("Bahnschrift", 12F);
            tbMinute.ForeColor = Color.FromArgb(250, 250, 250);
            tbMinute.HoverColor = Color.Empty;
            tbMinute.Location = new Point(56, 0);
            tbMinute.Margin = new Padding(2, 0, 0, 0);
            tbMinute.MaxLength = 2;
            tbMinute.MultiLine = false;
            tbMinute.Name = "tbMinute";
            tbMinute.PlaceholderText = "";
            tbMinute.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbMinute.ReadOnly = false;
            tbMinute.Size = new Size(38, 40);
            tbMinute.TabIndex = 1;
            tbMinute.Text = "00";
            tbMinute.TextAlign = HorizontalAlignment.Center;
            tbMinute.TextBoxInset = new Padding(9, 10, 9, 10);
            tbMinute.UsePasswordChar = false;
            tbMinute.TextChanged += tbMinute_TextChanged;
            tbMinute.KeyPress += tbMinute_KeyPress;
            tbMinute.Leave += tbMinute_Leave;
            // 
            // tbHour
            // 
            tbHour.BackColor = Color.FromArgb(9, 9, 10);
            tbHour.BorderColor = Color.FromArgb(39, 39, 42);
            tbHour.BorderThickness = 1F;
            tbHour.CornerRadii = new CornerRadiiF(10F, 10F, 10F, 10F);
            tbHour.Font = new Font("Bahnschrift", 12F);
            tbHour.ForeColor = Color.FromArgb(250, 250, 250);
            tbHour.HoverColor = Color.Empty;
            tbHour.Location = new Point(0, 0);
            tbHour.Margin = new Padding(0, 0, 2, 0);
            tbHour.MaxLength = 2;
            tbHour.MultiLine = false;
            tbHour.Name = "tbHour";
            tbHour.PlaceholderText = "";
            tbHour.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbHour.ReadOnly = false;
            tbHour.Size = new Size(38, 40);
            tbHour.TabIndex = 0;
            tbHour.Text = "00";
            tbHour.TextAlign = HorizontalAlignment.Center;
            tbHour.TextBoxInset = new Padding(9, 10, 9, 10);
            tbHour.UsePasswordChar = false;
            tbHour.TextChanged += tbHour_TextChanged;
            tbHour.KeyPress += tbHour_KeyPress;
            tbHour.Leave += tbHour_Leave;
            // 
            // lblDivider
            // 
            lblDivider.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDivider.ForeColor = Color.White;
            lblDivider.Location = new Point(37, 6);
            lblDivider.Margin = new Padding(0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(21, 27);
            lblDivider.TabIndex = 4;
            lblDivider.Text = ":";
            lblDivider.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimeInput
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(tbMinute);
            Controls.Add(tbHour);
            Controls.Add(lblDivider);
            MaximumSize = new Size(94, 40);
            MinimumSize = new Size(94, 40);
            Name = "TimeInput";
            Size = new Size(94, 40);
            ResumeLayout(false);
        }

        #endregion

        private CustomTextBox tbMinute;
        private CustomTextBox tbHour;
        private Label lblDivider;
    }
}
