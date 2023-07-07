using System;

static class StringExtensions
{
    public static int IndexOfEx(this string str, string value, int startIndex)
    {
        if (str == null)
        {
            throw new ArgumentNullException(nameof(str), "Input string cannot be null.");
        }

        return str.IndexOf(value, startIndex);
    }
}

class Program
{
    static void Main()
    {
        string str = null;
        string value = "example";
        int startIndex = 0;

        try
        {
            int index = str.IndexOfEx(value, startIndex);
            Console.WriteLine("Index of '{0}' in the string: {1}", value, index);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
