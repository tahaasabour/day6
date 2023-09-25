
using App;
using System;
using System.Collections.Generic;


public delegate int MyDel(); 

public class Program
{
    public static void Main()
    {
        Customer customer = new Customer() { Id = 1, Name = "Hany" };
        Logger log = new Logger();
        
        CustomerWriter wr = new CustomerWriter();

        customer.AddingCustomerHandler = log.Log;
        customer.AddingCustomerHandler += wr.WriteCustomer;

        customer.AddingCustomerHandler += () =>
            Console.WriteLine("Main Action Against Adding CUstomer");

        customer.Add();


       

    }
}