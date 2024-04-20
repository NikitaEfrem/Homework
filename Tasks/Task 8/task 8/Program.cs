using System;


class Transport
{

    public string Type { get; set; }


    public Transport(string type)
    {
        Type = type;
        Console.WriteLine($"Constructor of {Type} Transport class");
    }

    public virtual string Move()
    {
        return "Moving...";
    }

    protected virtual string Park()
    {
        return "Parking...";
    }
}


class Boat : Transport
{

    public Boat(string type) : base(type)
    {
        Console.WriteLine($"Constructor of {type} Boat class");
    }


    public override string Move()
    {
        return "Sailing...";
    }
}


class Car : Transport
{

    public Car(string type) : base(type)
    {
        Console.WriteLine($"Constructor of {type} Car class");
    }


    protected override string Park()
    {
        return "Parking car...";
    }

    
    public override string Move()
    {
        return base.Move();
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Transport transport1 = new Boat("Speed");
        Console.WriteLine(transport1.Move()); 
     

        Console.WriteLine();

        Transport transport2 = new Car("SUV");
        Console.WriteLine(transport2.Move()); 
      
    }
}