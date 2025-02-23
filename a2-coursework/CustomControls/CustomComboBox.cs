namespace a2_coursework.CustomControls;
public partial class CustomComboBox : ComboBox {
    public CustomComboBox() {
        DrawMode = DrawMode.OwnerDrawFixed;
        DropDownStyle = ComboBoxStyle.DropDownList;
        BackColor = Color.Black;
        ForeColor = Color.White;
    }

    protected override void OnDrawItem(DrawItemEventArgs e) {
        if (e.Index < 0) return;

        e.DrawBackground();
        Brush brush = new SolidBrush(ForeColor);
        e.Graphics.DrawString(Items[e.Index].ToString(), e.Font, brush, e.Bounds);
        e.DrawFocusRectangle();
    }

    protected override void WndProc(ref Message m) {
        base.WndProc(ref m);

        // Intercept WM_PAINT to customize border and arrow
        if (m.Msg == 0xF) // WM_PAINT
        {
            using (Graphics g = Graphics.FromHwnd(Handle)) {
                // Draw custom border

                // Draw custom dropdown arrow
                int arrowX = Width - 20;
                int arrowY = (Height / 2) - 2;
                Point[] arrowPoints =
                {
                    new Point(arrowX, arrowY),
                    new Point(arrowX + 10, arrowY),
                    new Point(arrowX + 5, arrowY + 5)
                };
                g.FillPolygon(Brushes.White, arrowPoints);
            }
        }
    }

    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);

        e.Graphics.FillRectangle(new SolidBrush(Color.Red), ClientRectangle);
    }
}
