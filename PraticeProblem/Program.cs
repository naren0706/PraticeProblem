using System;

namespace PraticeProblem
{
    class Program 
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.count of duplicate element\n2.get unique elements" +
                    "\n3.get the frequency\n4.Get minimum and maximum of an array\n5.star patten 1\n6.hollow box\n7.word Reverse\n8.Capitalise");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ArrayElements.GetCount();
                        break;
                    case 2:
                        ArrayElements.GetUniqueElement();
                        break;
                    case 3:
                        ArrayElements.GetFrequency();
                        break;
                    case 4:
                        ArrayElements.GetMinMax();
                        break;
                    case 5:
                        StarPattern.Triangle();
                        break;
                    case 6:
                        StarPattern.HollowBox();
                        break;
                    case 7:
                        StringReverse.Reverse();
                        break;
                    case 8:
                        SumOfDigit.GetSum();
                        break;
                    case 9:
                        StringCapital.Capital();
                        break;
                    case 10:
                        lowestSum.GetLower();
                        break;

                }
            }
        }
    }
}