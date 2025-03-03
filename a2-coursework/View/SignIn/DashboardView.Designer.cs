namespace a2_coursework.View {
    partial class DashboardView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardView));
            pbLogoTitle = new PictureBox();
            toolTip = new ToolTip(components);
            label1 = new Label();
            customPanel2 = new a2_coursework.CustomControls.CustomPanel();
            label3 = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            customPanel1 = new a2_coursework.CustomControls.CustomPanel();
            label2 = new Label();
            dateInput1 = new a2_coursework.CustomControls.DateInput();
            dateInput2 = new a2_coursework.CustomControls.DateInput();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogoTitle).BeginInit();
            customPanel2.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogoTitle
            // 
            pbLogoTitle.Anchor = AnchorStyles.None;
            pbLogoTitle.Image = Properties.Resources.Logo_Title_Condensed;
            pbLogoTitle.Location = new Point(251, 22);
            pbLogoTitle.Name = "pbLogoTitle";
            pbLogoTitle.Size = new Size(282, 50);
            pbLogoTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoTitle.TabIndex = 0;
            pbLogoTitle.TabStop = false;
            // 
            // label1
            // 
            label1.AccessibleDescription = "Welcome";
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Bahnschrift", 24F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 85);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(746, 39);
            label1.TabIndex = 1;
            label1.Text = "Good afternoon, John Doe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.None;
            customPanel2.BorderColor = Color.FromArgb(39, 39, 42);
            customPanel2.BorderThickness = 1F;
            customPanel2.Controls.Add(dateInput2);
            customPanel2.Controls.Add(label3);
            customPanel2.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customPanel2.Location = new Point(20, 20);
            customPanel2.Margin = new Padding(20);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(300, 250);
            customPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AccessibleDescription = "Welcome";
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 20F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 10);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(134, 33);
            label3.TabIndex = 1;
            label3.Text = "Last login";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.None;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel.Controls.Add(customPanel2);
            flowLayoutPanel.Controls.Add(customPanel1);
            flowLayoutPanel.Location = new Point(52, 137);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(680, 290);
            flowLayoutPanel.TabIndex = 2;
            flowLayoutPanel.Resize += flowLayoutPanel_Resize;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.None;
            customPanel1.BorderColor = Color.FromArgb(39, 39, 42);
            customPanel1.BorderThickness = 1F;
            customPanel1.Controls.Add(label4);
            customPanel1.Controls.Add(dateInput1);
            customPanel1.Controls.Add(label2);
            customPanel1.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customPanel1.Location = new Point(360, 20);
            customPanel1.Margin = new Padding(20);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(300, 250);
            customPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AccessibleDescription = "Welcome";
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 10);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(287, 33);
            label2.TabIndex = 1;
            label2.Text = "Last password change";
            // 
            // dateInput1
            // 
            dateInput1.BorderColor = Color.FromArgb(39, 39, 42);
            dateInput1.BorderErrorColor = Color.Red;
            dateInput1.BorderThickness = 1F;
            dateInput1.Day = null;
            dateInput1.DayToolTip = "";
            dateInput1.Location = new Point(61, 110);
            dateInput1.MaxDate = null;
            dateInput1.MaximumSize = new Size(180, 70);
            dateInput1.MinDate = null;
            dateInput1.MinimumSize = new Size(180, 70);
            dateInput1.Month = null;
            dateInput1.MonthToolTip = "";
            dateInput1.Name = "dateInput1";
            dateInput1.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            dateInput1.ReadOnly = true;
            dateInput1.Size = new Size(180, 70);
            dateInput1.TabIndex = 2;
            dateInput1.ToolTipsActive = true;
            dateInput1.Year = null;
            dateInput1.YearToolTip = "";
            // 
            // dateInput2
            // 
            dateInput2.BorderColor = Color.FromArgb(39, 39, 42);
            dateInput2.BorderErrorColor = Color.Red;
            dateInput2.BorderThickness = 1F;
            dateInput2.Day = null;
            dateInput2.DayToolTip = "";
            dateInput2.Location = new Point(57, 110);
            dateInput2.MaxDate = null;
            dateInput2.MaximumSize = new Size(180, 70);
            dateInput2.MinDate = null;
            dateInput2.MinimumSize = new Size(180, 70);
            dateInput2.Month = null;
            dateInput2.MonthToolTip = "";
            dateInput2.Name = "dateInput2";
            dateInput2.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            dateInput2.ReadOnly = true;
            dateInput2.Size = new Size(180, 70);
            dateInput2.TabIndex = 2;
            dateInput2.ToolTipsActive = true;
            dateInput2.Year = null;
            dateInput2.YearToolTip = "";
            // 
            // label4
            // 
            label4.AccessibleDescription = "Sign in below to access your account";
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F);
            label4.ForeColor = Color.FromArgb(168, 171, 174);
            label4.Location = new Point(13, 53);
            label4.Name = "label4";
            label4.Size = new Size(228, 19);
            label4.TabIndex = 4;
            label4.Text = "Please change your password";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(flowLayoutPanel);
            Controls.Add(label1);
            Controls.Add(pbLogoTitle);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 500);
            Name = "DashboardView";
            Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)pbLogoTitle).EndInit();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbLogoTitle;
        private ToolTip toolTip;
        private Label label1;
        private CustomControls.CustomPanel customPanel2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel;
        private CustomControls.CustomPanel customPanel1;
        private Label label2;
        private CustomControls.DateInput dateInput2;
        private CustomControls.DateInput dateInput1;
        private Label label4;
    }
}