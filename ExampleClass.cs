public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        //Simulate a potential race condition where MyProperty could be accessed by multiple threads concurrently without proper synchronization
        //This would cause unpredictable and unreliable results.
        int temp = MyProperty;
        temp++;
        MyProperty = temp; 
    }
}