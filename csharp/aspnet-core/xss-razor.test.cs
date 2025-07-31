using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Html;
using System.Net;

public class DemoController : Controller {
    public IActionResult Show() {
        // ruleid: aspnetcore-xss
        return Content(Html.Raw(Request.Query["msg"]));
    }

    public IActionResult Safe() {
        // ok: aspnetcore-xss
        var msg = Request.Query["msg"];
        return Content(WebUtility.HtmlEncode(msg));
    }
}
