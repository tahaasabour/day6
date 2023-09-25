


using System;

public class Program
{
    public static void Main()
    {
        Customer customer = new Customer() { Id=1, Name="Hany"};
        Logger l = new Logger();
        customer.Adding += l.LogCustomer;
        customer.Adding += (c) =>
        {
            Console.WriteLine($"Main In Printing {c.Name}");
        };
        customer.Add();
    }
}