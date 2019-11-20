using System;
using System.Collections.Generic;
using System.Text;
using Lab2_.Robot;

namespace Lab2_.State
{
    class EndGame : IGameState
    {
        
        GamePole pole;
        Robots robot;

        public EndGame(GamePole pole, Robots robot)
        {
            this.pole = pole;
            Console.Clear();
            Console.WriteLine("      Это конец игры , спасибо что доиграли до конца {0} )\n", robot.name_hero);
            pole.ShowState();
            System.Threading.Thread.Sleep(5000);

            Console.WriteLine("Хотите начать новую игру? \nЕсли да то нажмите \"s\" , если нет \"e\" ");

        }
        public void NextStage(Game game)
        {
            game.State = new StartMenu();
        }
        public void Turn(Game game, ConsoleKey key)
        {
            if (key == ConsoleKey.S)
            {
                game.NextStage();
                
            }
            else if(key == ConsoleKey.E){
                game.Status(false);
            }

            Console.Clear();
            Console.WriteLine("Хотите начать новую игру? \nЕсли да то нажмите \"s\" , если нет \"e\" ");
        }
       
    }
}
