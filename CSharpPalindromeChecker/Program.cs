using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Start();
    }

    static void Start()
    {
        Console.WriteLine("Please enter a string and I will check to see if it is a palindrome.");
        string userInput = Console.ReadLine();
        if (PalindromeChecker(userInput))
        {
            Console.WriteLine("Yep, that's a palindrome!");
        }
        else
        {
            Console.WriteLine("No, not a palindrome!");
        }


        Console.ReadLine();
    }

    static string ReverseString(string str)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }

        return sb.ToString();
    }

    static string RemoveSpecialCharacters(string str)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            if ((str[i] >= 'A' && str[i] <= 'z'))
            {
                sb.Append(str[i]);
            }
        }

        return sb.ToString();
    }

    static bool PalindromeChecker(string str)
    {
        return (RemoveSpecialCharacters(str).ToLower() == ReverseString(RemoveSpecialCharacters(str).ToLower()));
    }
}