
using System;

public delegate void MyHandler();

public class Program
{
    public static void Test()
    {
        Console.WriteLine("I am Test");
    }

    public  void Foo()
    {
        Console.WriteLine("Foo()");
    }
    public static void Main()
    {
        MyHandler h = new MyHandler(Test);
        Program P = new Program();
        MyHandler h2 = new MyHandler(P.Foo);
        
        h.Invoke();
        h2.Invoke();

        Console.WriteLine(h.Method + " " + h.Target);
        Console.WriteLine(h2.Method + " " + h2.Target);
    }
}