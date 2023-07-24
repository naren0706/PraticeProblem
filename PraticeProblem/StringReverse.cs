namespace PraticeProblem
{
    internal class StringReverse
    {
        internal static void Reverse()
        {
            string result = "";
            Console.WriteLine("Enter a sentence");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }
                result += " ";
            }
            Console.WriteLine(result);
        }
    }
}