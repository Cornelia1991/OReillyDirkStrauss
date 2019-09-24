using System.Linq;
using static System.Console;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace cookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 17, 46, 39, 62, 81, 79, 52, 24, 65 };
            chapter1 ch1 = new chapter1();
            int threshold = 51;
            var (average, studentCount, belowAverage) = ch1.GetAverageAndCount(scores, threshold);
            WriteLine($"Average was {Round(average, 2)} across {studentCount} students. {(average < threshold ?"Class score below average." : "Class score above average" )}");
            ReadLine();
        }
    }
}
