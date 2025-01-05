namespace a2_coursework.View {
    partial class LoginView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            customPanel1 = new CustomControls.CustomPanel();
            customTextBox2 = new CustomControls.CustomTextBox();
            customTextBox1 = new CustomControls.CustomTextBox();
            customBasicButton1 = new CustomControls.CustomBasicButton();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.None;
            customPanel1.BorderColor = Color.FromArgb(39, 39, 42);
            customPanel1.BorderThickness = 1F;
            customPanel1.Controls.Add(customTextBox2);
            customPanel1.Controls.Add(customTextBox1);
            customPanel1.Controls.Add(customBasicButton1);
            customPanel1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customPanel1.Location = new Point(42, 38);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(367, 374);
            customPanel1.TabIndex = 0;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox2.BorderColor = Color.FromArgb(39, 39, 42);
            customTextBox2.BorderThickness = 1.75F;
            customTextBox2.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox2.Font = new Font("Bahnschrift", 12F);
            customTextBox2.ForeColor = Color.WhiteSmoke;
            customTextBox2.HoverColor = Color.Empty;
            customTextBox2.Location = new Point(59, 145);
            customTextBox2.Name = "customTextBox2";
            customTextBox2.PlaceholderText = "Username";
            customTextBox2.PlaceholderTextColor = Color.FromArgb(82, 82, 87);
            customTextBox2.Size = new Size(250, 40);
            customTextBox2.TabIndex = 3;
            customTextBox2.TextBoxInset = new Padding(10);
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.FromArgb(9, 9, 10);
            customTextBox1.BorderColor = Color.FromArgb(39, 39, 42);
            customTextBox1.BorderThickness = 1.5F;
            customTextBox1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customTextBox1.Font = new Font("Bahnschrift", 12F);
            customTextBox1.ForeColor = Color.WhiteSmoke;
            customTextBox1.HoverColor = Color.Empty;
            customTextBox1.Location = new Point(59, 66);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "Username";
            customTextBox1.PlaceholderTextColor = Color.FromArgb(82, 82, 87);
            customTextBox1.Size = new Size(250, 40);
            customTextBox1.TabIndex = 2;
            customTextBox1.TextBoxInset = new Padding(10);
            // 
            // customBasicButton1
            // 
            customBasicButton1.BackColor = Color.White;
            customBasicButton1.BorderClickedColor = Color.Empty;
            customBasicButton1.BorderColor = Color.Empty;
            customBasicButton1.BorderHoverColor = Color.Empty;
            customBasicButton1.BorderThickness = 0F;
            customBasicButton1.ClickedColor = Color.Empty;
            customBasicButton1.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            customBasicButton1.Cursor = Cursors.Hand;
            customBasicButton1.Font = new Font("Bahnschrift", 12F);
            customBasicButton1.HoverColor = Color.FromArgb(226, 226, 226);
            customBasicButton1.Location = new Point(59, 191);
            customBasicButton1.Name = "customBasicButton1";
            customBasicButton1.Size = new Size(250, 40);
            customBasicButton1.TabIndex = 1;
            customBasicButton1.Text = "Sign in";
            customBasicButton1.TextAlign = CustomControls.ButtonTextAlign.MiddleCenter;
            customBasicButton1.TextPosition = new Point(96, 10);
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(customPanel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 500);
            Name = "LoginView";
            Text = "LoginView";
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomPanel customPanel1;
        private CustomControls.CustomBasicButton customBasicButton1;
        private CustomControls.CustomTextBox customTextBox1;
        private CustomControls.CustomTextBox customTextBox2;
    }
}