using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        char player = 'X';

        [TestMethod()]
        public void currentPlayerTestX()
        {
            var ttt = new Program();

            char playerTest = ttt.currentPlayer(player);

            Assert.AreEqual('X', playerTest);
        }

        [TestMethod()]
        public void currentPlayerTestO()
        {
            var ttt = new Program();

            char playerTest = ttt.currentPlayer(player);
            playerTest = ttt.changePlayer(playerTest);
            Assert.AreEqual('O', playerTest);
        }

        [TestMethod()]
        public void makeMoveTestX()
        {
            var ttt = new Program();

            char playerTest = ttt.currentPlayer(player);
            int choice;

            Console.WriteLine("now is your turn, let make your move by type in a number according to the board' field");
            ttt.createBoard();
            ttt.makeMove(player, choice);

            char spot = ttt.ar
        }


    }
}