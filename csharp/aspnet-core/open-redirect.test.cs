using Microsoft.AspNetCore.Mvc;
public class HomeController : Controller {
    public IActionResult Go() {
        // ruleid: aspnetcore-open-redirect
        return Redirect(Request.Query["url"]);
    }
    public IActionResult Safe() {
        var url = Request.Query["url"];
        // ok: aspnetcore-open-redirect
        if (url == "/home") return Redirect(url);
        return Redirect("/home");
    }
}
