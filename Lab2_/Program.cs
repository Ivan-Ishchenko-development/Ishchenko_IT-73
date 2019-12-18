using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab2_.Command;
using Lab2_.Robot;
using Lab2_.Target;
using Lab2_.State;

namespace Lab2_
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Game game = new Game(new StartMenu());

            ConsoleSetup();

            Console.WriteLine("Если хотите начать игру нажмите s-старт");

            while (game.gamestatus)
            {
                
                var keyInfo = Console.ReadKey();
                var key = keyInfo.Key;
                game.Turn(key);
                

            } 
            
            Console.ReadKey();
        }
        

        static public void ConsoleSetup()
        {
            Console.Title = "Game   ROBOT";
            Console.WindowWidth = 150;
            Console.WindowHeight = 40;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
    
}
