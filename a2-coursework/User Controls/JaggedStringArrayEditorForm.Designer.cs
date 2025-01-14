namespace a2_coursework.User_Controls {
    partial class JaggedStringArrayEditorForm {
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
            tb = new TextBox();
            btnDone = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tb
            // 
            tb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb.Location = new Point(12, 12);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.Size = new Size(522, 301);
            tb.TabIndex = 0;
            // 
            // btnDone
            // 
            btnDone.Location = new Point(459, 319);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(75, 23);
            btnDone.TabIndex = 1;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(378, 319);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // JaggedStringArrayEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 352);
            Controls.Add(btnCancel);
            Controls.Add(btnDone);
            Controls.Add(tb);
            Name = "JaggedStringArrayEditorForm";
            Text = "StringEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb;
        private Button btnDone;
        private Button btnCancel;
    }
}