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
                    "\n3.get the frequency\n4.Get minimum and maximum of an array");
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
                }
            }
        }
    }
}