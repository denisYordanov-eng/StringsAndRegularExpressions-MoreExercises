using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07_Hideout_AnotherSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // Read input text.
         

            while (true) // Make while loop.
            {
                string[] searchSymbolCount = Console.ReadLine().Split(' ').ToArray(); //Read searched symbol and count of the symbols.
                string wantedSymbol = searchSymbolCount[0]; // Initialize wanted symbol from the array.
                int wantedCount = int.Parse(searchSymbolCount[1]);  //Initialize wanted count from the array.

                string pattern = $@"\{wantedSymbol}{{{wantedCount},}}"; //Make regexPatern
                var match = Regex.Match(input, pattern); //Make regexMatch.
                if (match.Success)  // Chek if match success. 
                {
                    Console.WriteLine($"Hideout found at index {match.Index} and it is with size {match.Length}!"); //Print output.
                    return; //Stop the program.
                }

            }
        }
    }
}
