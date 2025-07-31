using System.Runtime.Serialization.Formatters.Binary;
public class Test { public void Foo() { var input = new System.IO.MemoryStream();
        // ruleid: xamarin-insecure-deserialization
        new BinaryFormatter().Deserialize(input); } }
