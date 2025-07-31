public class Test { public void Foo() {
        // ruleid: blazor-insecure-storage
        await JS.InvokeVoidAsync("localStorage.setItem", input, input); } }
