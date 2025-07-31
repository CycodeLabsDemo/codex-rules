public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-insecure-tls-version
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
    }
}
