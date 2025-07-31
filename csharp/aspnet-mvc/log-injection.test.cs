public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-log-injection
        logger.LogError(Request.Query["input"]);
    }
}
