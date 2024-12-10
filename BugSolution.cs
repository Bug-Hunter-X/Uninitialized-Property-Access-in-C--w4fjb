public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public ExampleClass()
    {
        // Or initialize in the constructor
        MyProperty = 10;
    }

    public void MyMethod()
    {
        int value = MyProperty; // Now MyProperty is guaranteed to have an initial value
    }
}