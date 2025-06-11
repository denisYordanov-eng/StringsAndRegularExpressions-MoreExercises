using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_EmailMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexPatern = @"(\@)";
            string email = Console.ReadLine();
           
            var split = Regex.Split(email, regexPatern);
            string word1 = split[0];
            string word2 = split[2];

            int sum1 = 0;
            for (int i = 0; i < word1.Length; i++)
            {
                int currentLetter = word1[i];
                sum1+= currentLetter;
            }
            int sum2 = 0;
            for (int j = 0; j < word2.Length; j++)
            {
                int currentDiggit = word2[j];
                sum2+= currentDiggit;
            }
            if ((sum1 - sum2) >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                   Console.WriteLine("She is not the one.");
            }

        }
    }
}
