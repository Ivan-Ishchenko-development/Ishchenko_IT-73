using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Command
{
    public class GamePoleMoveLeftCommand : ICommand
    {

        public GamePoleMoveLeftCommand(GamePole b)
        {
            GamePole = b;
        }

        public void execute()
        {
            this.GamePole.MoveLeft();
        }

        public void undo()
        {
            
        }
    }
}
