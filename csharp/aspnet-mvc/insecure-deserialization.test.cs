public class Test {
    public void Foo() {
        // ruleid: aspnet-mvc-insecure-deserialization
        new BinaryFormatter().Deserialize(input);
    }
}
