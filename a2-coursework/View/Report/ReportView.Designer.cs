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
            pdfViewer = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            btnDownload = new CustomControls.CustomButton();
            toolTip = new ToolTip(components);
            saveFileDialog = new SaveFileDialog();
            SuspendLayout();
            // 
            // pdfViewer
            // 
            pdfViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pdfViewer.BackColor = SystemColors.ControlDark;
            pdfViewer.CurrentIndex = -1;
            pdfViewer.CurrentPageHighlightColor = Color.Empty;
            pdfViewer.Document = null;
            pdfViewer.FormHighlightColor = Color.Transparent;
            pdfViewer.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            pdfViewer.LoadingIconText = "Loading...";
            pdfViewer.Location = new Point(88, 12);
            pdfViewer.Margin = new Padding(4, 3, 4, 3);
            pdfViewer.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            pdfViewer.Name = "pdfViewer";
            pdfViewer.OptimizedLoadThreshold = 1000;
            pdfViewer.Padding = new Padding(12, 12, 12, 12);
            pdfViewer.PageAlign = ContentAlignment.MiddleCenter;
            pdfViewer.PageAutoDispose = true;
            pdfViewer.PageBackColor = Color.White;
            pdfViewer.PageBorderColor = Color.Black;
            pdfViewer.PageMargin = new Padding(10);
            pdfViewer.PageSeparatorColor = SystemColors.HighlightText;
            pdfViewer.RenderFlags = Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH;
            pdfViewer.ShowCurrentPageHighlight = true;
            pdfViewer.ShowLoadingIcon = true;
            pdfViewer.ShowPageSeparator = true;
            pdfViewer.Size = new Size(486, 476);
            pdfViewer.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.Zoom;
            pdfViewer.TabIndex = 0;
            pdfViewer.TextSelectColor = Color.FromArgb(70, 70, 130, 180);
            pdfViewer.TilesCount = 2;
            pdfViewer.UseProgressiveRender = true;
            pdfViewer.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            pdfViewer.Zoom = 1.1F;
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDownload.BackColor = Color.FromArgb(9, 9, 10);
            btnDownload.BorderColor = Color.FromArgb(39, 39, 42);
            btnDownload.BorderThickness = 1F;
            btnDownload.ClickedBorderColor = Color.FromArgb(39, 39, 42);
            btnDownload.ClickedColor = Color.FromArgb(39, 39, 42);
            btnDownload.CornerRadii = new CustomControls.CornerRadiiF(10F, 10F, 10F, 10F);
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
            // ReportView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(9, 9, 10);
            ClientSize = new Size(649, 500);
            Controls.Add(btnDownload);
            Controls.Add(pdfViewer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportView";
            Text = "StaffReport";
            ResumeLayout(false);
        }

        #endregion

        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewer;
        private CustomControls.CustomButton btnDownload;
        private ToolTip toolTip;
        private SaveFileDialog saveFileDialog;
    }
}