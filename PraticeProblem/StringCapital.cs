namespace PraticeProblem
{
    internal class StringCapital
    {
        internal static void Capital()
        {
            string result = "";
            Console.WriteLine("Enter a sentence");
            string input = Console.ReadLine();
            string[] words = input.Split(" ");
            foreach (string word in words)
            {
                result += Char.ToUpper(word[0]) + word.Substring(1)+" ";
                
            }
            Console.WriteLine(result);
        }
    }
}