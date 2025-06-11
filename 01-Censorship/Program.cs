using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_Censorship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text =  Console.ReadLine();
            string replacePatern = $@"{Regex.Escape(word)}";

            string newText = Regex.Replace
                (text, replacePatern, new string('*', word.Length));

            Console.WriteLine (newText);
        }
    }
}
