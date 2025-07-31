public class Test {
    public void Foo() {
        // ruleid: dotnet-maui-insecure-webview
        WebView.Source = Request.Query["url"];
    }
}
