using System;
using System.Text;

namespace _2midtermtest
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder ToUpperString(this StringBuilder stringBuilder)
        {
            string vowels = "aeiouAEIOU";
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (vowels.Contains(stringBuilder[i].ToString()))
                {
                    stringBuilder[i] = char.ToUpper(stringBuilder[i]);
                }
            }
            return stringBuilder;
        }
    }

    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Hello, world!");
            Console.WriteLine("Original string: " + sb.ToString());
            sb = sb.ToUpperString(); 
            Console.WriteLine("Modified string: " + sb.ToString());
        }
    }
}
