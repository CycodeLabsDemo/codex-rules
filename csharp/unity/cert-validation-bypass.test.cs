using UnityEngine.Networking;
public class TestCert : CertificateHandler { protected override bool ValidateCertificate(byte[] cert) {
        // ruleid: unity-cert-validation-bypass
        return true; } }
