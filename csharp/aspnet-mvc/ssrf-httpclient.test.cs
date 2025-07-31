public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-ssrf-httpclient
        HttpClient().GetAsync(Request.Query["input"]);
    }
}
