using System;

class Student
{
    public string RegistrationNumber { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Student(string regNumber, string name, DateTime dob)
    {
        RegistrationNumber = regNumber;
        Name = name;
        DateOfBirth = dob;
    }

    public int CalculateAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - DateOfBirth.Year;
        if (today < DateOfBirth.AddYears(age))
        {
            age--;
        }
        return age;
    }
}

class Program
{
    static void Main()
    {
        string regNumber = "12345";
        string name = "John Doe";
        DateTime dob = new DateTime(2000, 10, 15);

        Student student = new Student(regNumber, name, dob);

        Console.WriteLine("Registration Number: " + student.RegistrationNumber);
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Date of Birth: " + student.DateOfBirth.ToShortDateString());

        int age = student.CalculateAge();
        Console.WriteLine("Age: " + age);
    }
}
