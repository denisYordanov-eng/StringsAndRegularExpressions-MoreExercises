using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KarateStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int power = 0;
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == '>')
                {
                    power += int.Parse(path[i + 1].ToString());
                    i++;
                    while (power > 0 && i < path.Length)
                    {
                        if (path[i] == '>')
                        {
                            break;
                        }
                      path =  path.Remove(i, 1);
                        power--;
                    }
                    i--;
                }
            }
            Console.WriteLine(path);
        }
    }
}
