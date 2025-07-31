public class Test { public void Foo() { var input = "cmd";
        // ruleid: xamarin-command-injection-process
        System.Diagnostics.Process.Start(input); } }
