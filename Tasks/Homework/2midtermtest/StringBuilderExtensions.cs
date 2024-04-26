using System.Text;



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
