using System.Text;

int num1 = 3;
int num2 = 56;

StringBuilder sb1 = new StringBuilder();
sb1.Append(num1).Append(" + ").Append(num2).Append(" = ").Append(num1 + num2);
Console.WriteLine(sb1);

StringBuilder sb2 = new StringBuilder();
sb2.Append(num1).Append(" - ").Append(num2).Append(" = ").Append(num1 - num2);
Console.WriteLine(sb2);

StringBuilder sb3 = new StringBuilder();
sb3.Append(num1).Append(" * ").Append(num2).Append(" = ").Append(num1 * num2);
Console.WriteLine(sb3);

sb1.Replace("=", "equals");
sb2.Replace("=", "equals");
sb3.Replace("=", "equals");

Console.WriteLine("После замены:");
Console.WriteLine(sb1);
Console.WriteLine(sb2);
Console.WriteLine(sb3);

Console.ReadKey();