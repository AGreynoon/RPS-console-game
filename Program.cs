using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Rock__paper__scissor__Game
{
    class Program
    {
        static int computer_count = 0;
        static int player_count = 0;
        static int rounds = 0;
        static string name_player;
        static string player;
        static int start_play;
        static string[] value = new string[] { "r", "p", "s" };
        static Random random = new Random();
        public static void menu()
        {
            Console.WriteLine("**Welcome to Rock paper scissor Game**");
            Console.WriteLine("--------------------------------------");
            Console.Write("Press 'S' to start the game or 'E' to exit:");
            string answer = Console.ReadLine();
            if (answer == "s" || answer == "S")
            {
                start();
            }
            else if (answer == "e" || answer == "E")
            {
                exist();
            }
            else
            {
                Console.Clear();
                menu();
            }
        }
        public static void start()
        {
            Console.WriteLine("______________________________________");
            Console.Write("Enter your name: ");
            name_player = Console.ReadLine();
            Console.WriteLine("Hello " + name_player + ", you will play against the computer on 3 rounds.\nBe ready!");
            Console.WriteLine("______________________________________");
            play();
        }
        public static void play()
        {
            Console.WriteLine("Choose one of these options: ");
            Console.WriteLine("[r --> represent to rock]\n[p --> represent to paper]\n[s --> represent to scissor]");
            while (rounds != 3)
            {
                start_play = random.Next(0, 3);
                Console.Write("Your option: ");
                player = Console.ReadLine();
                check();
                rounds += 1;
            }
            if (player_count > computer_count)
            { 
                Console.WriteLine("=============================GAME-OVER============================");
                Console.WriteLine(name_player + " is the winner");
                Console.WriteLine("=============================GAME-OVER============================");
            }
            else if (computer_count > player_count)
            {

                Console.WriteLine("=============================GAME-OVER==============");
                Console.WriteLine("Computer is the winner");
                Console.WriteLine("=============================GAME-OVER==============");

            }
            else if (computer_count == player_count)
            {
                Console.WriteLine("=============================GAME-OVER=============="); ;
                Console.WriteLine("*Equal*");
                Console.WriteLine("Score of " + name_player + "[" + player_count + "]");
                Console.WriteLine("Score of computer [" + computer_count + "]");
                Console.WriteLine("=============================GAME-OVER==============");
            }
        }
        public static void check()
        {
            if (player == "r" && value[start_play] == "r")
            {
                Console.WriteLine("====================================================");
                Console.WriteLine("*Equal*");
                Console.WriteLine("The player choose: " + player);
                Console.WriteLine("The computer choose: " + value[start_play]);
                Console.WriteLine("Score of " + name_player + ": [" + player_count + "]");
                Console.WriteLine("Score of computer: [" + computer_count + "]");
                Console.WriteLine("=====================================================");
            }
            else if (player == "r" && value[start_play] == "p")
            {
                Console.WriteLine("======================================================");
                Console.WriteLine("*Computer is win*");
                computer_count = computer_count + 1;
                Console.WriteLine("The computer choose: " + value[start_play]);
                Console.WriteLine("The player choose: " + player);
                Console.WriteLine("Score of computer: [" + computer_count + "]");
                Console.WriteLine("Score of " + name_player + ": [" + player_count + "]");
                Console.WriteLine("====================================================");
            }
            else if (player == "r" && value[start_play] == "s")
            {
                Console.WriteLine("======================================================");
                Console.WriteLine("*" + name_player + " is win*");
                player_count = player_count + 1;
                Console.WriteLine("The player choose: " + player);
                Console.WriteLine("The computer choose: " + value[start_play]);
                Console.WriteLine("Score of " + name_player + ": [" + player_count + "]");
                Console.WriteLine("Score of computer: [" + computer_count + "]");
                Console.WriteLine("====================================================");
            }
            else if (player == "p" && value[start_play] == "r")
            {
                Console.WriteLine("====================================================");
                Console.WriteLine("*" + name_player + " is win*");
                player_count = player_count + 1;
                Console.WriteLine("The player choose: " + player);
                Console.WriteLine("The computer choose: " + value[start_play]);
                Console.WriteLine("Score of " + name_player + ": [" + player_count + "]");
                Console.WriteLine("Score of computer: [" + computer_count + "]");
                Console.WriteLine("===================================================");
            }
            else if (player == "p" && value[start_play] == "p")
            {
                Console.WriteLine("====================================================");
                Console.WriteLine("*Equal*");
                Console.WriteLine("The player choose: " + player);
                Console.WriteLine("The computer choose: " + value[start_play]);
                Console.WriteLine("Score of " + name_player + ": [" + player_count + "]");
                Console.WriteLine("Score of computer: [" + computer_count + "]");
                Console.WriteLine("====================================================");
            }
            else if (player == "p" && value[start_play] == "s")
            {
                Console.WriteLine("====================================================");
                Console.WriteLine("*Computer is wine*");
                computer_count = computer_count + 1;
                Console.WriteLine("The computer choose: " + value[start_play]);
                Console.WriteLine("The player choose: " + player);
                Console.WriteLine("Score of computer: [" + computer_count + "]");
                Console.WriteLine("Score of " + name_player + ": [" + player_count + "]");
                Console.WriteLine("=====================================================");
            }
            else if (player == "s" && value[start_play] == "r")
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine("*Computer is wine*");
                computer_count = computer_count + 1;
                Console.WriteLine("The computer choose: " + value[start_play]);
                Console.WriteLine("The player choose: " + player);
                Console.WriteLine("Score of computer: [" + computer_count + "]");
                Console.WriteLine("Score of " + name_player + ": [" + player_count + "]");
                Console.WriteLine("======================================================");
            }
            else if (player == "s" && value[start_play] == "p")
            {
                Console.WriteLine("====================================================");
                Console.WriteLine("*" + name_player + " is win*");
                player_count = player_count + 1;
                Console.WriteLine("The player choose: " + player);
                Console.WriteLine("The computer choose: " + value[start_play]);
                Console.WriteLine("Score of " + name_player + ": [" + player_count + "]");
                Console.WriteLine("Score of computer: [" + computer_count + "]");
                Console.WriteLine("===================================================");
            }
            else if (player == "s" && value[start_play] == "s")
            {
                Console.WriteLine("====================================================");
                Console.WriteLine("*Equal*");
                Console.WriteLine("The player choose: " + player);
                Console.WriteLine("The computer choose: " + value[start_play]);
                Console.WriteLine("Score of " + name_player + ": [" + player_count + "]");
                Console.WriteLine("Score of computer: [" + computer_count + "]");
                Console.WriteLine("====================================================");
            }
        }
        public static void exist()
        {
            Console.WriteLine("exit from the game");
        }
        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();
        }
    }
}
