using System.Runtime.Serialization.Formatters.Binary;
public class Test {
    public void Foo() {
        // ruleid: aspnet-core-insecure-deserialization
        BinaryFormatter().Deserialize(Request.Body);
    }
}
