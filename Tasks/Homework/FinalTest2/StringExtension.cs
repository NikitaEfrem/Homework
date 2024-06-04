using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2
{
        public static class StringExtensions
        {
            public static string ReplaceVowels(this string str, char replacementChar)
            {
                if (string.IsNullOrEmpty(str))
                {
                    return str;
                }

                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
                char[] chars = str.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (vowels.Contains(chars[i]))
                    {
                        chars[i] = replacementChar;
                    }
                }
                return new string(chars);
            }
        }
}
