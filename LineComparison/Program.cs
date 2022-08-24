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
            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("Both lines are same");
                return;
            }
                
            if (line1.CompareTo(line2) > 0)
                Console.WriteLine("Line 1 is greater than line 2");
            else
                Console.WriteLine("Line 2 is greater than line 1");
        }
    }
}
