public class Test { public void Foo() { var input = "1";
        // ruleid: unity-sql-injection
        conn.CreateCommand().CommandText = "select" + input; } }
