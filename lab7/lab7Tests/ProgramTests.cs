//Luke-Mung Hoang
//Lab7 - QA


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
        //Test to check the board has 9 active fields
        [TestMethod()]
        public void boardHas9FieldsTest()
        {
            var ttt = new Program();
            ttt.createBoard();
            int fields = ttt.arr.Length - 1;
            Assert.AreEqual(9, fields);
        }

        //Test to check the current player is X
        [TestMethod()]
        public void currentPlayerTestX()
        {
            var ttt = new Program();
            char player = 'X';
            char playerTest = ttt.currentPlayer(player);
            Assert.AreEqual('X', playerTest);
        }

        //Test to check the current player is O
        [TestMethod()]
        public void currentPlayerTestO()
        {
            var ttt = new Program();
            char player = 'X';
            player = ttt.changePlayer(player);
            Assert.AreEqual('O', player);
        }

        //Test to check that the current player places an X in a spot on the board
        [TestMethod()]
        public void playerXplays()
        {
            var ttt = new Program();
            char player = 'X';
            ttt.makeMove(player, 9);
            ttt.createBoard();
            Assert.AreEqual('X', ttt.arr[9]);
        }

        //Test to check that the current player places an O in a spot on the board
        [TestMethod()]
        public void playerOplays()
        {
            var ttt = new Program();
            char player = 'O';
            ttt.makeMove(player, 9);
            ttt.createBoard();
            Assert.AreEqual('O', ttt.arr[9]);
        }

        //Test to check that the placement is in an unoccupied spot
        [TestMethod()]
        public void spaceInUseTest()
        {
            var ttt = new Program();
            char player = 'O';
            ttt.arr[1] = '1';
            ttt.arr[2] = '2';
            ttt.arr[3] = '3';
            ttt.arr[4] = 'O';
            ttt.arr[5] = 'X';
            ttt.arr[6] = 'O';
            ttt.arr[7] = 'X';
            ttt.arr[8] = '8';
            ttt.arr[9] = '9';
            ttt.createBoard();//initial Board
            bool empty = ttt.spaceInUse(9); // at this time, the value before player O places into 9th field is '9' 
            Console.WriteLine(empty); //bool value is true since 9th field has not been used.
            ttt.makeMove(player, 9); //now O places an O into 9th field
            ttt.createBoard();//Updated Board after O made a move, 

            empty = ttt.spaceInUse(9);//at this point, the bool value should be False since player O has just places an O on it.           
            Assert.AreEqual(false, empty);
        }
    }
}