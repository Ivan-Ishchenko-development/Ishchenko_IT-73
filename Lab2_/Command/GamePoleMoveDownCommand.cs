using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Command
{
    class GamePoleMoveDownCommand : ICommand
    {
        GamePole GamePole;
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
