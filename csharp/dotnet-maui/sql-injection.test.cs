public class Test {
    public void Foo(IDbConnection db, HttpRequest request) {
        var input = request.Query["id"];
        // ruleid: dotnet-maui-sql-injection
        db.Execute("select * from t where id=" + input);
    }
}
