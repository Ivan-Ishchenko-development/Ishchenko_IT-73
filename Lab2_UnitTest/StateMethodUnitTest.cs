using Lab2_;
using Lab2_.State;
using Lab2_.Robot;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_UnitTest
{
    [TestClass]
    public class StateUnitTests
    {
        
        [TestMethod]
        public void GameGenerationTest()
        {
            Game game = new Game(new StartMenu());

            Assert.AreEqual(game.Robot, null);
            Assert.AreEqual(game.pole, null);
            Assert.AreEqual(game.GameHistory, null);
            Assert.AreEqual(game.gamestatus, true);

            game.GenerateNewGame();
            

            Assert.AreNotEqual(game.Robot, null);
            Assert.AreNotEqual(game.pole, null);
            Assert.AreNotEqual(game.GameHistory, null);
            Assert.AreEqual(game.gamestatus, true);

            game.Status(false);

            Assert.AreEqual(game.gamestatus, false);
            

        }

        #region StartMenu

        [TestMethod]
        public void StartMenuTestInput()
        {

            StartMenu startmenu = new StartMenu();
            Game game = new Game(startmenu);
           
            game.Turn(ConsoleKey.LeftArrow);

            Assert.AreEqual(startmenu.key,ConsoleKey.LeftArrow);
             
        }

        //and so on .... simple check string to be equals ...
        #endregion

        #region GameProcess
        [TestMethod]
        public void GameProcessGenerationTest()
        {
            
            Game game = new Game(new StartMenu());
            Robots robot = new WorkingCreator().Create();
            GamePole pole = new GamePole(game, robot);
            GameProcess gameProcess = new GameProcess(robot, pole);
            
            Assert.AreEqual(gameProcess.pole, pole);
            Assert.AreEqual(gameProcess.robot, robot);
            Assert.AreNotEqual(gameProcess.controller, null);

        }

        /*[TestMethod]
        public void GameProcessStateTransitionTest()
        {
            
            Game game = new Game(new StartMenu());
            
            

            Robots robot = new WorkingCreator().Create();
            GamePole pole = new GamePole(game, robot);
            game.State = new GameProcess(robot, pole);

            IGameState state = game.State; //Assert.AreEqual(game.State, state);

            pole.battery = 0;

            game.Turn(ConsoleKey.W);

           // Assert.AreNotEqual(game.State, state);

        }*/

        #endregion

        #region EndGame
        
        [TestMethod]
        public void EndGameGenerationTest()
        {
            
            Game game = new Game(new StartMenu());
            Robots robot = new WorkingCreator().Create();
            GamePole pole = new GamePole(game, robot);

            EndGame endGame = new EndGame(pole);
            
            Assert.AreEqual(endGame.pole, pole);
        }

        #endregion
    }
}
