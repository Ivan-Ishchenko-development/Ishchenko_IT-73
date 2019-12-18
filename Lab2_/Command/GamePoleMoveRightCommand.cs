using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Command
{
    public class GamePoleMoveRightCommand : ICommand
    {

        public GamePoleMoveRightCommand(GamePole b)
        {
            GamePole = b;
        }

        public void execute()
        {
            this.GamePole.MoveRight();
        }

        public void undo()
        {
            
        }
    }
}
