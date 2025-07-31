public class Test { public void Foo() {
        // ruleid: unity-command-injection-process
        System.Diagnostics.Process.Start(Request["cmd"]); } }
