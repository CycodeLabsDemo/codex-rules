public class Test {
    public void Foo(HttpContext context, NavigationManager nav) {
        // ruleid: blazor-ssrf-httpclient
        new HttpClient().GetAsync(nav.ToAbsoluteUri(context.Request.Query["url"]).ToString());
    }
}
