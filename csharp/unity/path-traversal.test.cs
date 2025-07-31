using System.IO;
public class Test { public void Foo() {
        // ruleid: unity-path-traversal
        File.ReadAllText(Request.Query["file"]); } }
