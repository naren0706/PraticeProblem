using System.Collections;
using System.Collections.Generic;

namespace PraticeProblem
{
    internal class ArrayElements
    {
        public static Dictionary<String,int> ArrayToDict()
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
            return dictionary;
        }

        public static void GetCount()
        {
            Dictionary<string,int> dict = ArrayToDict();
            int count = 0;
            foreach (var item in dict.Keys)
            {
                if (dict[item] > 1)
                    count++;
            }
            Console.WriteLine("The count of duplicate items are" + count);
        }
        public static void GetUniqueElement()
        {
            Dictionary<string, int> dict = ArrayToDict();
            string uniqueElement = "";
            foreach (var item in dict.Keys)
            {
                if (dict[item] == 1)
                    uniqueElement += (item+" ");
            }
            Console.WriteLine("The count of unique elements are " + uniqueElement);
        }

        internal static void GetFrequency()
        {
            Dictionary<string, int> dict = ArrayToDict();
            foreach (var item in dict)
            {
                Console.WriteLine("The count of "+item.Key+" is " + item.Value);
            }
        }

        internal static void GetMinMax()
        {
            Console.WriteLine("Enter length of the array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Enter the array element");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min, max;

            if (array[0] < array[1])
            {
                min = array[0];
                max = array[1]; 
            }
            else
            {
                min = array[1];
                max = array[0];
            }
            for (int i = 0; i < length ; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("the max number is "+max+"\n"+"the minimum number is "+min);
        }
    }
}