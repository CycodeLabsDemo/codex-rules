using Microsoft.AspNetCore.Http;

public class CookieDemo {
    public void SetCookie(HttpResponse response) {
        // ruleid: aspnetcore-insecure-cookie
        response.Cookies.Append("sid", "1");

        // ok: aspnetcore-insecure-cookie
        response.Cookies.Append("sid", "1", new CookieOptions { Secure = true, HttpOnly = true });
    }
}
