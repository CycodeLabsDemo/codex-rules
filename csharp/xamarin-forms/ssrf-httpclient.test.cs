public class Test { public void Foo() {
        // ruleid: xamarin-ssrf-httpclient
        new HttpClient().GetAsync(input); } }
