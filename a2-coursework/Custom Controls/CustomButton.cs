namespace a2_coursework.CustomControls;
public partial class CustomButton : CustomPanel {

    public CustomButton() {
        DoubleBuffered = true;
        BackColor = base.BackColor;
    }

    protected override void OnClick(EventArgs e) {
        if (Enabled) base.OnClick(e);
    }

    protected override void OnMouseClick(MouseEventArgs e) {
        if (Enabled) base.OnMouseClick(e);
    }

    protected override void OnMouseEnter(EventArgs e) {
        _buttonState = ButtonState.Hover;

        if (Enabled) {
            base.BackColor = HoverColor;
            base.BorderColor = HoverBorderColor;
            base.OnMouseEnter(e);
        }
    }

    protected override void OnMouseLeave(EventArgs e) {
        _buttonState = ButtonState.Normal;

        if (Enabled) {
            base.BackColor = BackColor;
            base.BorderColor = BorderColor;
            base.OnMouseLeave(e);
        }
    }

    protected override void OnMouseDown(MouseEventArgs e) {
        _buttonState = ButtonState.Clicked;

        if (Enabled) {
            base.BackColor = ClickedColor;
            base.BorderColor = ClickedBorderColor;
            base.OnMouseDown(e);
        }
    }

    protected override void OnMouseUp(MouseEventArgs e) {
        _buttonState = ButtonState.Hover;

        if (Enabled) {
            base.BackColor = HoverColor;
            base.BorderColor = HoverBorderColor;
            base.OnMouseUp(e);
        }
    }

    protected override void OnFontChanged(EventArgs e) {
        CalculateTextPosition();
        base.OnFontChanged(e);
    }

    protected override void OnPaint(PaintEventArgs e) {
        if (!string.IsNullOrWhiteSpace(Text)) TextRenderer.DrawText(e.Graphics, Text, Font, _textPosition, ForeColor);
        if (Image is not null) e.Graphics.DrawImage(Image, ImageRectangle);

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
        else if (_buttonState == ButtonState.Clicked) {
            base.BackColor = ClickedColor;
            base.BorderColor = ClickedBorderColor;
        }
        else if (_buttonState == ButtonState.Hover) {
            base.BackColor = HoverColor;
            base.BorderColor = HoverBorderColor;
        }
        else {
            base.BackColor = BackColor;
            base.BorderColor = BorderColor;
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
            CustomButtonAlign.MiddleLeft => new Point(Padding.Left, middle),
            CustomButtonAlign.Point => TextPosition,
            _ => throw new NotImplementedException(),
        };
    }

    protected override void OnPaddingChanged(EventArgs e) {
        CalculateTextPosition();
        Invalidate();
        base.OnPaddingChanged(e);
    }
}
