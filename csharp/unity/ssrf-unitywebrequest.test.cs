using UnityEngine.Networking;
public class Test { public void Foo() { var input = "http://example";
        // ruleid: unity-ssrf-unitywebrequest
        UnityWebRequest.Get(input); } }
