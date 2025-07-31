public class Test { public void Foo() {
        // ruleid: xamarin-cert-validation-bypass
        ServicePointManager.ServerCertificateValidationCallback += delegate { return true; }; } }
