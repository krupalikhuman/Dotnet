using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public Customer(int ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }
    public Customer()
    {
        this.ID = -1;
        this.Name = string.Empty;
    }
    public void printID()
    {
        Console.WriteLine("ID is: {0}", this.ID);
    }
    public void printName()
    {
        Console.WriteLine("Name is: {0}", this.Name);
    }
}
