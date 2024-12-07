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
            customBindingButton2 = new Custom_Controls.CustomBindingButton();
            label4 = new Label();
            label2 = new Label();
            customBindingButton1 = new Custom_Controls.CustomBindingButton();
            label3 = new Label();
            customTextbox2 = new AS_Coursework.Custom_Controls.CustomTextbox();
            customTextbox1 = new AS_Coursework.Custom_Controls.CustomTextbox();
            pbShowPassword = new PictureBox();
            pbBackground = new AS_Coursework.Custom_Controls.PicturePanel();
            button2 = new Button();
            pnlLeft.SuspendLayout();
            customBindingButton1.SuspendLayout();
            customTextbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(17, 24, 39);
            pnlLeft.Controls.Add(button2);
            pnlLeft.Controls.Add(customBindingButton2);
            pnlLeft.Controls.Add(label4);
            pnlLeft.Controls.Add(label2);
            pnlLeft.Controls.Add(customBindingButton1);
            pnlLeft.Controls.Add(customTextbox2);
            pnlLeft.Controls.Add(customTextbox1);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(400, 461);
            pnlLeft.TabIndex = 0;
            // 
            // customBindingButton2
            // 
            customBindingButton2.Anchor = AnchorStyles.None;
            customBindingButton2.BackColor = SystemColors.Control;
            customBindingButton2.BorderClickedColor = Color.Empty;
            customBindingButton2.BorderColor = Color.Empty;
            customBindingButton2.BorderHoverColor = Color.Empty;
            customBindingButton2.BorderWidth = 0F;
            customBindingButton2.ClickedColor = Color.Empty;
            customBindingButton2.CornerRadius = 16;
            customBindingButton2.HoverColor = Color.Empty;
            customBindingButton2.Location = new Point(362, 12);
            customBindingButton2.Name = "customBindingButton2";
            customBindingButton2.Size = new Size(32, 32);
            customBindingButton2.TabIndex = 8;
            customBindingButton2.Text = "customBindingButton2";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(248, 250, 252);
            label4.Location = new Point(92, 118);
            label4.Name = "label4";
            label4.Size = new Size(204, 23);
            label4.TabIndex = 7;
            label4.Text = "Sign in to your account";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(248, 250, 252);
            label2.Location = new Point(90, 79);
            label2.Name = "label2";
            label2.Size = new Size(146, 39);
            label2.TabIndex = 6;
            label2.Text = "Welcome";
            // 
            // customBindingButton1
            // 
            customBindingButton1.Anchor = AnchorStyles.None;
            customBindingButton1.BackColor = Color.FromArgb(48, 154, 207);
            customBindingButton1.BorderClickedColor = Color.Empty;
            customBindingButton1.BorderColor = Color.Empty;
            customBindingButton1.BorderHoverColor = Color.Empty;
            customBindingButton1.BorderWidth = 0F;
            customBindingButton1.ClickedColor = Color.Empty;
            customBindingButton1.Controls.Add(label3);
            customBindingButton1.CornerRadius = 5;
            customBindingButton1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customBindingButton1.HoverColor = Color.Empty;
            customBindingButton1.Location = new Point(130, 322);
            customBindingButton1.Name = "customBindingButton1";
            customBindingButton1.Size = new Size(140, 30);
            customBindingButton1.TabIndex = 5;
            customBindingButton1.Text = "customBindingButton1";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(248, 250, 252);
            label3.Location = new Point(43, 6);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 0;
            label3.Text = "Sign in";
            // 
            // customTextbox2
            // 
            customTextbox2.Anchor = AnchorStyles.None;
            customTextbox2.BackColor = Color.FromArgb(17, 24, 39);
            customTextbox2.BorderColor = Color.FromArgb(248, 250, 252);
            customTextbox2.BorderFocusColor = Color.FromArgb(248, 250, 252);
            customTextbox2.BorderSize = 2;
            customTextbox2.CustomBorderStyle = AS_Coursework.Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            customTextbox2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTextbox2.ForeColor = Color.FromArgb(248, 250, 252);
            customTextbox2.IsMultiline = false;
            customTextbox2.Location = new Point(90, 180);
            customTextbox2.Margin = new Padding(12);
            customTextbox2.Name = "customTextbox2";
            customTextbox2.Padding = new Padding(7);
            customTextbox2.PlaceholderText = "Username";
            customTextbox2.PlaceholderTextColor = Color.FromArgb(248, 250, 252);
            customTextbox2.ShortcutEnabled = true;
            customTextbox2.Size = new Size(220, 34);
            customTextbox2.TabIndex = 3;
            customTextbox2.UsePasswordChar = false;
            // 
            // customTextbox1
            // 
            customTextbox1.BackColor = Color.FromArgb(17, 24, 39);
            customTextbox1.BorderColor = Color.FromArgb(248, 250, 252);
            customTextbox1.BorderFocusColor = Color.FromArgb(248, 250, 252);
            customTextbox1.BorderSize = 2;
            customTextbox1.Controls.Add(pbShowPassword);
            customTextbox1.CustomBorderStyle = AS_Coursework.Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            customTextbox1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTextbox1.ForeColor = Color.FromArgb(248, 250, 252);
            customTextbox1.IsMultiline = false;
            customTextbox1.Location = new Point(90, 238);
            customTextbox1.Margin = new Padding(12);
            customTextbox1.Name = "customTextbox1";
            customTextbox1.Padding = new Padding(7, 7, 26, 7);
            customTextbox1.PlaceholderText = "Password";
            customTextbox1.PlaceholderTextColor = Color.FromArgb(248, 250, 252);
            customTextbox1.ShortcutEnabled = true;
            customTextbox1.Size = new Size(220, 34);
            customTextbox1.TabIndex = 2;
            customTextbox1.UsePasswordChar = true;
            // 
            // pbShowPassword
            // 
            pbShowPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbShowPassword.BackgroundImage = Properties.Resources.EyeWhite;
            pbShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            pbShowPassword.Image = Properties.Resources.EyeWhite;
            pbShowPassword.Location = new Point(194, 4);
            pbShowPassword.Name = "pbShowPassword";
            pbShowPassword.Size = new Size(25, 25);
            pbShowPassword.TabIndex = 6;
            pbShowPassword.TabStop = false;
            // 
            // pbBackground
            // 
            pbBackground.Dock = DockStyle.Fill;
            pbBackground.Image = Properties.Resources.Moving_van_back;
            pbBackground.ImagePortion = new Rectangle(0, 0, 878, 700);
            pbBackground.Location = new Point(400, 0);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(384, 461);
            pbBackground.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(188, 392);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
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
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            customBindingButton1.ResumeLayout(false);
            customBindingButton1.PerformLayout();
            customTextbox1.ResumeLayout(false);
            customTextbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private AS_Coursework.Custom_Controls.PicturePanel pbBackground;
        private AS_Coursework.Custom_Controls.CustomTextbox customTextbox2;
        private AS_Coursework.Custom_Controls.CustomTextbox customTextbox1;
        private Button button1;
        private Label label2;
        private Custom_Controls.CustomBindingButton customBindingButton1;
        private PictureBox pbShowPassword;
        private Label label3;
        private Custom_Controls.CustomBindingButton customBindingButton2;
        private Label label4;
        private Button button2;
    }
}