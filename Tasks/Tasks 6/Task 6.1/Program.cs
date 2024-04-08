int[] numbers= new int[6];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Enter array numbers : ");
    numbers [i] = int.Parse(Console.ReadLine());
}    

Array.Sort(numbers);
Array.Reverse(numbers);

Console.WriteLine("Sorted array numbers decreasing : ");

foreach (int element in numbers)
{
    Console.Write(element + " ");
}