namespace a2_coursework._Helpers;
public static class ControlExtensions {
    public static void ExecuteOnChildrenRecursive(this Control control, Action<Control> a) {
        Queue<Control> queue = new();
        queue.Enqueue(control);

        while (queue.Count > 0) {
            Control current = queue.Dequeue();
            foreach (Control child in current.Controls) queue.Enqueue(child);

            a(current);
        }
    }
}
