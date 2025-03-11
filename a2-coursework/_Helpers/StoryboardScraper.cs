using System.Text;

namespace a2_coursework._Helpers; 
public class SvgGenerator {
    private readonly Dictionary<Type, Func<Control, string>> _svgRenderers;

    public SvgGenerator() {
        _svgRenderers = new Dictionary<Type, Func<Control, string>> {
            { typeof(Button), control => RenderButtonSvg((Button)control) },
            { typeof(Label), control => RenderLabelSvg((Label)control) },
            { typeof(TextBox), control => RenderTextBoxSvg((TextBox)control) },
            { typeof(Panel), control => RenderPanelSvg((Panel)control) },
            { typeof(PictureBox), control => RenderPictureBoxSvg((PictureBox)control) }
        };
    }

    public string GenerateSvg(Control rootControl) {
        StringBuilder svg = new();
        svg.AppendLine("""<svg xmlns="http://www.w3.org/2000/svg" width="1000" height="1000" style="background:#f0f0f0;">""");

        ProcessControl(rootControl, svg);

        svg.AppendLine("</svg>");
        return svg.ToString();
    }

    private void ProcessControl(Control control, StringBuilder svg) {
        svg.AppendLine(GetControlSvg(control));

        //if (svg.AppendLine($"<g transform=\"translate({control.Left},{control.Top})\">");
        //svg.AppendLine(GetControlSvg(control));

        //foreach (Control child in control.Controls) {
        //    svg.AppendLine(ProcessControl(child));
        //}
        //svg.AppendLine("</g>");

        //// Process child controls recursively
        //foreach (Control child in control.Controls) {
        //    ProcessControl(child, svg, x, y);
        //}
    }

    private string GetControlSvg(Control control) {
        if (_svgRenderers.TryGetValue(control.GetType(), out var renderMethod)) {
            return renderMethod(control);
        }
        return RenderDefaultSvg(control);
    }

    // Methods for each control type
    private static string RenderButtonSvg(Button control) {

        return $"<rect x=\"{control.Left}\" y=\"{control.Top}\" width=\"{control.Width}\" height=\"{control.Height}\" fill=\"orange\" stroke=\"black\" stroke-width=\"1\"/>" +
        $"<text x=\"{control.Left + 5}\" y=\"{control.Top + 15}\" font-size=\"12\" fill=\"black\">{control.Text}</text>";
    }

    private static string RenderLabelSvg(Label control) {
        float fontSize = control.Font.Size;
        string fontFamily = control.Font.FontFamily.Name;

        // Calculate x and y based on TextAlign
        int textX = control.Left;
        int textY = control.Top + (control.Height / 2) + (int)(fontSize / 2);

        switch (control.TextAlign) {
            case ContentAlignment.TopLeft:
                textX += 5;
                textY = control.Top + (int)(fontSize);
                break;
            case ContentAlignment.TopCenter:
                textX += control.Width / 2;
                textY = control.Top + (int)(fontSize);
                break;
            case ContentAlignment.TopRight:
                textX += control.Width - 5;
                textY = control.Top + (int)(fontSize);
                break;
            case ContentAlignment.MiddleLeft:
                textX += 5;
                break;
            case ContentAlignment.MiddleCenter:
                textX += control.Width / 2;
                break;
            case ContentAlignment.MiddleRight:
                textX += control.Width - 5;
                break;
            case ContentAlignment.BottomLeft:
                textX += 5;
                textY = control.Top + control.Height - 5;
                break;
            case ContentAlignment.BottomCenter:
                textX += control.Width / 2;
                textY = control.Top + control.Height - 5;
                break;
            case ContentAlignment.BottomRight:
                textX += control.Width - 5;
                textY = control.Top + control.Height - 5;
                break;
        }

        return $"<text x=\"{textX}\" y=\"{textY}\" font-size=\"{fontSize}\" fill=\"black\" font-family=\"{fontFamily}\" text-anchor=\"middle\" dominant-baseline=\"middle\">{control.Text}</text>";
    }

    private static string RenderTextBoxSvg(TextBox control) =>
        $"<rect x=\"{control.Left}\" y=\"{control.Top}\" width=\"{control.Width}\" height=\"{control.Height}\" fill=\"white\" stroke=\"black\" stroke-width=\"1\"/>";

    private static string RenderPanelSvg(Panel control) =>
        $"<rect x=\"{control.Left}\" y=\"{control.Top}\" width=\"{control.Width}\" height=\"{control.Height}\" fill=\"lightgray\" stroke=\"black\" stroke-width=\"1\"/>";

    private static string RenderPictureBoxSvg(PictureBox control) =>
        $"<rect x=\"{control.Left}\" y=\"{control.Top}\" width=\"{control.Width}\" height=\"{control.Height}\" fill=\"none\" stroke=\"blue\" stroke-width=\"2\"/>";

    private static string RenderDefaultSvg(Control control) =>
        $"<rect x=\"{control.Left}\" y=\"{control.Top}\" width=\"{control.Width}\" height=\"{control.Height}\" fill=\"lightblue\" stroke=\"black\" stroke-width=\"1\"/>" +
        $"<text x=\"{control.Left + 5}\" y=\"{control.Top + 15}\" font-size=\"12\" fill=\"black\">{control.Name}</text>";
}
