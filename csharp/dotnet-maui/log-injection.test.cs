public class Test {
    public void Foo() {
        // ruleid: dotnet-maui-log-injection
        logger.LogDebug(Preferences.Get("msg", ""));
    }
}
