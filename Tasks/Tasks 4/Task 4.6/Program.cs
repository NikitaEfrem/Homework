int birthday = 19;

var numbers = Enumerable.Range(100, 700);

var div = numbers.Where(num => num % birthday == 0);

foreach (var num in div)
{
    Console.WriteLine(num);
}