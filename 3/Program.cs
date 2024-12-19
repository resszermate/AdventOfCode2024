using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
            Part2();

        }

        private static void Part1()
        {
            string data = File.ReadAllText("input.txt");

            Regex pattern = new Regex(@"mul\((\d{1,3}),(\d{1,3})\)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = pattern.Matches(data);

            List<string> validInstructions = new List<string>();

            foreach (Match match in matches)
            {
                validInstructions.Add(match.Value);
            }

            int final = 0;

            foreach (string instruction in validInstructions)
            {
                string modInstruction = instruction.Remove(instruction.Length - 1);
                string[] twoNumbers = modInstruction.Substring(4).Split(',');
                final += int.Parse(twoNumbers[0]) * int.Parse(twoNumbers[1]);
            }

            Console.WriteLine(final);
        }

        private static void Part2()
        {
            string data = File.ReadAllText("input.txt");

            Regex pattern = new Regex(@"do\(\)|don't\(\)|mul\((\d{1,3}),(\d{1,3})\)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = pattern.Matches(data);

            List<string> validInstructions = new List<string>();

            int final = 0;

            bool enabled = true;

            foreach (Match match in matches)
            {
                string matchStr = match.Value;

                if (matchStr[0] == 'm' && enabled)
                {

                    string modmatchStr = matchStr.Remove(matchStr.Length - 1);
                    string[] twonumbers = modmatchStr.Substring(4).Split(',');
                    final += int.Parse(twonumbers[0]) * int.Parse(twonumbers[1]);
                }
                else
                {
                    if (matchStr == "do()")
                    {
                        enabled = true;
                    }
                    else
                    {
                        enabled = false;
                    }
                }
            }

          

            Console.WriteLine(final);

        }
    }
}
