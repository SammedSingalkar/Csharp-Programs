using System;

abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract decimal CalculateAnnualTax();
}

class Employee : Person
{
    public string Designation { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, int age, string designation, decimal salary)
        : base(name, age)
    {
        Designation = designation;
        Salary = salary;
    }

    public override decimal CalculateAnnualTax()
    {
        decimal taxRate = 0.2M; // Assume a tax rate of 20%
        decimal annualTax = Salary * taxRate;
        return annualTax;
    }
}

class Company : Employee
{
    public string CompanyName { get; set; }
    public int TotalEmployees { get; set; }

    public Company(string name, int age, string designation, decimal salary, string companyName, int totalEmployees)
        : base(name, age, designation, salary)
    {
        CompanyName = companyName;
        TotalEmployees = totalEmployees;
    }
}

class Program
{
    static void Main()
    {
        string name = "John Doe";
        int age = 30;
        string designation = "Manager";
        decimal salary = 50000;
        string companyName = "XYZ Company";
        int totalEmployees = 100;

        Company employee = new Company(name, age, designation, salary, companyName, totalEmployees);

        Console.WriteLine("Name: " + employee.Name);
        Console.WriteLine("Age: " + employee.Age);
        Console.WriteLine("Designation: " + employee.Designation);
        Console.WriteLine("Salary: " + employee.Salary);
        Console.WriteLine("Company Name: " + employee.CompanyName);
        Console.WriteLine("Total Employees: " + employee.TotalEmployees);

        decimal annualTax = employee.CalculateAnnualTax();
        Console.WriteLine("Annual Tax: " + annualTax);
    }
}
