using System;


abstract class Person
{
    public string Name { get; set; }
    public abstract int BirthYear { get; }

    
    public abstract void DisplayInfo();
}

class Employee : Person
{
    public string Position { get; set; }
    public int Experience { get; set; }

    
    public Employee(string name, string position, int experience)
    {
        Name = name;
        Position = position;
        Experience = experience;
    }

   
    public override void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Experience: {Experience} years");
        Console.WriteLine($"Started working in: {DateTime.Now.Year - Experience}");
    }

    
    public override int BirthYear
    {
        get { return DateTime.Now.Year - Experience; }
    }
}


class Customer : Person
{
    public string Address { get; set; }

   
    public Customer(string name, string address)
    {
        Name = name;
        Address = address;
    }

    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Customer Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Year of Birth: {BirthYear}");
    }

    
    public override int BirthYear
    {
        get { return DateTime.Now.Year - 25; } 
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Employee employee = new Employee("Fedor Matys", "Manager", 10);
        Console.WriteLine("Employee Information:");
        employee.DisplayInfo();
        Console.WriteLine();

        
        Customer customer = new Customer("Alica Main", "123 Main St");
        Console.WriteLine("Customer Information:");
        customer.DisplayInfo();
    }
}
