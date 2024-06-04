namespace FinalTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Message to you";
            string replacedMessage = message.ReplaceVowels('*');

            Console.WriteLine(replacedMessage);
        }
    }
}
