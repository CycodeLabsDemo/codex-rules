public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-open-redirect
        Response.Redirect(Request.Query[input]);
    }
}
