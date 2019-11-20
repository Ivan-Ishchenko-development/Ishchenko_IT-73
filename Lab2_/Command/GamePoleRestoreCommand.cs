using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Command
{
    class GamePoleRestoreCommand : ICommand
    {
        GamePole GamePole;
        public GamePoleRestoreCommand(GamePole b)
        {
            GamePole = b;
        }

        public void execute()
        {
            this.GamePole.Save();
        }

        public void undo()
        {

        }
    }
}
