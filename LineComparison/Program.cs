using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparision comparision = new Comparision(1, 2, 3, 4);
            double line1 = comparision.CalculateLength();
            Console.WriteLine("Length of first line "+line1);
            Comparision LineComparision = new Comparision(1, 2, 3, 4);
            double line2 = LineComparision.CalculateLength();
            Console.WriteLine("Length of second line "+line2);
        }
    }
}
