Console.WriteLine("Before calling method");
SayHello();
Console.WriteLine("After calling method");

void SayHello()
{
    Console.WriteLine("Hello World");
}

int[] a = {1, 2, 3, 4, 5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach(var number in a)
    {
        Console.WriteLine($"{number}");
    }
    Console.WriteLine();
}