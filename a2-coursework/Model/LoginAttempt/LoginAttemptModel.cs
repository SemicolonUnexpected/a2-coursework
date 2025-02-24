namespace a2_coursework.Model.LoginAttempt; 
public class LoginAttemptModel(string username, DateTime attemptTime, bool successful) {
    public string Username { get; init; } = username;
    public DateTime AttemptTime { get; init; } = attemptTime;
    public bool Successful { get; init; } = successful;
}
