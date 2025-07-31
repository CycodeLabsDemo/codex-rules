public class Test {
    public void Foo() {
        // ruleid: unity-open-redirect
        Application.OpenURL(Request.Query["url"]);
    }
}
