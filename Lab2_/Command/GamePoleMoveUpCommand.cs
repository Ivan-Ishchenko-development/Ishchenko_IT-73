using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Command
{
    public class GamePoleMoveUpCommand : ICommand
    {

        public GamePoleMoveUpCommand(GamePole b)
        {
            GamePole = b;
        }

        public void execute()
        {
            this.GamePole.MoveUp();
        }

        public void undo()
        {
            
        }
    }
}
