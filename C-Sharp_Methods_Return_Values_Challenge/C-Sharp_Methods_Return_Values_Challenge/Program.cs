Random random = new Random();

Console.WriteLine("would you like to play? (Y/N)");

if(ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while(play)
    {
        int target;
        int roll;

        target = random.Next(1, 6);
        roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine($"\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string play = Console.ReadLine().ToLower();

    return play == "y" ? true : false;
}

string WinOrLose(int target, int roll)
{
    return target > roll ? "You lose!" : "You win!";
}