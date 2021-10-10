using System;

namespace Palindrome
{
    public class Program
    {
        static void Main()
        {
            string enteredWord, reversedWord;
            Console.WriteLine("Enter a word ");
            enteredWord = Console.ReadLine();
            char[] charArray = enteredWord.ToCharArray();
            Array.Reverse(charArray);
            reversedWord = new string(charArray);
            bool isPalindrome = enteredWord.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);
            if (isPalindrome)
            {
                Console.WriteLine(enteredWord + " is a Palindrome");
            }
            else
            {
                Console.WriteLine(enteredWord + " is not a Palindrome");
            }
            Console.ReadKey();
        }
    }
}
