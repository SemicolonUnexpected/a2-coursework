namespace a2_coursework.User_Controls {
    partial class TopBar {
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
            pbLogo = new PictureBox();
            btnSettings = new CustomControls.CustomButton();
            lblUsername = new Label();
            btnBack = new CustomControls.CustomButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = Properties.Resources.Logo_Title_Condensed;
            pbLogo.Location = new Point(95, 5);
            pbLogo.Margin = new Padding(5);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(127, 30);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.None;
            btnSettings.BackColor = Color.FromArgb(9, 9, 10);
            btnSettings.BackgroundImage = Properties.Resources.settings_sliders_light;
            btnSettings.BorderColor = Color.Empty;
            btnSettings.BorderThickness = 0F;
            btnSettings.ClickedBorderColor = Color.Empty;
            btnSettings.ClickedColor = Color.Empty;
            btnSettings.CornerRadii = new CustomControls.CornerRadiiF(5F, 5F, 5F, 5F);
            btnSettings.DisabledBorderColor = Color.Empty;
            btnSettings.DisabledColor = Color.Empty;
            btnSettings.HoverBorderColor = Color.Empty;
            btnSettings.HoverColor = Color.Empty;
            btnSettings.ImageRectangle = new Rectangle(6, 6, 18, 18);
            btnSettings.Location = new Point(137, 5);
            btnSettings.Margin = new Padding(5);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(30, 30);
            btnSettings.TabIndex = 2;
            btnSettings.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnSettings.TextPosition = new Point(0, 0);
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 16F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(177, 6);
            lblUsername.Margin = new Padding(5, 5, 10, 5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(111, 27);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "username";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            lblUsername.Click += lblUsername_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(9, 9, 10);
            btnBack.BackgroundImage = Properties.Resources.chevron_left_light;
            btnBack.BorderColor = Color.Empty;
            btnBack.BorderThickness = 0F;
            btnBack.ClickedBorderColor = Color.Empty;
            btnBack.ClickedColor = Color.Empty;
            btnBack.CornerRadii = new CustomControls.CornerRadiiF(5F, 5F, 5F, 5F);
            btnBack.DisabledBorderColor = Color.Empty;
            btnBack.DisabledColor = Color.Empty;
            btnBack.Font = new Font("Bahnschrift", 10F);
            btnBack.ForeColor = Color.FromArgb(250, 250, 250);
            btnBack.HoverBorderColor = Color.Empty;
            btnBack.HoverColor = Color.Empty;
            btnBack.ImageRectangle = new Rectangle(5, 5, 20, 20);
            btnBack.Location = new Point(10, 5);
            btnBack.Margin = new Padding(10, 5, 5, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 30);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.TextAlign = CustomControls.CustomButtonAlign.TopCenter | CustomControls.CustomButtonAlign.BottomRight;
            btnBack.TextPosition = new Point(28, 6);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnBack);
            flowLayoutPanel1.Controls.Add(pbLogo);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(229, 40);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(lblUsername);
            flowLayoutPanel2.Controls.Add(btnSettings);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(495, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(298, 40);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 42);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 1);
            panel1.TabIndex = 6;
            // 
            // TopBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Name = "TopBar";
            Size = new Size(793, 41);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private CustomControls.CustomButton btnSettings;
        private Label lblUsername;
        private CustomControls.CustomButton btnBack;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
    }
}
