using System.IO;
public class Test { public void Foo() { var input = "../../secret";
        // ruleid: xamarin-path-traversal
        File.ReadAllText(input); } }
