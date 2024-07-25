
Console.WriteLine("How many times do you want to roll the dice? ");
string input = Console.ReadLine();
int counter = 0;

if(int.TryParse(input, out counter))
{
    for(int i = 0; i < counter; i++)
    {
        OutComes();
        Console.WriteLine("\n");
    }
}
else
{
    Console.WriteLine($"{input} is not a number.");
}

void OutComes()
{
    Random random = new Random();
    int luck = random.Next(100);

    string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
    string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
    string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
    string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};
    string outComeLetter = (luck > 75 ? "A" : (luck < 25 ? "C" : "B"));

    Console.WriteLine($"```Output {outComeLetter}");
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));

    for(int i = 0; i < fortune.Length; i++)
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}