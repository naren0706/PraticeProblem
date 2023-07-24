namespace PraticeProblem
{
    internal class SumOfDigit
    {
        internal static void GetSum()
        {
            Console.WriteLine("Enter length of the array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Enter the array element");
            int sum = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum+=array[i];
            }
            Console.WriteLine("the sum is "+sum);
        }
    }
}