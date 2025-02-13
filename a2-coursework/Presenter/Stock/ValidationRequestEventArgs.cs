namespace a2_coursework.Presenter.Stock; 
public class ValidationRequestEventArgs<T> : EventArgs {

    public T Value { get; init; }
    public bool? Valid { get; set; } = null;
    public Task<bool>? ValidationTask { get; set; }
    public string ErrorMessage { get; set; } = "";

    public ValidationRequestEventArgs(T value) {
        Value = value;
    }
}
