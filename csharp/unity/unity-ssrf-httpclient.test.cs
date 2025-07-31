public class Test { public void Foo() {
        // ruleid: unity-ssrf-httpclient
        new HttpClient().GetAsync(Request.Query["u"]); } }
