public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-xss-viewbag
        @Html.Raw(ViewBag.input);
    }
}
