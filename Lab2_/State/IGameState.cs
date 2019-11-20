using System;
using System.Collections.Generic;
using System.Text;
using Lab2_.Robot;

namespace Lab2_.State
{
    interface IGameState
    {

        void NextStage(Game game); 
        void Turn(Game game, ConsoleKey key);

       // string HelpMessage();
    }
}
