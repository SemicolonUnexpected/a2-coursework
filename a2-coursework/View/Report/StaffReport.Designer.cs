namespace a2_coursework.View {
    partial class StaffReport {
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
            pdfViewer1 = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            lblLoginAttempt = new Label();
            SuspendLayout();
            // 
            // pdfViewer1
            // 
            pdfViewer1.BackColor = SystemColors.ControlDark;
            pdfViewer1.CurrentIndex = -1;
            pdfViewer1.CurrentPageHighlightColor = Color.FromArgb(170, 70, 130, 180);
            pdfViewer1.Document = null;
            pdfViewer1.FormHighlightColor = Color.Transparent;
            pdfViewer1.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            pdfViewer1.LoadingIconText = "Loading...";
            pdfViewer1.Location = new Point(153, 12);
            pdfViewer1.Margin = new Padding(4, 3, 4, 3);
            pdfViewer1.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.OptimizedLoadThreshold = 1000;
            pdfViewer1.Padding = new Padding(12, 12, 12, 12);
            pdfViewer1.PageAlign = ContentAlignment.MiddleCenter;
            pdfViewer1.PageAutoDispose = true;
            pdfViewer1.PageBackColor = Color.White;
            pdfViewer1.PageBorderColor = Color.Black;
            pdfViewer1.PageMargin = new Padding(10);
            pdfViewer1.PageSeparatorColor = SystemColors.HighlightText;
            pdfViewer1.RenderFlags = Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH;
            pdfViewer1.ShowCurrentPageHighlight = true;
            pdfViewer1.ShowLoadingIcon = true;
            pdfViewer1.ShowPageSeparator = true;
            pdfViewer1.Size = new Size(346, 476);
            pdfViewer1.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.Zoom;
            pdfViewer1.TabIndex = 0;
            pdfViewer1.TextSelectColor = Color.FromArgb(70, 70, 130, 180);
            pdfViewer1.TilesCount = 2;
            pdfViewer1.UseProgressiveRender = true;
            pdfViewer1.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            pdfViewer1.Zoom = 1F;
            // 
            // lblLoginAttempt
            // 
            lblLoginAttempt.Anchor = AnchorStyles.Top;
            lblLoginAttempt.AutoSize = true;
            lblLoginAttempt.Font = new Font("Bahnschrift", 24F);
            lblLoginAttempt.ForeColor = Color.White;
            lblLoginAttempt.Location = new Point(28, 19);
            lblLoginAttempt.Margin = new Padding(10);
            lblLoginAttempt.Name = "lblLoginAttempt";
            lblLoginAttempt.Size = new Size(205, 39);
            lblLoginAttempt.TabIndex = 10;
            lblLoginAttempt.Text = "Staff Reports";
            // 
            // StaffReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(649, 500);
            Controls.Add(lblLoginAttempt);
            Controls.Add(pdfViewer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffReport";
            Text = "StaffReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewer1;
        private Label lblLoginAttempt;
    }
}