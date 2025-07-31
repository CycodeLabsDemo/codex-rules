public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-sql-injection-raw-string
        SqlCommand(input + input);
    }
}
