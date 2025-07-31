public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-insecure-session-state
        Response.Redirect("/home?session=" + Session.SessionID);
    }
}
