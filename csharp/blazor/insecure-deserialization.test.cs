public class Test { public void Foo() {
        // ruleid: blazor-insecure-deserialization
        new BinaryFormatter().Deserialize(input); } }
