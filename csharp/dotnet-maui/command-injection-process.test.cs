public class Test {
    public void Foo() {
        // ruleid: dotnet-maui-command-injection-process
        System.Diagnostics.Process.Start(Request.Query["cmd"]);
    }
}
