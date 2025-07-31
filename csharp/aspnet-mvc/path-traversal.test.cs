public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-path-traversal
        System.IO.File.ReadAllText(Request.Query[input]);
    }
}
