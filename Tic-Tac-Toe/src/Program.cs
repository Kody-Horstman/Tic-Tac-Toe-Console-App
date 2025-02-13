namespace TicTacToeConsoleApp 
{
    public class TicTacToe 
    {    
        static void Main() 
        {
            // string menuInput = "";
            bool doAppLoop = true;
            string choice;
            Game game = new();

            do {
                // Print menu
                Console.WriteLine("\n\tWelcome to Tic-Tac-Toe!\n");
                Console.WriteLine("\t 1. Start a game of Tic-Tac-Toe.");
                Console.Write("\n\tEnter a number or \"exit\": ");
                choice = Console.ReadLine().ToLower();
            

                switch (choice) {
                    case "1":
                        game.startGame();
                        break;
                    case "exit":
                        doAppLoop = false;
                        break;
                    default:
                        Console.WriteLine("\tThe menu was unimpressed...\n");
                        break;
                }
            } while (doAppLoop);

            Console.WriteLine("\tExiting. Press any key to continue...");
            Console.Read();
        }
    }
}