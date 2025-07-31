public class Test {
    public void Foo(HttpContext context, NavigationManager nav) {
        // ruleid: blazor-open-redirect
        nav.NavigateTo(context.Request.Query["next"]);
    }
}
