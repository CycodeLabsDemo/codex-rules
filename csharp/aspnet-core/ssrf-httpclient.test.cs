using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

public class Requester : Controller {
    public void Fetch() {
        // ruleid: aspnet-core-ssrf-httpclient
        HttpClient().GetAsync(Request.Query["url"]);
        // ok: aspnet-core-ssrf-httpclient
        HttpClient().GetAsync("https://example.com");
    }
}
