// Rock-Paper-Scissors Mini Game with GitHub Copilot
// This game allows the player to compete against the computer
// Rules: Rock beats Scissors, Scissors beats Paper, Paper beats Rock

// TODO: Initialize game variables for tracking scores and game state
int playerWins = 0;
int computerWins = 0;
int ties = 0;
bool playAgain = true;
string[] validChoices = { "rock", "paper", "scissors" };

Console.WriteLine("Welcome to Rock-Paper-Scissors!");
Console.WriteLine("Ready to build a mini game with .NET/C# with help from GitHub Copilot?");
Console.WriteLine("=" + new string('=', 50));

// TODO: Main game loop - continue until player decides to quit
while (playAgain)
{
    // TODO: Get valid player input
    string playerChoice = "";
    bool validInput = false;
    
    while (!validInput)
    {
        Console.WriteLine("\nEnter your choice (rock, paper, or scissors): ");
        playerChoice = Console.ReadLine()?.ToLower() ?? "";
        
        if (Array.Exists(validChoices, element => element == playerChoice))
        {
            validInput = true;
        }
        else
        {
            Console.WriteLine("Invalid option! Please choose rock, paper, or scissors.");
        }
    }

    // TODO: Generate computer's random choice
    Random random = new Random();
    int computerChoiceIndex = random.Next(0, 3);
    string computerChoice = validChoices[computerChoiceIndex];
    
    Console.WriteLine($"\nYou chose: {playerChoice}");
    Console.WriteLine($"Computer chose: {computerChoice}");

    // TODO: Determine the winner of the current round
    string roundResult = DetermineWinner(playerChoice, computerChoice);
    
    if (roundResult == "win")
    {
        playerWins++;
        Console.WriteLine("🎉 You won this round!");
    }
    else if (roundResult == "lose")
    {
        computerWins++;
        Console.WriteLine("💻 Computer won this round!");
    }
    else
    {
        ties++;
        Console.WriteLine("🤝 It's a tie!");
    }

    // TODO: Display current score
    DisplayScore(playerWins, computerWins, ties);

    // TODO: Ask player if they want to play again
    Console.WriteLine("\nDo you want to play again? (yes/no): ");
    string playAgainInput = Console.ReadLine()?.ToLower() ?? "no";
    playAgain = playAgainInput == "yes" || playAgainInput == "y";
}

// TODO: Display final score and end game message
Console.WriteLine("\n" + new string('=', 50));
Console.WriteLine("Game Over! Here's your final score:");
DisplayScore(playerWins, computerWins, ties);
Console.WriteLine("Thanks for playing!");

// TODO: Method to determine the winner based on game rules
string DetermineWinner(string player, string computer)
{
    // Rock beats Scissors, Scissors beats Paper, Paper beats Rock
    if (player == computer)
    {
        return "tie";
    }ReaderWriterLockSlim
    
    if (player == "rock" && computer == "scissors")
        return "win";
    if (player == "scissors" && computer == "paper")
        return "win";
    if (player == "paper" && computer == "rock")
        return "win";
    
    return "lose";
}

// TODO: Method to display the current score
void DisplayScore(int wins, int losses, int draws)
{
    Console.WriteLine($"\n--- Current Score ---");
    Console.WriteLine($"You: {wins} | Computer: {losses} | Ties: {draws}");
}
