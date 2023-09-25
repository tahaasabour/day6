

using System;

public class Logger
{
    public void LogCustomer(Customer cutomer)
    {
        Console.WriteLine($"Name : {cutomer.Name}");
    }
}