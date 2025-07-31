using UnityEngine.Networking;
public class Test { public void Foo() {
        // ruleid: unity-ssrf-unitywebrequest
        UnityWebRequest.Get(Request.Query["u"]); } }
