using System;

class Program
{
    static void Main()
    {
        string inputString = "Hello, World!";
        Console.WriteLine("Input String: " + inputString);

        // Reverse the string
        string reversedString = ReverseString(inputString);
        Console.WriteLine("Reversed String: " + reversedString);

        // Convert the string to uppercase
        string uppercaseString = ConvertToUppercase(inputString);
        Console.WriteLine("Uppercase String: " + uppercaseString);

        // Count the number of characters in the string
        int charCount = CountCharacters(inputString);
        Console.WriteLine("Character Count: " + charCount);

        // Replace a substring within the string
        string replacedString = ReplaceSubstring(inputString, "Hello", "Hi");
        Console.WriteLine("Replaced String: " + replacedString);

    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        int leftIndex = 0;
        int rightIndex = charArray.Length - 1;

        while (leftIndex < rightIndex)
        {
            char temp = charArray[leftIndex];
            charArray[leftIndex] = charArray[rightIndex];
            charArray[rightIndex] = temp;

            leftIndex++;
            rightIndex--;
        }

        return new string(charArray);
    }

    static string ConvertToUppercase(string str)
    {
        char[] charArray = str.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
        }

        return new string(charArray);
    }

    static int CountCharacters(string str)
    {
        int count = 0;

        foreach (char c in str)
        {
            count++;
        }

        return count;
    }

    static string ReplaceSubstring(string str, string oldSubstring, string newSubstring)
    {
        int index = str.IndexOf(oldSubstring);

        if (index != -1)
        {
            string prefix = str.Substring(0, index);
            string suffix = str.Substring(index + oldSubstring.Length);
            return prefix + newSubstring + suffix;
        }

        return str;
    }

}
