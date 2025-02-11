namespace TicTacToeConsoleApp {
    public class TicTacToe {
        
        static void Main() {
            // string menuInput = "";
            int choice;
            Game game = new();


            // Print menu
            Console.WriteLine("\n\tWelcome to Tic-Tac-Toe!\n");
            Console.WriteLine("\t 1. Start a game of Tic-Tac-Toe.");
            Console.WriteLine("\t 2. Exit application.");
            Console.Write("\n\tEnter a number and press ENTER: ");
            choice = Convert.ToInt32(Console.ReadLine());
        

            switch (choice) {
                case 1:
                    game.startGame();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("\tThat didn't work");
                    break;
            }

            Console.WriteLine("\tExiting. Press any key to continue...");
            Console.Read();
        }

    }
}