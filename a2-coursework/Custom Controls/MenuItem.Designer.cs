namespace AS_Coursework.Custom_Controls {
    partial class MenuItem {
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
            lbl = new Label();
            pb = new PicturePanel();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(56, 14);
            lbl.Margin = new Padding(2, 0, 2, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(59, 23);
            lbl.TabIndex = 0;
            lbl.Text = "Home";
            // 
            // pb
            // 
//            pb.Image = Resources.Icons.Home;
            pb.ImagePortion = new Rectangle(0, 0, 512, 512);
            pb.Location = new Point(17, 11);
            pb.Margin = new Padding(2);
            pb.Name = "pb";
            pb.Size = new Size(30, 30);
            pb.TabIndex = 1;
            pb.Text = "customPicturePanel1";
            // 
            // MenuItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 70);
            Controls.Add(pb);
            Controls.Add(lbl);
            Margin = new Padding(2);
            Name = "MenuItem";
            Size = new Size(140, 48);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl;
        private Custom_Controls.PicturePanel pb;
    }
}
