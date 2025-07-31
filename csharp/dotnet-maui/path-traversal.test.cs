using System.IO;
public class Test {
    public void Foo() {
        // ruleid: dotnet-maui-path-traversal
        File.ReadAllText(Request.Query["file"]);
    }
}
