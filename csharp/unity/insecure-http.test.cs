using UnityEngine.Networking;
public class Test { public void Foo() {
        // ruleid: unity-insecure-http
        UnityWebRequest.Get("http://example.com"); } }
