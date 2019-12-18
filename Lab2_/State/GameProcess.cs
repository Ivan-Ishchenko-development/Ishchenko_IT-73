using System;
using System.Collections.Generic;
using System.Text;
using Lab2_.Robot;
using Lab2_.Command;

namespace Lab2_.State
{
    public class GameProcess : IGameState
    {
        public GamePole pole { get; private set; }
        public Robots robot { get; private set; }
        public GamePoleController controller { get;  private set; }


        public GameProcess(Robots robot, GamePole pole) 
        {
            this.robot = robot;
            this.pole = pole;
            controller = new GamePoleController(new GamePoleMoveUpCommand(pole), new GamePoleMoveDownCommand(pole), new GamePoleMoveRightCommand(pole), new GamePoleMoveLeftCommand(pole),new GamePoleSaveCommand(pole), new GamePoleRestoreCommand(pole));

        }
        public void NextStage(Game game)
        {
            Console.Clear();
            game.State = new EndGame(pole);
            
        }
        public void Turn(Game game, ConsoleKey key)
        {
            
            switch (key)
            {
                case ConsoleKey.LeftArrow: // left
                    controller.MoveLeft();
                    break;
                case ConsoleKey.DownArrow: // down
                    controller.MoveDown();
                    break;
                case ConsoleKey.RightArrow: // right
                    controller.MoveRight();
                    break;
                case ConsoleKey.UpArrow: // up
                    controller.MoveUp();
                    break;
                case ConsoleKey.R: // Restore
                    controller.Restore();
                    break;
                case ConsoleKey.S: // Save
                    controller.Save();
                    break;
                default:
                    break;

            }
            pole.ShowState();

            if(pole.battery <= 0)
            {
                game.NextStage();
                
            }
        }
        
        
    }
}
