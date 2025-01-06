using System.Configuration;

namespace a2_coursework.Model; 
internal static class DAL {
    private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    //public static User? GetUserSalt(string Username) {

    //}

    //public static string GetPassword(string Username) {

    //}
    
}
