using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static void Main(string[] args)
        {

        }

        public void createBoard()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");

        }

        public char currentPlayer(char currentPlayer)
        {
            return currentPlayer;
        }

        public char changePlayer(char currentPlayer)
        {
            if (currentPlayer == 'X')
            {
                currentPlayer = 'O';
            }
            else
            {
                currentPlayer = 'X';
            }

            return currentPlayer;
        }

        public void makeMove(char player, out int choice)
        {

            choice = int.Parse(Console.ReadLine());

            if (player == 'X')
            {
                arr[choice] = 'X';
            }
            else
                arr[choice] = 'O';

        }

        public bool spaceInUse(int position)
        {
            if (arr[position] == 'O' || arr[position] == 'X')
            {
                return false;
            }
            else
                return true;
        }
    }
}
