Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
// ShouldPlay();

if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var roll = random.Next(1, 6);
        var target = random.Next(1, 6);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool WinOrLose(int target, int roll)
{
    if (roll > target)
        return true;
    else
        return false;
}

bool ShouldPlay()
{
    var userInput = Console.ReadLine();

    if (userInput == "Y")
    {
        return true;
    }
    else if (userInput == "N")
    {
        return false;
    }
    else
    {
        System.Console.WriteLine("Sorry can you type in again?");
        return ShouldPlay();
    }
}