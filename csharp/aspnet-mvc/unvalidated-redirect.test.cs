public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-unvalidated-redirect
        Redirect(Request["returnUrl"]);
    }
}
