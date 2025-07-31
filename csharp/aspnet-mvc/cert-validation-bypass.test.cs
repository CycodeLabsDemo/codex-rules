public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-cert-validation-bypass
        ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
    }
}
