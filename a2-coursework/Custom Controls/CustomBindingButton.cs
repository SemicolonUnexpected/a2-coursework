namespace a2_coursework.Custom_Controls;
public partial class CustomBindingButton : CustomBasicButton {

    public new event EventHandler? Click;

    //public CustomBindingButton() {
    //    int scalingFactor = DeviceDpi / 96;
    //    Location = new Point(Location.X * scalingFactor, Location.Y * scalingFactor);
    //}

    protected override void OnControlAdded(ControlEventArgs e) {
        base.OnControlAdded(e);

        ExecuteRecursive((ctrl) => {
            ctrl.MouseDown  += ControlMouseDown;
            ctrl.MouseUp    += ControlMouseUp;
            ctrl.MouseEnter += ControlMouseEnter;
            ctrl.MouseLeave += ControlMouseLeave;
            ctrl.MouseClick += ControlMouseClick;
            ctrl.Click      += ControlClick;
            },
            e.Control);
    }

    protected override void OnControlRemoved(ControlEventArgs e) {
        base.OnControlRemoved(e);

        ExecuteRecursive((ctrl) => {
            ctrl.MouseDown  -= ControlMouseDown;
            ctrl.MouseUp    -= ControlMouseUp;
            ctrl.MouseEnter -= ControlMouseEnter;
            ctrl.MouseLeave -= ControlMouseLeave;
            ctrl.MouseClick -= ControlMouseClick;
            ctrl.Click      -= ControlClick;
            },
            e.Control);
    }

    private void ControlMouseDown(object? sender, MouseEventArgs e) => base.OnMouseDown(e);
    private void ControlMouseUp(object? sender, MouseEventArgs e) => base.OnMouseUp(e);
    private void ControlMouseEnter(object? sender, EventArgs e) => base.OnMouseEnter(e);
    private void ControlMouseLeave(object? sender, EventArgs e) => base.OnMouseLeave(e);
    private void ControlMouseClick(object? sender, MouseEventArgs e) => OnMouseClick(e);
    private void ControlClick(object? sender, EventArgs e) => Click?.Invoke(sender, e);

    private void ExecuteRecursive(Action<Control> a, Control? control) {
        Queue<Control?> queue = new();
        queue.Enqueue(control);

        while (queue.Count > 0) {
            Control? current = queue.Dequeue();
            foreach (Control? child in current.Controls) queue.Enqueue(child);

            a(current);
        }
    }
}
