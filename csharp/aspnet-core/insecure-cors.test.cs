using Microsoft.AspNetCore.Cors.Infrastructure;
public class CorsConfig {
    public void Setup(CorsPolicyBuilder builder) {
        // ruleid: aspnet-core-insecure-cors
        builder.AllowAnyOrigin();
        // ok: aspnet-core-insecure-cors
        builder.WithOrigins("https://example.com");
    }
}
