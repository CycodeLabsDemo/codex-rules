public class Test {
    public void Foo() {
        // ruleid: dotnet-maui-sensitive-logging
        logger.LogInformation(Request.Query["data"]);
    }
}
