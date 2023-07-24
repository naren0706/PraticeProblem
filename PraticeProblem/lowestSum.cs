namespace PraticeProblem
{
    internal class lowestSum
    {
       
        public static void GetLower()
        {
            Console.WriteLine("Enter length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];

            Console.WriteLine("Enter the numbers in array");
            int min = arr[0];
            int min2 = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i]<=min && arr[i] >= 0)
                {
                    min = arr[i];
                }
                int res = arr[i], minimum1 = min, minimum2 = min2;
            }
            foreach (var item in arr)
            {
                if(item<min2 && item > min)
                {
                    min2 = item;
                }
            }
            Console.WriteLine("the sum is "+min+" "+min2);
        }
    }
}