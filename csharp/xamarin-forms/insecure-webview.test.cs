using Xamarin.Forms;

public class MyPage : ContentPage {
    public MyPage() {
        var web = new WebView();
        // ruleid: xamarin-insecure-webview
        web.Source = Preferences.Get("url", "");
    }
}
