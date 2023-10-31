using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


class Program
{
    // Function to reverse a string
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    static void Main()
    {
        // Task 1: Accept a word from the user and display its length
        Write("Enter a word: ");
        string word =ReadLine();
        int length = word.Length;
        WriteLine($"Length of the word: {length}");



        // Task 2: Accept a word from the user and display its reverse
        Write("Enter a word to reverse: ");
        string wordToReverse = ReadLine();
        string reversedWord = ReverseString(wordToReverse);
        WriteLine($"Reversed word: {reversedWord}");



        // Task 3: Accept two words from the user and check if they are the same
        Write("Enter the first word: ");
        string firstWord = ReadLine();
        Write("Enter the second word: ");
        string secondWord = ReadLine();
        if (string.Equals(firstWord, secondWord, StringComparison.OrdinalIgnoreCase))
        {
            WriteLine("The two words are the same.");
        }
        else
        {
            WriteLine("The two words are not the same.");
        }
        Read();
    }
    
}
