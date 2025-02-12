namespace a2_coursework.Presenter.Stock; 
public class ValidationRequestEventArgs<T> : EventArgs {

    public T Value { get; init; }
    public Task<bool>? Valid { get; set; }
    public string ErrorMessage { get; set; } = "";

    public ValidationRequestEventArgs(T value) {
        Value = value;
    }
}
