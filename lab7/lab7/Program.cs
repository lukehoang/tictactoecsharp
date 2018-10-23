
//Luke-Mung Hoang
//Lab7 - QA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Program
    {
        public char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static void Main(string[] args)
        {

        }


        //method to create the game board
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

        //method to check the current player
        public char currentPlayer(char currentPlayer)
        {
            return currentPlayer;
        }


        //method to changePlayer from X to O and from O to X. Assuming the player is always X and O in TicTacToe game
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

        //method to make a game move
        public void makeMove(char player, int move)
        {

            if (player == 'X')
            {
                arr[move] = 'X';
            }
            else
            {
                arr[move] = 'O';
            }

        }

        //method to check whether if a field is unoccupied.
        //if empty return True
        //if be used return False
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
