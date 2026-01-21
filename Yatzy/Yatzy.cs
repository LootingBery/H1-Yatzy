namespace Yatzy
{
    internal class Yatzy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many players? (1-4 players)");
            string playerInput = Console.ReadLine();

            if (!int.TryParse(playerInput, out int amountOfPlayers) || amountOfPlayers < 1 || amountOfPlayers > 4)
            {
                Console.WriteLine("Invalid input. 1 player by default.");
                amountOfPlayers = 1;
            }

            Console.WriteLine("What is the name of players?");
                List<string> playerNames = new List<string>();
            for (int i = 1; i <= amountOfPlayers; i++)
            {
                playerNames.Add(playerInput);
            }
        }
    }
}
