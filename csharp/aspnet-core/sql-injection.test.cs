using System.Data.SqlClient;
public class Repo {
    private SqlConnection con;
    public void Get(string id) {
        // ruleid: aspnet-core-sql-injection
        var cmd = new SqlCommand("SELECT * FROM Users WHERE Id=" + id, con);
    }
}
