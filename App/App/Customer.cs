

using System;
using System.ComponentModel;


public delegate void HandleCusromerAdding(); 
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public HandleCusromerAdding AddingCustomerHandler;
    public void Add()
    {
        /*
            Add Customer To Data Source
         */
        Console.WriteLine( "Adding Customer");
        if(AddingCustomerHandler != null)
            AddingCustomerHandler();
    }
}