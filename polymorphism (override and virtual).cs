using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayInformation()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Adhar_card : Person
{
    public string SSN { get; set; }

    public Adhar_card(string name, int age, string ssn)
        : base(name, age)
    {
        SSN = ssn;
    }

    public override void DisplayInformation()
    {
        base.DisplayInformation();
        Console.WriteLine("Social Security Number: " + SSN);
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("John Doe", 30);
        Console.WriteLine("Person Information:");
        person.DisplayInformation();

        Console.WriteLine();

        Adhar_card adharCard = new Adhar_card("Jane Smith", 25, "123-45-6789");
        Console.WriteLine("Adhar Card Information:");
        adharCard.DisplayInformation();
    }
}
