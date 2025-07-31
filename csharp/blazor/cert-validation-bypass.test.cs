public class Test { public void Foo() {
        // ruleid: blazor-cert-validation-bypass
        HttpClientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, errors) => true; } }
