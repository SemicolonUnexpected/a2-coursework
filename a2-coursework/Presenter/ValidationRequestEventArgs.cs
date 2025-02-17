namespace a2_coursework.Presenter;
public class ValidationRequestEventArgs<T> : EventArgs
{

    public T Value { get; init; }
    public bool? Valid { get; private set; } = null;
    public Task<bool>? ValidationTask { get; private set; }
    public string ErrorMessage { get; private set; } = "";

    public ValidationRequestEventArgs(T value)
    {
        Value = value;
    }

    public void SetValidation(bool valid, string errorMessage = "")
    {
        Valid = valid;
        ErrorMessage = errorMessage;
        ValidationTask = Task.FromResult(valid);
    }

    public void SetValidation(Task<bool> validationTask, string errorMessage)
    {
        ValidationTask = validationTask.ContinueWith(x =>
        {
            Valid = x.Result;
            return x.Result;
        });

        ErrorMessage = errorMessage;
    }
}
