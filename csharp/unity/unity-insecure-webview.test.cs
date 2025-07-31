public class MyPage {
    public MyPage() {
        var web = new WebViewObject();
        // ruleid: unity-insecure-webview
        web.LoadURL(PlayerPrefs.GetString("url"));
    }
}
