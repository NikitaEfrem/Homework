Console.WriteLine("Enter the number of elements:");
int n = Convert.ToInt32(Console.ReadLine());

int positiveCount = 0;
int negativeCount = 0;
int zeroCount = 0;

Console.WriteLine("Enter the numbers:");
for (int i = 0; i < n; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        positiveCount++;
    }
    else if (number < 0)
    {
        negativeCount++;
    }
    else
    {
        zeroCount++;
    }
}
    Console.WriteLine($"Number of positive numbers: {positiveCount}");
    Console.WriteLine($"Number of negative numbers: {negativeCount}");
    Console.WriteLine($"Number of zeros: {zeroCount}");