using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class CmdController : Controller {
    public void Run() {
        // ruleid: aspnet-core-command-injection-process
        Process.Start(Request.Query["cmd"]);
    }

    public void Safe() {
        // ok: aspnet-core-command-injection-process
        Process.Start("ls");
    }
}
