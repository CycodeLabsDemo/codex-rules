using UnityEngine.Networking;
// ruleid: unity-cert-validation-bypass
public class TestCert : CertificateHandler {
    protected override bool ValidateCertificate(byte[] cert) {
        return true;
    }
}
