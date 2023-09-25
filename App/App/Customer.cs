

using System;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    private Action<Customer> addingList;
    public event Action<Customer> Adding
    {
        add 
        { 
            addingList += value;
        }
        remove 
        {
            addingList -= value;
        }
    }
    public void Add()
    {
        Console.WriteLine("Currently Adding Customer ...");
        if(addingList != null)
        {
            addingList(this);
        }
    }
}