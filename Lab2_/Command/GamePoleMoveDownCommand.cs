using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Command
{
    public class GamePoleMoveDownCommand : ICommand
    {

        public GamePoleMoveDownCommand(GamePole b)
        {
            GamePole = b;
        }

        public void execute()
        {
            this.GamePole.MoveDown();
        }

        public void undo()
        {
            this.GamePole.MoveUp();
        }
    }
}
