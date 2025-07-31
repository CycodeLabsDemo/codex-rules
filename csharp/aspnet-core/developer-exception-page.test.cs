using Microsoft.AspNetCore.Builder;
public class Startup {
    public void Configure(IApplicationBuilder app) {
        // ruleid: aspnet-core-developer-exception-page
        app.UseDeveloperExceptionPage();
    }
}
