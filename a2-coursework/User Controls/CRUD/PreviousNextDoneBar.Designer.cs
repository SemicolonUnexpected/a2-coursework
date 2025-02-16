namespace a2_coursework.User_Controls.CRUD {
    partial class PreviousNextDoneBar {
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
            btnBack = new CustomControls.CustomButton();
            pnlSpacer1 = new Panel();
            btnNext = new CustomControls.CustomButton();
            toolTip = new ToolTip(components);
            btnDone = new CustomControls.CustomButton();
            pnlSpacer2 = new Panel();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(9, 9, 10);
            btnBack.BackgroundImage = Properties.Resources.chevron_right_light;
            btnBack.BorderColor = Color.FromArgb(39, 39, 42);
            btnBack.BorderThickness = 1F;
            btnBack.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnBack.ClickedColor = Color.FromArgb(39, 39, 42);
            btnBack.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnBack.DisabledBorderColor = Color.Empty;
            btnBack.DisabledColor = Color.Empty;
            btnBack.Dock = DockStyle.Right;
            btnBack.ForeColor = Color.FromArgb(250, 250, 250);
            btnBack.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnBack.HoverColor = Color.FromArgb(39, 39, 42);
            btnBack.Image = Properties.Resources.chevron_left_light;
            btnBack.ImageRectangle = new Rectangle(6, 6, 25, 25);
            btnBack.Location = new Point(510, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(37, 37);
            btnBack.TabIndex = 13;
            btnBack.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnBack.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnBack, "Previous");
            btnBack.Click += btnBack_Click;
            // 
            // pnlSpacer1
            // 
            pnlSpacer1.Dock = DockStyle.Right;
            pnlSpacer1.Location = new Point(547, 2);
            pnlSpacer1.Name = "pnlSpacer1";
            pnlSpacer1.Size = new Size(5, 37);
            pnlSpacer1.TabIndex = 12;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(9, 9, 10);
            btnNext.BorderColor = Color.FromArgb(39, 39, 42);
            btnNext.BorderThickness = 1F;
            btnNext.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnNext.ClickedColor = Color.FromArgb(39, 39, 42);
            btnNext.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnNext.DisabledBorderColor = Color.Empty;
            btnNext.DisabledColor = Color.Empty;
            btnNext.Dock = DockStyle.Right;
            btnNext.ForeColor = Color.FromArgb(250, 250, 250);
            btnNext.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnNext.HoverColor = Color.FromArgb(39, 39, 42);
            btnNext.Image = Properties.Resources.chevron_right_light;
            btnNext.ImageRectangle = new Rectangle(6, 6, 25, 25);
            btnNext.Location = new Point(552, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(37, 37);
            btnNext.TabIndex = 11;
            btnNext.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnNext.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnNext, "Next");
            btnNext.Click += btnNext_Click;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(9, 9, 10);
            btnDone.BorderColor = Color.FromArgb(39, 39, 42);
            btnDone.BorderThickness = 1F;
            btnDone.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnDone.ClickedColor = Color.FromArgb(39, 39, 42);
            btnDone.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnDone.DisabledBorderColor = Color.Empty;
            btnDone.DisabledColor = Color.Empty;
            btnDone.Dock = DockStyle.Right;
            btnDone.ForeColor = Color.FromArgb(250, 250, 250);
            btnDone.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnDone.HoverColor = Color.FromArgb(39, 39, 42);
            btnDone.Image = Properties.Resources.check_light;
            btnDone.ImageRectangle = new Rectangle(6, 6, 25, 25);
            btnDone.Location = new Point(594, 2);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(37, 37);
            btnDone.TabIndex = 17;
            btnDone.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnDone.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnDone, "Done");
            btnDone.Click += btnDone_Click;
            // 
            // pnlSpacer2
            // 
            pnlSpacer2.Dock = DockStyle.Right;
            pnlSpacer2.Location = new Point(589, 2);
            pnlSpacer2.Name = "pnlSpacer2";
            pnlSpacer2.Size = new Size(5, 37);
            pnlSpacer2.TabIndex = 18;
            // 
            // PreviousNextDoneBar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(btnBack);
            Controls.Add(pnlSpacer1);
            Controls.Add(btnNext);
            Controls.Add(pnlSpacer2);
            Controls.Add(btnDone);
            Name = "PreviousNextDoneBar";
            Padding = new Padding(2);
            Size = new Size(633, 41);
            ResumeLayout(false);
        }

        #endregion
        private CustomControls.CustomButton btnBack;
        private Panel pnlSpacer1;
        private CustomControls.CustomButton btnNext;
        private ToolTip toolTip;
        private CustomControls.CustomButton btnDone;
        private Panel pnlSpacer2;
    }
}

