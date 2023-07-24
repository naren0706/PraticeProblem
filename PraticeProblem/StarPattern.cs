namespace PraticeProblem
{
    internal class StarPattern
    {
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