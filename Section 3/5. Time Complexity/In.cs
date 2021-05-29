using System;
using System.Collections.Generic;
using System.IO;

namespace TimeComplexity
{
    public class In
    {
        public static IEnumerable<int> ReadIntsAsync(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File dont exists in the path specified.");
                yield break;
            }

            var linesRead = File.ReadAllLines(filePath);

            foreach (var line in linesRead)
            {
                yield return int.Parse(line);
            }
        }
    }
}