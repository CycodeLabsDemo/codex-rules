public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-auth-redirect
        RedirectToAction("Login", new { returnUrl = Request["next"] });
    }
}
