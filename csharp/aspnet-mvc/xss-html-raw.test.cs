public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-xss-html-raw
        Html.Raw(input);
    }
}
