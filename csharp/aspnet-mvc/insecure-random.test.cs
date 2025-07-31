public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-insecure-random
        new Random();
    }
}
