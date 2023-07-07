using System;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = null;

        // Avoid exception handling by using conditional statement and null check
        if (str1 != null && str2 != null)
        {
            bool areEqual = str1.Equals(str2);
            Console.WriteLine("Are the strings equal? " + areEqual);
        }
        else
        {
            Console.WriteLine("One or both strings are null.");
        }
    }
}
