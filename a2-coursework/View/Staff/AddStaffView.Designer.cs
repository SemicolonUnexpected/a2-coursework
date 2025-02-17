﻿namespace a2_coursework.View.StaffView {
    partial class AddStaffView {
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
            backNextDoneBar = new User_Controls.CRUD.PreviousNextDoneBar();
            pnlHolder = new Panel();
            pnlMenu = new Panel();
            lblAppearance = new Label();
            btnBack = new CustomControls.CustomButton();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // backNextDoneBar1
            // 
            backNextDoneBar.BackColor = Color.FromArgb(9, 9, 10);
            backNextDoneBar.Dock = DockStyle.Bottom;
            backNextDoneBar.Location = new Point(0, 459);
            backNextDoneBar.Margin = new Padding(0);
            backNextDoneBar.Name = "backNextDoneBar1";
            backNextDoneBar.Padding = new Padding(2);
            backNextDoneBar.PreviousVisible = true;
            backNextDoneBar.DoneVisible = true;
            backNextDoneBar.NextVisible = true;
            backNextDoneBar.Size = new Size(654, 41);
            backNextDoneBar.TabIndex = 33;
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
            // pnlMenu
            // 
            pnlMenu.Controls.Add(lblAppearance);
            pnlMenu.Controls.Add(btnBack);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(654, 40);
            pnlMenu.TabIndex = 32;
            // 
            // lblAppearance
            // 
            lblAppearance.Anchor = AnchorStyles.None;
            lblAppearance.AutoSize = true;
            lblAppearance.Font = new Font("Bahnschrift", 20F);
            lblAppearance.ForeColor = Color.White;
            lblAppearance.Location = new Point(248, 4);
            lblAppearance.Margin = new Padding(10);
            lblAppearance.Name = "lblAppearance";
            lblAppearance.Size = new Size(158, 33);
            lblAppearance.TabIndex = 26;
            lblAppearance.Text = "Appearance";
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
            btnBack.Dock = DockStyle.Left;
            btnBack.ForeColor = Color.FromArgb(250, 250, 250);
            btnBack.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnBack.HoverColor = Color.FromArgb(39, 39, 42);
            btnBack.Image = Properties.Resources.chevron_left_light;
            btnBack.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 40);
            btnBack.TabIndex = 25;
            btnBack.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnBack.TextPosition = new Point(0, 0);
            // 
            // AddStaffView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(654, 500);
            Controls.Add(backNextDoneBar);
            Controls.Add(pnlHolder);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStaffView";
            Text = "AddStaffView";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private User_Controls.CRUD.PreviousNextDoneBar backNextDoneBar;
        private Panel pnlHolder;
        private Panel pnlMenu;
        private Label lblAppearance;
        private CustomControls.CustomButton btnBack;
    }
}