using System.Runtime.Serialization.Formatters.Binary;
public class Test {
    public void Foo() {
        // ruleid: dotnet-maui-insecure-deserialization
        new BinaryFormatter().Deserialize(Request.Body);
    }
}
