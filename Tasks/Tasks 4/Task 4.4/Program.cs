ConsoleKeyInfo info = Console.ReadKey();

if (info.Key == ConsoleKey.W)
{
    Console.WriteLine(" The figure needs to be moved up");
}
else if (info.Key == ConsoleKey.S)
{
    Console.WriteLine(" The figure needs to be moved back");
}
else if(info.Key == ConsoleKey.A)
{
    Console.WriteLine(" The figure needs to be moved left");
}
else if (info.Key == ConsoleKey.D)
{
    Console.WriteLine(" The figure needs to be moved right");
}
else
{
    Console.WriteLine(" No movement is needed");
}