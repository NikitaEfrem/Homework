string poem = "Вам, проживающим за оргией оргию,\r\nимеющим ванную и теплый клозет!\r\nКак вам не стыдно о представленных к Георгию\r\nвычитывать из столбцов газет?!";
string[] words= poem.Split(' ');

foreach (string word in words)
{
	for (int i = 1; i < word.Length; i+=2)
	{
		Console.Write(word[i]);
	}
    Console.Write(" ");
}
