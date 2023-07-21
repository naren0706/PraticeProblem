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
                Console.WriteLine("1.count of duplicate element");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DuplicateElement.GetCount();
                        break;
                    case 2:
                        DuplicateElement.GetUniqueElement();
                        break;
                    case 3:
                        DuplicateElement.GetFrequency();
                        break;
                }
            }
        }
    }
}