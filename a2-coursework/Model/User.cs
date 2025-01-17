namespace a2_coursework.Model;

internal class User {
    public string Username { get; init; }
    public bool Active { get; init; }
    public PriviledgeLevel PriviledgeLevel { get; init; }

    public User(string username) {
        Username = username;
    }
}
