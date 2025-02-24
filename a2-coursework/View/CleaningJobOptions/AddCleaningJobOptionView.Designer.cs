namespace a2_coursework.View.Customer {
    partial class AddCleaningJobOptionView {
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
            components = new System.ComponentModel.Container();
            previousNextDoneBar = new User_Controls.CRUD.PreviousNextDoneBar();
            pnlHolder = new Panel();
            pnlTop = new Panel();
            lblTitle = new Label();
            btnBack = new CustomControls.CustomButton();
            toolTip = new ToolTip(components);
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // previousNextDoneBar
            // 
            previousNextDoneBar.BackColor = Color.FromArgb(9, 9, 10);
            previousNextDoneBar.Dock = DockStyle.Bottom;
            previousNextDoneBar.DoneVisible = true;
            previousNextDoneBar.Location = new Point(0, 459);
            previousNextDoneBar.Margin = new Padding(0);
            previousNextDoneBar.Name = "previousNextDoneBar";
            previousNextDoneBar.NextVisible = true;
            previousNextDoneBar.Padding = new Padding(2);
            previousNextDoneBar.PreviousVisible = true;
            previousNextDoneBar.Size = new Size(654, 41);
            previousNextDoneBar.TabIndex = 33;
            // 
            // pnlHolder
            // 
            pnlHolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlHolder.Location = new Point(0, 40);
            pnlHolder.Margin = new Padding(0);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(654, 419);
            pnlHolder.TabIndex = 31;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(btnBack);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(654, 40);
            pnlTop.TabIndex = 32;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.Font = new Font("Bahnschrift", 20F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(78, 0);
            lblTitle.Margin = new Padding(10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(499, 40);
            lblTitle.TabIndex = 26;
            lblTitle.Text = "Appearance";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            btnBack.ForeColor = Color.FromArgb(250, 250, 250);
            btnBack.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnBack.HoverColor = Color.FromArgb(39, 39, 42);
            btnBack.Image = Properties.Resources.chevron_left_light;
            btnBack.ImageRectangle = new Rectangle(6, 6, 24, 24);
            btnBack.Location = new Point(2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(36, 36);
            btnBack.TabIndex = 25;
            btnBack.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnBack.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnBack, "Back");
            // 
            // AddStaffView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(previousNextDoneBar);
            Controls.Add(pnlHolder);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStaffView";
            Text = "AddStaffView";
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private User_Controls.CRUD.PreviousNextDoneBar previousNextDoneBar;
        private Panel pnlHolder;
        private Panel pnlTop;
        private Label lblTitle;
        private CustomControls.CustomButton btnBack;
        private ToolTip toolTip;
    }
}
