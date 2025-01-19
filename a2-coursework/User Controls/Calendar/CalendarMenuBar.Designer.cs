namespace a2_coursework.User_Controls.Calendar {
    partial class CalendarMenuBar {
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
            tbSearch = new CustomControls.CustomTextBox();
            pbSearchBtn = new PictureBox();
            btnForward = new CustomControls.CustomButton();
            pnlSpacer4 = new Panel();
            btnBack = new CustomControls.CustomButton();
            btnNavigate = new CustomControls.CustomButton();
            pnlSpacer3 = new Panel();
            btnAdd = new CustomControls.CustomButton();
            pnlSpacer2 = new Panel();
            pnlSpacer1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbSearchBtn).BeginInit();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(9, 9, 10);
            tbSearch.BorderColor = Color.FromArgb(39, 39, 42);
            tbSearch.BorderThickness = 1F;
            tbSearch.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            tbSearch.Dock = DockStyle.Fill;
            tbSearch.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.ForeColor = Color.FromArgb(250, 250, 250);
            tbSearch.HoverColor = Color.Empty;
            tbSearch.Location = new Point(0, 0);
            tbSearch.MaxLength = 32767;
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search";
            tbSearch.PlaceholderTextColor = Color.FromArgb(168, 171, 174);
            tbSearch.Size = new Size(443, 40);
            tbSearch.TabIndex = 0;
            tbSearch.TextBoxInset = new Padding(45, 10, 10, 10);
            tbSearch.UsePasswordChar = false;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // pbSearchBtn
            // 
            pbSearchBtn.Image = Properties.Resources.search_light;
            pbSearchBtn.Location = new Point(9, 6);
            pbSearchBtn.Name = "pbSearchBtn";
            pbSearchBtn.Size = new Size(30, 30);
            pbSearchBtn.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearchBtn.TabIndex = 0;
            pbSearchBtn.TabStop = false;
            pbSearchBtn.Click += pbSearchBtn_Click;
            // 
            // btnForward
            // 
            btnForward.BackColor = Color.FromArgb(9, 9, 10);
            btnForward.BorderColor = Color.FromArgb(39, 39, 42);
            btnForward.BorderThickness = 1F;
            btnForward.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnForward.ClickedColor = Color.FromArgb(39, 39, 42);
            btnForward.CornerRadii = new CustomControls.CornerRadiiF(5F, 5F, 5F, 5F);
            btnForward.DisabledBorderColor = Color.Empty;
            btnForward.DisabledColor = Color.Empty;
            btnForward.Dock = DockStyle.Right;
            btnForward.ForeColor = Color.FromArgb(250, 250, 250);
            btnForward.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnForward.HoverColor = Color.FromArgb(39, 39, 42);
            btnForward.Image = Properties.Resources.chevron_right_light;
            btnForward.ImageRectangle = new Rectangle(6, 5, 30, 30);
            btnForward.Location = new Point(603, 0);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(40, 40);
            btnForward.TabIndex = 1;
            btnForward.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnForward.TextPosition = new Point(0, 0);
            btnForward.Click += btnForward_Click;
            // 
            // pnlSpacer4
            // 
            pnlSpacer4.Dock = DockStyle.Right;
            pnlSpacer4.Location = new Point(593, 0);
            pnlSpacer4.Name = "pnlSpacer4";
            pnlSpacer4.Size = new Size(10, 40);
            pnlSpacer4.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(9, 9, 10);
            btnBack.BorderColor = Color.FromArgb(39, 39, 42);
            btnBack.BorderThickness = 1F;
            btnBack.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnBack.ClickedColor = Color.FromArgb(39, 39, 42);
            btnBack.CornerRadii = new CustomControls.CornerRadiiF(5F, 5F, 5F, 5F);
            btnBack.DisabledBorderColor = Color.Empty;
            btnBack.DisabledColor = Color.Empty;
            btnBack.Dock = DockStyle.Right;
            btnBack.ForeColor = Color.FromArgb(250, 250, 250);
            btnBack.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnBack.HoverColor = Color.FromArgb(39, 39, 42);
            btnBack.Image = Properties.Resources.chevron_left_light;
            btnBack.ImageRectangle = new Rectangle(6, 5, 30, 30);
            btnBack.Location = new Point(553, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 40);
            btnBack.TabIndex = 2;
            btnBack.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnBack.TextPosition = new Point(0, 0);
            btnBack.Click += btnBack_Click;
            // 
            // btnNavigate
            // 
            btnNavigate.BackColor = Color.FromArgb(9, 9, 10);
            btnNavigate.BackgroundImage = Properties.Resources.chevron_right_light;
            btnNavigate.BorderColor = Color.FromArgb(39, 39, 42);
            btnNavigate.BorderThickness = 1F;
            btnNavigate.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnNavigate.ClickedColor = Color.FromArgb(39, 39, 42);
            btnNavigate.CornerRadii = new CustomControls.CornerRadiiF(5F, 5F, 5F, 5F);
            btnNavigate.DisabledBorderColor = Color.Empty;
            btnNavigate.DisabledColor = Color.Empty;
            btnNavigate.Dock = DockStyle.Right;
            btnNavigate.ForeColor = Color.FromArgb(250, 250, 250);
            btnNavigate.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnNavigate.HoverColor = Color.FromArgb(39, 39, 42);
            btnNavigate.Image = Properties.Resources.navigation_light;
            btnNavigate.ImageRectangle = new Rectangle(5, 7, 30, 30);
            btnNavigate.Location = new Point(503, 0);
            btnNavigate.Name = "btnNavigate";
            btnNavigate.Size = new Size(40, 40);
            btnNavigate.TabIndex = 4;
            btnNavigate.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnNavigate.TextPosition = new Point(0, 0);
            btnNavigate.Click += btnNavigate_Click;
            // 
            // pnlSpacer3
            // 
            pnlSpacer3.Dock = DockStyle.Right;
            pnlSpacer3.Location = new Point(543, 0);
            pnlSpacer3.Name = "pnlSpacer3";
            pnlSpacer3.Size = new Size(10, 40);
            pnlSpacer3.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(9, 9, 10);
            btnAdd.BorderColor = Color.FromArgb(39, 39, 42);
            btnAdd.BorderThickness = 1F;
            btnAdd.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnAdd.ClickedColor = Color.FromArgb(39, 39, 42);
            btnAdd.CornerRadii = new CustomControls.CornerRadiiF(5F, 5F, 5F, 5F);
            btnAdd.DisabledBorderColor = Color.Empty;
            btnAdd.DisabledColor = Color.Empty;
            btnAdd.Dock = DockStyle.Right;
            btnAdd.ForeColor = Color.FromArgb(250, 250, 250);
            btnAdd.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnAdd.HoverColor = Color.FromArgb(39, 39, 42);
            btnAdd.Image = Properties.Resources.plus_light;
            btnAdd.ImageRectangle = new Rectangle(6, 6, 30, 30);
            btnAdd.Location = new Point(453, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(40, 40);
            btnAdd.TabIndex = 6;
            btnAdd.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnAdd.TextPosition = new Point(0, 0);
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlSpacer2
            // 
            pnlSpacer2.Dock = DockStyle.Right;
            pnlSpacer2.Location = new Point(493, 0);
            pnlSpacer2.Name = "pnlSpacer2";
            pnlSpacer2.Size = new Size(10, 40);
            pnlSpacer2.TabIndex = 5;
            // 
            // pnlSpacer1
            // 
            pnlSpacer1.Dock = DockStyle.Right;
            pnlSpacer1.Location = new Point(443, 0);
            pnlSpacer1.Name = "pnlSpacer1";
            pnlSpacer1.Size = new Size(10, 40);
            pnlSpacer1.TabIndex = 7;
            // 
            // CalendarMenuBar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            Controls.Add(pbSearchBtn);
            Controls.Add(tbSearch);
            Controls.Add(pnlSpacer1);
            Controls.Add(btnAdd);
            Controls.Add(pnlSpacer2);
            Controls.Add(btnNavigate);
            Controls.Add(pnlSpacer3);
            Controls.Add(btnBack);
            Controls.Add(pnlSpacer4);
            Controls.Add(btnForward);
            Name = "CalendarMenuBar";
            Size = new Size(643, 40);
            ((System.ComponentModel.ISupportInitialize)pbSearchBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomTextBox tbSearch;
        private CustomControls.CustomButton btnForward;
        private Panel pnlSpacer4;
        private PictureBox pbSearchBtn;
        private CustomControls.CustomButton btnBack;
        private CustomControls.CustomButton btnNavigate;
        private Panel pnlSpacer3;
        private CustomControls.CustomButton btnAdd;
        private Panel pnlSpacer2;
        private Panel pnlSpacer1;
    }
}
