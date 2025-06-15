using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05_OnlyLetters_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //Read input text.
            string regexPatern = @"(\d+)"; // Read regex matching patern.
            
            var matchDigits = Regex.Matches(input, regexPatern); // Match digits.
 
            foreach (Match match in matchDigits) //Foreach matches.
            {
                int count = match.Index; //Get the index of the match.
                for (int i = match.Index + 1; i < input.Length ; i++) //Make a for loop to input.length.
                {
                    char nextCh = input[i]; //Make a variable for the next char.
                    if (char.IsLetter(nextCh)) // Check if char is letter.
                    {
                       input = Regex.Replace(input,match.Value,nextCh.ToString()); //Replace digit to the next letter.
                    }
                }
            }
            Console.WriteLine(input); // Print  new string as an output.
        }
    }
}
