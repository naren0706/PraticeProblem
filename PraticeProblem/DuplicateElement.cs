namespace PraticeProblem
{
    internal class DuplicateElement
    {
        public static void GetCount(int choice)
        {
            Console.WriteLine("Enter length of the array");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[length];
            Console.WriteLine("Enter the array element");
            for(int i  = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            Dictionary<string,int> dictionary = new Dictionary<string,int>();
            foreach (string key in array)
            {
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key] += 1;
                }
                else
                {
                    dictionary.Add(key, 1);
                }
            }            
            int count = 0;
            foreach (var item in dictionary.Keys)
            {
                if (dictionary[item] > 1)
                    count++;
            }
            Console.WriteLine("The count of duplicate items are"+count);
        }
    }
}