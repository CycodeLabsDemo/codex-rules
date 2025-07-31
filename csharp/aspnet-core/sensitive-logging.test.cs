using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

public class LoggerDemo : Controller {
    private ILogger logger;
    public void Log() {
        // ruleid: aspnet-core-sensitive-logging
        logger.LogInformation(Request.Query["msg"]);
        // ok: aspnet-core-sensitive-logging
        logger.LogInformation("User logged in");
    }
}
