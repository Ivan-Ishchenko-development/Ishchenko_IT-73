using System;
using System.Collections.Generic;
using System.Text;
using Lab2_.Robot;

namespace Lab2_.State
{
    public class StartMenu : IGameState

    {
        public ConsoleKey key { get; private set; }

        public void NextStage(Game game)
        {
            game.State = new GameProcess(game.Robot, game.pole);
            game.pole.CreatePole();

        }
        public void Turn(Game game, ConsoleKey key )
        {
            //Почему при Console.Clear() не работает тест?
            this.key = key;
            
            if (key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("   ____                ____                                       ");
                Console.WriteLine("  |                   |                \\      /\\      /         ");
                Console.WriteLine("  |     --Cyber       |____ --Smart     \\    /  \\    / --Working");
                Console.WriteLine("  |                        |             \\  /    \\  /           ");
                Console.WriteLine("  |____                ____|              \\/      \\/            ");

                

                game.GenerateNewGame(); 
                game.ShowLegends();

                Console.WriteLine("Чтобы продолжить нажмите любую клавишу");
                Console.ReadKey();
                
                
                game.NextStage();
            }
            else Console.WriteLine("\n\nИзвините вы ввели что-то не правильно , повторите попытку.");
            
        }
    }
}
