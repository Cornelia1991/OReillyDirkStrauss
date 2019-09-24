using System.Linq;
using static System.Console;
using static System.Math;
using System;
using System.Collections.Generic;
using System.Text;

//explanantion of tuples
//need to calulate average score for variable number of students
//want our method to return of students in class
namespace cookbook
{
    public class chapter1
    {
        public (double average, int studentGrade, bool belowAverage) GetAverageAndCount(int[] scores, int threshold) //new
        {
            var returnTuple = (ave: 0D, sCount: 0, subAve: true); //tuple literal

            returnTuple = ((double)scores.Sum() / scores.Count(), scores.Count(), returnTuple.ave.CheckIfBelowAverage(threshold));

            return returnTuple;
        }
    }

    public static class ExtentionMethods //new
    {
        public static bool CheckIfBelowAverage(this double classAverage, int threshold)
        {
            if (classAverage < threshold)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
