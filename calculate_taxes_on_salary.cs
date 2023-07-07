// using System;

class Employee
{
    public int EmployeeID { get; set; }
    public string Post { get; set; }
    public decimal Salary { get; set; }

    public Employee(int empID, string post, decimal salary)
    {
        EmployeeID = empID;
        Post = post;
        Salary = salary;
    }

    public decimal CalculateAnnualTaxes()
    {
        decimal taxRate = 0.15M; // Assume a tax rate of 15%
        decimal annualTaxes = Salary * taxRate;
        return annualTaxes;
    }
}

class Program
{
    static void Main()
    {
        int empID = 123;
        string post = "Manager";
        decimal salary = 50000;

        Employee employee1 = new Employee(empID, post, salary);

        Console.WriteLine("Employee ID: " + employee1.EmployeeID);
        Console.WriteLine("Post: " + employee1.Post);
        Console.WriteLine("Salary: " + employee1.Salary);

        decimal annualTaxes = employee1.CalculateAnnualTaxes();
        Console.WriteLine("Annual Taxes: " + annualTaxes);

        // Creating another employee object using a different constructor
        Employee employee2 = new Employee(456, "Developer", 60000);

        Console.WriteLine("\nEmployee ID: " + employee2.EmployeeID);
        Console.WriteLine("Post: " + employee2.Post);
        Console.WriteLine("Salary: " + employee2.Salary);

        annualTaxes = employee2.CalculateAnnualTaxes();
        Console.WriteLine("Annual Taxes: " + annualTaxes);
    }
}
