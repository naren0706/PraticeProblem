namespace PraticeProblem
{
    internal class StarPattern
    {
        internal static void HollowBox()
        {
            Console.WriteLine("Enter the value");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= input; i++)
            {
                for (int j = 0; j <= input; j++)
                {
                    if (i == 0 || i==input)
                    {
                        Console.Write("*");
                    }
                    else if(j==0||j==input){
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }

        internal static void Triangle()
        {
            Console.WriteLine("Enter the value");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = input; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}