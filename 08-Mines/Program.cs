using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Mines
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string path = Console.ReadLine(); //Read input.

            int startIndex = 0; //Make a variable for start index.
            int endIndex = 0; // Make a variable fo end index.

            while ((startIndex = path.IndexOf("<",startIndex)) != -1 //Make a while loop and set boundaries "<", ">".
                && (endIndex = path.IndexOf(">",startIndex)) != -1)
            {
                string bombChars = path.Substring(startIndex + 1, 2); //Take chars betwenn the boundaries.
                int bombStrength = CalculateBombStr(bombChars); //Calculate substraction between two characters.

                int leftFromTheBomb = Math.Max(0,startIndex - bombStrength); //Calculate how many characters have to replace before the "<".
                int rightFromTheBomb = Math.Min(path.Length - 1, endIndex + bombStrength); // Calculate how many characters have to replace after the">".

                StringBuilder sb = new StringBuilder(path); // Make stringbuilder.

                for (int i = leftFromTheBomb; i <= rightFromTheBomb;  i++)//Make a for loop from start index to end index.
                {
                    sb[i] = '_'; //Replace current character with "_";
                }
                path = sb.ToString(); //Replace path with sb.
               
            }
            Console.WriteLine(path); // print the sb.
        }

        private static int CalculateBombStr(string bombChars)
        {
            return Math.Abs(bombChars[0] - bombChars[1]); // substract one character with  the other.
        }
    }
}
