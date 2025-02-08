namespace a2_coursework.User_Controls.Settings {
    partial class ApproveChangesBar {
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
            pnlDecor = new Panel();
            btnSave = new CustomControls.CustomButton();
            btnCancel = new CustomControls.CustomButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            toolTip = new ToolTip(components);
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDecor
            // 
            pnlDecor.BackColor = Color.FromArgb(39, 39, 42);
            pnlDecor.Dock = DockStyle.Top;
            pnlDecor.Location = new Point(0, 0);
            pnlDecor.Name = "pnlDecor";
            pnlDecor.Size = new Size(528, 1);
            pnlDecor.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = SystemColors.Control;
            btnSave.BorderColor = Color.Empty;
            btnSave.BorderThickness = 0F;
            btnSave.ClickedBorderColor = Color.Empty;
            btnSave.ClickedColor = Color.FromArgb(226, 226, 226);
            btnSave.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnSave.Cursor = Cursors.Hand;
            btnSave.DisabledBorderColor = Color.Empty;
            btnSave.DisabledColor = Color.FromArgb(226, 226, 226);
            btnSave.Font = new Font("Bahnschrift", 12F);
            btnSave.ForeColor = Color.FromArgb(9, 9, 10);
            btnSave.HoverBorderColor = Color.Empty;
            btnSave.HoverColor = Color.FromArgb(226, 226, 226);
            btnSave.Image = null;
            btnSave.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnSave.Location = new Point(313, 5);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 13;
            btnSave.Text = "Done";
            btnSave.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnSave.TextPosition = new Point(26, 5);
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.BorderColor = Color.Empty;
            btnCancel.BorderThickness = 0F;
            btnCancel.ClickedBorderColor = Color.Empty;
            btnCancel.ClickedColor = Color.FromArgb(226, 226, 226);
            btnCancel.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DisabledBorderColor = Color.Empty;
            btnCancel.DisabledColor = Color.FromArgb(226, 226, 226);
            btnCancel.Font = new Font("Bahnschrift", 12F);
            btnCancel.ForeColor = Color.FromArgb(9, 9, 10);
            btnCancel.HoverBorderColor = Color.Empty;
            btnCancel.HoverColor = Color.FromArgb(226, 226, 226);
            btnCancel.Image = null;
            btnCancel.ImageRectangle = new Rectangle(0, 0, 0, 0);
            btnCancel.Location = new Point(423, 5);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = CustomControls.CustomButtonAlign.MiddleCenter;
            btnCancel.TextPosition = new Point(20, 5);
            toolTip.SetToolTip(btnCancel, "Reset any changes");
            btnCancel.Click += btnCancel_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(528, 39);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // ApproveChangesBar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlDecor);
            Name = "ApproveChangesBar";
            Size = new Size(528, 40);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDecor;
        private CustomControls.CustomButton btnSave;
        private CustomControls.CustomButton btnCancel;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolTip toolTip;
    }
}
