using System;

class StringManipulation
{
    static void Main()
    {
        string str = "Hello, World!";
        Console.WriteLine("Original String: " + str);

        // Length of the string
        int length = str.Length;
        Console.WriteLine("Length of the string: " + length);

        // Convert to uppercase
        string uppercase = str.ToUpper();
        Console.WriteLine("Uppercase string: " + uppercase);

        // Convert to lowercase
        string lowercase = str.ToLower();
        Console.WriteLine("Lowercase string: " + lowercase);

        // Substring
        string substring = str.Substring(7, 5);
        Console.WriteLine("Substring: " + substring);

        // Replace
        string replaced = str.Replace("Hello", "Hi");
        Console.WriteLine("Replaced string: " + replaced);

        // Remove
        string removed = str.Remove(5);
        Console.WriteLine("Removed string: " + removed);

        // Split
        string[] splitArray = str.Split(',');
        Console.WriteLine("Split string:");
        foreach (string splitStr in splitArray)
        {
            Console.WriteLine(splitStr);
        }

        // Concatenate
        string str1 = "Hello";
        string str2 = "World";
        string concatenated = string.Concat(str1, ", ", str2, "!");
        Console.WriteLine("Concatenated string: " + concatenated);

        // Compare
        string str3 = "abc";
        string str4 = "def";
        int compareResult = string.Compare(str3, str4);
        Console.WriteLine("Compare result: " + compareResult);

        // IndexOf
        int indexOf = str.IndexOf("World");
        Console.WriteLine("Index of 'World': " + indexOf);

        // LastIndexOf
        int lastIndexOf = str.LastIndexOf("l");
        Console.WriteLine("Last index of 'l': " + lastIndexOf);

        // Contains
        bool contains = str.Contains("Hello");
        Console.WriteLine("Contains 'Hello': " + contains);
    }
}
