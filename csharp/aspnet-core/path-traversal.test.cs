using System.IO;
using Microsoft.AspNetCore.Mvc;

public class FileReader : Controller {
    public string Read() {
        // ruleid: aspnet-core-path-traversal
        return File.ReadAllText(Request.Query["file"]);
    }

    public string Safe() {
        // ok: aspnet-core-path-traversal
        return File.ReadAllText("/var/data/file.txt");
    }
}
