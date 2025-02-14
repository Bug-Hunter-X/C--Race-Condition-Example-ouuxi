using System.Threading;

public class ExampleClassSolution
{
    public int MyProperty { get; set; }

    private readonly object _lock = new object(); //Synchronization object

    public ExampleClassSolution(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        lock (_lock) //Ensures thread safety
        {
            int temp = MyProperty;
            temp++;
            MyProperty = temp;
        }
    }
} 
