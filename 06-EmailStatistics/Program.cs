using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_EmailStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string regex = @"^(?<name>[A-Za-z]{5,})@(?<domain>[a-z]{3,}\.(com|bg|org))$";
            Regex patern = new Regex(regex);
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                if (patern.IsMatch(inputLine))
                {
                    Match match = patern.Match(inputLine);
                    string username = match.Groups["name"].Value;
                    string domain = match.Groups["domain"].Value;

                    if (!dict.ContainsKey(domain))
                    {
                        dict[domain] = new List<string>();
                    }
                    if (!dict[domain].Contains(username))
                    {
                        dict[domain].Add(username);
                    }
                }
            }
            foreach (var item in dict.OrderByDescending(u => u.Value.Count))
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var user in item.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
