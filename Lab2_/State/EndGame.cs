using System;
using System.Collections.Generic;
using System.Text;
using Lab2_.Robot;

namespace Lab2_.State
{
    public class EndGame : IGameState
    {

        public GamePole pole { get; private set; } 
        public ConsoleKey key { get; private set; } 

        public EndGame(GamePole pole)
        {
            this.pole = pole;
            Console.WriteLine("      Это конец игры , спасибо что доиграли до конца  )\n");
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
            this.key = key;
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
