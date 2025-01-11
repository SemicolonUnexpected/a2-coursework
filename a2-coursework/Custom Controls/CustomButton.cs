namespace a2_coursework.CustomControls;
public partial class CustomButton : CustomPanel {

    public CustomButton() {
        DoubleBuffered = true;
        BackColor = base.BackColor;
    }

    protected override void OnClick(EventArgs e) {
        if (Enabled) base.OnClick(e);
    }

    protected override void OnMouseEnter(EventArgs e) {
        if (Enabled) {
            _buttonState = ButtonState.Hover;
            base.BackColor = HoverColor;
            base.BorderColor = HoverBorderColor;
            base.OnMouseEnter(e);
        }
    }

    protected override void OnMouseLeave(EventArgs e) {
        if (Enabled) {
            _buttonState = ButtonState.Normal;
            base.BackColor = BackColor;
            base.BorderColor = BorderColor;
            base.OnMouseLeave(e);
        }
    }

    protected override void OnMouseDown(MouseEventArgs e) {
        if (Enabled) {
            _buttonState = ButtonState.Clicked;
            base.BackColor = ClickedColor;
            base.BorderColor = ClickedBorderColor;
            base.OnMouseDown(e);
        }
    }

    protected override void OnMouseUp(MouseEventArgs e) {
        if (Enabled) {
            _buttonState = ButtonState.Clicked;
            base.BackColor = HoverColor;
            base.BorderColor = HoverBorderColor;
            base.OnMouseUp(e);
        }
    }

    protected override void OnPaint(PaintEventArgs e) {
        if (!string.IsNullOrWhiteSpace(Text)) TextRenderer.DrawText(e.Graphics, Text, Font, _textPosition, ForeColor);
        if (BackgroundImage is not null) e.Graphics.DrawImage(BackgroundImage, ImageRectangle);

        base.OnPaint(e);
    }

    protected override void OnResize(EventArgs e) {
        CalculateTextPosition();
        base.OnResize(e);
    }

    protected override void OnEnabledChanged(EventArgs e) {
        if (!Enabled) {
            base.BackColor = DisabledColor;
            base.BorderColor = DisabledBorderColor;
        }

        base.OnEnabledChanged(e);
    }

    protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
        ImageRectangle = new((int)(ImageRectangle.Location.X * factor.Width), (int)(ImageRectangle.Location.Y * factor.Height), (int)(ImageRectangle.Width * factor.Width), (int)(ImageRectangle.Height * factor.Height));
        base.ScaleControl(factor, specified);
    }

    private void CalculateTextPosition() {
        Size measurement = TextRenderer.MeasureText(Text, Font);
        int center = (Width - measurement.Width) / 2;
        int middle = (Height - measurement.Height) / 2;

        _textPosition = TextAlign switch {
            CustomButtonAlign.TopLeft => new Point(Padding.Left, Padding.Top),
            CustomButtonAlign.TopCenter => new Point(center, Padding.Top),
            CustomButtonAlign.MiddleCenter => new Point(center, middle),
            CustomButtonAlign.Point => TextPosition,
            _ => throw new NotImplementedException(),
        };
    }

}
