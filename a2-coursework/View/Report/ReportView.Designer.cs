namespace a2_coursework.View {
    partial class ReportView {
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
            components = new System.ComponentModel.Container();
            btnDownload = new a2_coursework.CustomControls.CustomButton();
            toolTip = new ToolTip(components);
            btnBack = new a2_coursework.CustomControls.CustomButton();
            saveFileDialog = new SaveFileDialog();
            pdfRenderer1 = new PdfiumViewer.PdfRenderer();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDownload.BackColor = Color.FromArgb(9, 9, 10);
            btnDownload.BorderColor = Color.FromArgb(39, 39, 42);
            btnDownload.BorderThickness = 1F;
            btnDownload.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnDownload.ClickedColor = Color.FromArgb(39, 39, 42);
            btnDownload.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnDownload.DisabledBorderColor = Color.Empty;
            btnDownload.DisabledColor = Color.Empty;
            btnDownload.ForeColor = Color.FromArgb(250, 250, 250);
            btnDownload.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnDownload.HoverColor = Color.FromArgb(39, 39, 42);
            btnDownload.Image = Properties.Resources.download_light;
            btnDownload.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnDownload.Location = new Point(597, 12);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(40, 40);
            btnDownload.TabIndex = 18;
            btnDownload.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnDownload.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnDownload, "Download");
            // 
            // btnBack
            // 
            btnBack.BorderColor = Color.FromArgb(39, 39, 42);
            btnBack.BorderThickness = 1F;
            btnBack.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnBack.ClickedColor = Color.FromArgb(39, 39, 42);
            btnBack.CornerRadii = new a2_coursework.CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
            btnBack.DisabledBorderColor = Color.Empty;
            btnBack.DisabledColor = Color.Empty;
            btnBack.ForeColor = Color.FromArgb(250, 250, 250);
            btnBack.HoverBorderColor = Color.FromArgb(39, 39, 42);
            btnBack.HoverColor = Color.FromArgb(39, 39, 42);
            btnBack.Image = Properties.Resources.chevron_left_light;
            btnBack.ImageRectangle = new Rectangle(7, 7, 26, 26);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 40);
            btnBack.TabIndex = 18;
            btnBack.TextAlign = CustomControls.CustomButtonAlign.TopLeft;
            btnBack.TextPosition = new Point(0, 0);
            toolTip.SetToolTip(btnBack, "Back");
            btnBack.Visible = false;
            // 
            // pdfRenderer1
            // 
            pdfRenderer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pdfRenderer1.BackColor = Color.Gray;
            pdfRenderer1.Location = new Point(82, 12);
            pdfRenderer1.Name = "pdfRenderer1";
            pdfRenderer1.Page = 0;
            pdfRenderer1.Rotation = PdfiumViewer.PdfRotation.Rotate0;
            pdfRenderer1.Size = new Size(486, 476);
            pdfRenderer1.TabIndex = 19;
            pdfRenderer1.Text = "pdfRenderer1";
            pdfRenderer1.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitHeight;
            // 
            // ReportView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(649, 500);
            Controls.Add(pdfRenderer1);
            Controls.Add(btnBack);
            Controls.Add(btnDownload);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportView";
            Text = "StaffReport";
            ResumeLayout(false);
        }

        #endregion
        private CustomControls.CustomButton btnDownload;
        private ToolTip toolTip;
        private SaveFileDialog saveFileDialog;
        private CustomControls.CustomButton btnBack;
        private PdfiumViewer.PdfRenderer pdfRenderer1;
    }
}