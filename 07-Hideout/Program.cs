using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07_Hideout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // Read input text.
            string[] searchSymbolCount = Console.ReadLine().Split(' ').ToArray(); //Read searched symbol and count of the symbols.

            while (true) // Make while loop.
            {
                string wantedSymbol = searchSymbolCount[0]; // Initialize wanted symbol from the array.
                int  wantedCount = int.Parse(searchSymbolCount[1]);  //Initialize wanted count from the array.
               
                for ( int i = 0; i < input.Length; i++) // Make a for loop to check every letter from the input.
                {
                    string currentChar = input[i].ToString(); //Make  current char to string.
                    int count = 1; // Make count variable for the searched symbol.
                    int index = 0; // Make variable  for the index.
                    if (currentChar == wantedSymbol) // Check if current char is equal of the wanted char.
                    {    
                        for (int j = i + 1; j < input.Length; j++) //Make for loop to  take the count and index.
                        {
                            index = i; // Take the index from the for loop.
                            string nextChar = input[j].ToString(); // initialize next char.
                            if(nextChar == currentChar) //Check if next char is equal of the wanted char.
                            {
                                count++;  // If is equal increment the count.
                            }
                            else
                            {
                                break; // If it is not  equal break the for loop.
                            }
                        }
                        if(count >= wantedCount) //Check if the count is bigger or equal of the wantedCount.
                        {
                            Console.WriteLine($"Hideout found at index {index} and it is with size {count}!"); //Print the output.
                            return; //Stop the program.
                        }
                        else
                        {
                            index = 0; // Make index 0 again.
                            count = 1; // Make Count to 1;
                            continue; // Continue searching for whe wanted symbol and wanted count in the input.
                        }
                    }

                }
                searchSymbolCount = Console.ReadLine().Split(' ').ToArray(); //Read the new  searched symbol and count of the symbols.
            }
        }
    }
}
