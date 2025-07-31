public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-insecure-cors
        builder.WithOrigins("*");
    }
}
