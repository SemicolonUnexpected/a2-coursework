using System.Configuration;

namespace a2_coursework.Model; 
public abstract class DAL {
    public static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
}
