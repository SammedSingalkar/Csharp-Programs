using System;

class University
{
    protected string universityName;
    protected int totalStudents;

    public University(string name, int students)
    {
        universityName = name;
        totalStudents = students;
    }

    public void DisplayUniversityInfo()
    {
        Console.WriteLine("University Name: " + universityName);
        Console.WriteLine("Total Students: " + totalStudents);
    }
}

class College : University
{
    private string collegeName;
    private int totalEnrollment;

    public College(string universityName, int totalStudents, string name, int enrollment)
        : base(universityName, totalStudents)
    {
        collegeName = name;
        totalEnrollment = enrollment;
    }

    public void DisplayCollegeInfo()
    {
        DisplayUniversityInfo(); // Accessing the base class method
        Console.WriteLine("College Name: " + collegeName);
        Console.WriteLine("Total Enrollment: " + totalEnrollment);
    }
}

class Program
{
    static void Main()
    {
        string universityName = "ABC University";
        int totalStudents = 10000;

        string collegeName = "XYZ College";
        int totalEnrollment = 500;

        College college = new College(universityName, totalStudents, collegeName, totalEnrollment);

        college.DisplayCollegeInfo();
    }
}
