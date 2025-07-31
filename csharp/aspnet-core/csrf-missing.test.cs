using Microsoft.AspNetCore.Mvc;

public class FormController : Controller {
    // ruleid: aspnet-core-csrf-missing
    [HttpPost]
    public IActionResult Submit(string data) {
        return Ok();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Safe(string data) {
        // ok: aspnet-core-csrf-missing
        return Ok();
    }
}
