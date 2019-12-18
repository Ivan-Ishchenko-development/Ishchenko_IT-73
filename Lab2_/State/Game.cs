using System;
using System.Collections.Generic;
using System.Text;
using Lab2_.Robot;
using Lab2_.State;

namespace Lab2_.State
{
    public class Game
    {
        public Robots Robot { get; private set; }

        public IGameState State { get;  set; }

        public GameHistory GameHistory { get; private set; }

        public GamePole pole { get; private set; }

        public bool gamestatus { get; private set; } = true;

        public Game(IGameState gameState)
        {
            State = gameState;
        }

        public void Turn(ConsoleKey key)
        {
            State.Turn(this,key);
        }
       
        public void GenerateNewGame()
        {
            
            Random rnd = new Random();
            int random = rnd.Next(10);
            if (random < 5)
            {
                Robot = new WorkingCreator().Create();
            }
            else if (random > 7)
            {
                Robot = new SmartCreator().Create();
            }
            else
            {
                Robot = new CyborgCreator().Create();
            }
            Console.WriteLine("Вам выпал робот: " + Robot.fullHero);
            //GamePole = new GamePole();
            GameHistory = new GameHistory();
            pole = new GamePole(this, Robot );

        }
        public void NextStage()
        {
            State.NextStage(this);
        }

        public void ShowLegends()
        {

            Console.WriteLine(Robot.legend);
        }

        public void Status(bool end)
        {
            gamestatus = end;
            
        }
    }
}
