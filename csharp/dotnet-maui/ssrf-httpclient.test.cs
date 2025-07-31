public class Test {
    public void Foo() {
        // ruleid: dotnet-maui-ssrf-httpclient
        new HttpClient().GetAsync(Preferences.Get("url", ""));
    }
}
