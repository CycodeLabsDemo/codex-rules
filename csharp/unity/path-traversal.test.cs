using System.IO;
public class Test { public void Foo() { var input = "../../secret";
        // ruleid: unity-path-traversal
        File.ReadAllText(input); } }
