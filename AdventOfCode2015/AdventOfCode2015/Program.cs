using System;
using System.IO;
using AdventOfCode2015;
using System.Collections.Generic;
using System.Reflection;

namespace AdventOfCode2015
{
    internal class Program
    {
        // Will call general methods depending on the problem
        static void Main(string[] args)
        {
            try
            {
                Day2();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static private void Day2()
        {
            List<IList<int>> dimensionList = new List<IList<int>>();
            using (var streamReader = new StreamReader("../../../Input/day2Input.txt"))
            {
                string entry;
                while ((entry = streamReader.ReadLine()) != null)
                {
                    var split = entry.Split('x');
                    List<int> curLine = new List<int>();
                    foreach (var num in split)
                    {
                        curLine.Add(Int32.Parse(num));
                    }
                    curLine.Sort();
                    dimensionList.Add(curLine);
                }
            }
            Console.WriteLine("ToDo");
            // Have list of dimensions. Get total.
        }

        static private void Day1(string input)
        {
            using (var streamReader = new StreamReader("../../../Input/day1Input.txt"))
            {
                input = streamReader.ReadToEnd();
            }
            Console.WriteLine(CascadingCounter<char>.CascadeCount<char>('(', ')', input.ToArray()));
        }
    }
}