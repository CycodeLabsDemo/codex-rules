public class Test {
    public void Foo(HttpContext context) {
        // ruleid: blazor-log-injection
        logger.LogInformation(context.Request.Query["input"]);
    }
}
