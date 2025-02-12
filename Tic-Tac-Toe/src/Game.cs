namespace TicTacToeConsoleApp {

    public class Game {
        
        public void startGame() {
            bool doGameLoop = true;
            string menuInput;

            do {
                // Game menu
                Console.WriteLine("\n\tNew game started!");
                Console.WriteLine("\n\t x. squares to be selected.");
                Console.Write("\n\tEnter a number to make a move or \"exit\" to exit the game: ");
                menuInput = Console.ReadLine().ToLower();

                switch (menuInput) {
                    case "exit":
                        doGameLoop = false;
                        break;
                    default:
                        Console.WriteLine("\tThat wasn't an option.");
                        break;
                }
                
            } while (doGameLoop);

            Console.WriteLine("\n\tExiting game...\n");
        }
    }

}