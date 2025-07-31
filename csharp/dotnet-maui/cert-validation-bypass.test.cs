using System.Net.Http;
using System.Net.Security;

public class Service {
    public HttpClient Create() {
        var handler = new HttpClientHandler();
        // ruleid: dotnet-maui-cert-validation-bypass
        handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, errors) => true;
        return new HttpClient(handler);
    }
}
