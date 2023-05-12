using System;
using System.IO;
using AdventOfCode2015;
using System.Collections.Generic;

namespace AdventOfCode2015
{
    internal class Program
    {
        // Will call general methods depending on the problem
        static void Main(string[] args)
        {
            try
            {
                string input;
                using (var streamReader = new StreamReader(@"C:\Users\Michael\Documents\Development\AdventOfCode2015\AdventOfCode2015\Input\day1Input.txt")) 
                {
                    input = streamReader.ReadToEnd();
                }
                Console.WriteLine(CascadingCounter<char>.CascadeCount<char>('(', ')', input.ToArray()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}