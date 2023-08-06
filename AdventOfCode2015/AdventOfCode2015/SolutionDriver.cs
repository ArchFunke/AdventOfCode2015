using AdventOfCode2015.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2015
{
    internal class SolutionDriver
    {
        static public void Day2()
        {
            List<List<int>> dimensionList = new();
            using (var streamReader = new StreamReader("../../../Input/day2Input.txt"))
            {
                string? entry;
                while ((entry = streamReader.ReadLine()) != null)
                {
                    var split = entry.Split('x');
                    List<int> curLine = new();
                    foreach (var num in split)
                    {
                        curLine.Add(Int32.Parse(num));
                    }
                    curLine.Sort();
                    dimensionList.Add(curLine);
                }
            }
            var areaCalculator = new RectangleAreaCalculator(dimensionList);
            // Part 1
            areaCalculator.CalculateAreas();
            Console.WriteLine(areaCalculator.GetTotalArea());
            // Part 2
            areaCalculator.CalculateRibbonLength();
            Console.WriteLine(areaCalculator.GetTotalLength());
        }

        static public void Day1(string input)
        {
            using (var streamReader = new StreamReader("../../../Input/day1Input.txt"))
            {
                input = streamReader.ReadToEnd();
            }
            Console.WriteLine(CascadingCounter<char>.CascadeCount<char>('(', ')', input.ToArray()));
        }
    }
}
