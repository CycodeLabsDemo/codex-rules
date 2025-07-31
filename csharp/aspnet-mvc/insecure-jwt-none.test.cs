public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-insecure-jwt-none
        new JwtSecurityTokenHandler { TokenValidationParameters = { RequireSignedTokens = false } };
    }
}
