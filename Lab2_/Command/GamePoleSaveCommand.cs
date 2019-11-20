using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Command
{
    class GamePoleSaveCommand : ICommand
    {
        GamePole GamePole;
        public GamePoleSaveCommand(GamePole b)
        {
            GamePole = b;
        }

        public void execute()
        {
           
        }

        public void undo()
        {
            this.GamePole.Restore();
        }
    }
}
