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
            flpLeft = new FlowLayoutPanel();
            flpRight = new FlowLayoutPanel();
            pnlCenter = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            flpLeft.SuspendLayout();
            flpRight.SuspendLayout();
            pnlCenter.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = Properties.Resources.Logo_Title_Condensed;
            pbLogo.Location = new Point(93, 5);
            pbLogo.Margin = new Padding(5);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(185, 30);
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
            btnSettings.Location = new Point(627, 5);
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
            lblUsername.Font = new Font("Bahnschrift", 16F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(667, 2);
            lblUsername.Margin = new Padding(5, 2, 5, 7);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(121, 30);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "username";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
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
            btnBack.Location = new Point(8, 5);
            btnBack.Margin = new Padding(8, 5, 5, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 30);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.TextAlign = CustomControls.CustomButtonAlign.TopCenter | CustomControls.CustomButtonAlign.BottomRight;
            btnBack.TextPosition = new Point(28, 6);
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(btnBack);
            flpLeft.Controls.Add(pbLogo);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(0, 0);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(293, 40);
            flpLeft.TabIndex = 4;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(lblUsername);
            flpRight.Controls.Add(btnSettings);
            flpRight.Dock = DockStyle.Fill;
            flpRight.FlowDirection = FlowDirection.RightToLeft;
            flpRight.Location = new Point(0, 0);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(793, 40);
            flpRight.TabIndex = 5;
            // 
            // pnlCenter
            // 
            pnlCenter.Anchor = AnchorStyles.None;
            pnlCenter.Controls.Add(flpLeft);
            pnlCenter.Controls.Add(flpRight);
            pnlCenter.Location = new Point(0, 0);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(793, 40);
            pnlCenter.TabIndex = 6;
            // 
            // TopBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(pnlCenter);
            Name = "TopBar";
            Size = new Size(793, 40);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            flpLeft.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            pnlCenter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private CustomControls.CustomButton btnSettings;
        private Label lblUsername;
        private CustomControls.CustomButton btnBack;
        private FlowLayoutPanel flpLeft;
        private FlowLayoutPanel flpRight;
        private Panel pnlCenter;
    }
}
