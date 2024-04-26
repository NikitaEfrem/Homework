using System;
using System.Text;

namespace _2midtermtest
{
   
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
