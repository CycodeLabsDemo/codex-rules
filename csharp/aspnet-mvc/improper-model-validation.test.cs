public class Test {
    // ruleid: aspnet-mvc-improper-model-validation
    public IActionResult Input(object model) {
        SaveChanges(model);
        return View();
    }
}
