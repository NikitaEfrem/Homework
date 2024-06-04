namespace FinalTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryOperations operations = new DictionaryOperations();
            Dictionary<string, int> dictionary = operations.InitializeDictionary(10);
            Console.WriteLine("Исходный словарь:");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            var result = operations.ProcessDictionary(dictionary);
            Console.WriteLine("Результирующий словарь:");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
