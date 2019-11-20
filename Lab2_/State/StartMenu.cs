using System;
using System.Collections.Generic;
using System.Text;
using Lab2_.Robot;

namespace Lab2_.State
{
    class StartMenu : IGameState
    {
        public void NextStage(Game game)
        {
            game.State = new GameProcess(game.Robot, game.pole);
            game.pole.CreatePole();

        }
        public void Turn(Game game, ConsoleKey key )
        {
            Console.Clear();

            if (key == ConsoleKey.S)
            {
                
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
            else Console.WriteLine("Извините вы ввели что-то не правильно , повторите попытку.");
            
        }
    }
}
