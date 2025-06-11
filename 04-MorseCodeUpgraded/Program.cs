using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_MorseCodeUpgraded
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] input = Console.ReadLine().Split('|').ToArray();
            
        StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                
                string currentNum = (input[i]);
              int sum = CheckingEveryDigit(currentNum);
                sum += CheckForSequence(currentNum);
                char letter = (char)sum;
                sb.Append(letter.ToString());
            }  
            Console.WriteLine(sb.ToString());   
        }

        private static int CheckForSequence(string currentNum)
        {
            int sum = 0;
            int count = 1;
            for (int i = 1; i < currentNum.Length; i++)
            {
                char currentDigit = currentNum[i];
                char previousDigit = currentNum[i - 1];
                if (currentDigit == previousDigit)
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                    {
                        sum += count;
                    }
                    count = 1;
                }
            }
            if (count > 1)
            {
                sum += count;
            }
            return sum;
        }

        private static int CheckingEveryDigit(string currentNum)
        {
            int sum = 0;
            foreach (char digit in currentNum)
            {
                
                if (digit == '0')
                {
                    sum += 3;
                }
                else if (digit == '1') 
                {
                    sum += 5;
                }
                
            }
            return sum;
        }
    }
}
