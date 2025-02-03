namespace a2_coursework._Helpers;
public static class ControlHelpers {
    public static void ExecuteRecursive(Control control, Action<Control> a) {
        Queue<Control> queue = new();
        queue.Enqueue(control);

        while (queue.Count > 0) {
            Control current = queue.Dequeue();
            foreach (Control child in current.Controls) queue.Enqueue(child);

            a(current);
        }
    }

    public static void SetFontName(Control control, string fontName) {
        control.Font = new(fontName, control.Font.Size, control.Font.Style);
    }
}
