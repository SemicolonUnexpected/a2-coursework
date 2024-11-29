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
            pnlLeft = new Panel();
            label1 = new Label();
            customTextbox2 = new AS_Coursework.Custom_Controls.CustomTextbox();
            customTextbox1 = new AS_Coursework.Custom_Controls.CustomTextbox();
            pbShowPassword = new PictureBox();
            btnChangeTheme = new AS_Coursework.Custom_Controls.CustomButton();
            btnSignIn = new AS_Coursework.Custom_Controls.CustomButton();
            pbBackground = new AS_Coursework.Custom_Controls.PicturePanel();
            customRectangle1 = new AS_Coursework.Custom_Controls.CustomPanel();
            pnlLeft.SuspendLayout();
            customTextbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Anchor = AnchorStyles.None;
            pnlLeft.BackColor = Color.FromArgb(17, 24, 39);
            pnlLeft.Controls.Add(customRectangle1);
            pnlLeft.Controls.Add(label1);
            pnlLeft.Controls.Add(customTextbox2);
            pnlLeft.Controls.Add(customTextbox1);
            pnlLeft.Controls.Add(btnChangeTheme);
            pnlLeft.Controls.Add(btnSignIn);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(400, 461);
            pnlLeft.TabIndex = 0;
            pnlLeft.Paint += pnlLeft_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(125, 61);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // customTextbox2
            // 
            customTextbox2.BackColor = Color.FromArgb(17, 24, 39);
            customTextbox2.BorderColor = Color.White;
            customTextbox2.BorderFocusColor = Color.White;
            customTextbox2.BorderSize = 2;
            customTextbox2.CustomBorderStyle = AS_Coursework.Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            customTextbox2.Font = new Font("Bahnschrift", 14F);
            customTextbox2.ForeColor = Color.White;
            customTextbox2.IsMultiline = false;
            customTextbox2.Location = new Point(74, 118);
            customTextbox2.Margin = new Padding(25);
            customTextbox2.Name = "customTextbox2";
            customTextbox2.Padding = new Padding(7);
            customTextbox2.PlaceholderText = "Username";
            customTextbox2.PlaceholderTextColor = Color.White;
            customTextbox2.ShortcutEnabled = true;
            customTextbox2.Size = new Size(250, 38);
            customTextbox2.TabIndex = 3;
            customTextbox2.UsePasswordChar = false;
            // 
            // customTextbox1
            // 
            customTextbox1.BackColor = Color.FromArgb(17, 24, 39);
            customTextbox1.BorderColor = Color.White;
            customTextbox1.BorderFocusColor = Color.White;
            customTextbox1.BorderSize = 2;
            customTextbox1.Controls.Add(pbShowPassword);
            customTextbox1.CustomBorderStyle = AS_Coursework.Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            customTextbox1.Font = new Font("Bahnschrift", 14F);
            customTextbox1.ForeColor = Color.White;
            customTextbox1.IsMultiline = false;
            customTextbox1.Location = new Point(74, 183);
            customTextbox1.Margin = new Padding(25);
            customTextbox1.Name = "customTextbox1";
            customTextbox1.Padding = new Padding(7);
            customTextbox1.PlaceholderText = "Password";
            customTextbox1.PlaceholderTextColor = Color.White;
            customTextbox1.ShortcutEnabled = true;
            customTextbox1.Size = new Size(250, 38);
            customTextbox1.TabIndex = 2;
            customTextbox1.UsePasswordChar = true;
            // 
            // pbShowPassword
            // 
            pbShowPassword.Location = new Point(211, 2);
            pbShowPassword.Name = "pbShowPassword";
            pbShowPassword.Size = new Size(32, 32);
            pbShowPassword.TabIndex = 6;
            pbShowPassword.TabStop = false;
            // 
            // btnChangeTheme
            // 
            btnChangeTheme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeTheme.BackColor = Color.FromArgb(17, 24, 39);
            btnChangeTheme.BorderColor = Color.Transparent;
            btnChangeTheme.BorderWidth = 0;
            btnChangeTheme.CornerRadius = 16;
            btnChangeTheme.FlatAppearance.BorderSize = 0;
            btnChangeTheme.FlatStyle = FlatStyle.Flat;
            btnChangeTheme.ForeColor = Color.Black;
            btnChangeTheme.Image = Properties.Resources.SunWhite;
            btnChangeTheme.ImageSize = new Size(32, 32);
            btnChangeTheme.Location = new Point(361, 7);
            btnChangeTheme.Name = "btnChangeTheme";
            btnChangeTheme.Size = new Size(32, 32);
            btnChangeTheme.TabIndex = 1;
            btnChangeTheme.UseCompatibleTextRendering = true;
            btnChangeTheme.UseVisualStyleBackColor = false;
            btnChangeTheme.Click += btnChangeTheme_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.White;
            btnSignIn.BorderColor = Color.White;
            btnSignIn.BorderWidth = 0;
            btnSignIn.CornerRadius = 5;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.ForeColor = Color.Black;
            btnSignIn.Image = null;
            btnSignIn.ImageSize = new Size(150, 40);
            btnSignIn.Location = new Point(125, 249);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(150, 40);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += customButton1_Click;
            // 
            // pbBackground
            // 
            pbBackground.Anchor = AnchorStyles.None;
            pbBackground.Image = Properties.Resources.Moving_van_back;
            pbBackground.ImagePortion = new Rectangle(0, 0, 878, 700);
            pbBackground.Location = new Point(544, 61);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(62, 10);
            pbBackground.TabIndex = 1;
            // 
            // customRectangle1
            // 
            customRectangle1.BackColor = Color.Red;
            customRectangle1.BorderColor = Color.Empty;
            customRectangle1.BorderWidth = 0;
            customRectangle1.CornerRadius = 0;
            customRectangle1.Location = new Point(150, 325);
            customRectangle1.Name = "customRectangle1";
            customRectangle1.Size = new Size(218, 104);
            customRectangle1.TabIndex = 5;
            customRectangle1.Text = "customRectangle1";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 461);
            Controls.Add(pbBackground);
            Controls.Add(pnlLeft);
            MinimumSize = new Size(600, 500);
            Name = "LoginView";
            Text = "LoginView";
            Load += LoginView_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            customTextbox1.ResumeLayout(false);
            customTextbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private AS_Coursework.Custom_Controls.PicturePanel pbBackground;
        private Label label1;
        private AS_Coursework.Custom_Controls.CustomTextbox customTextbox2;
        private AS_Coursework.Custom_Controls.CustomTextbox customTextbox1;
        private AS_Coursework.Custom_Controls.CustomButton btnChangeTheme;
        private AS_Coursework.Custom_Controls.CustomButton btnSignIn;
        private Button button1;
        private PictureBox pbShowPassword;
        private AS_Coursework.Custom_Controls.CustomPanel customRectangle1;
    }
}