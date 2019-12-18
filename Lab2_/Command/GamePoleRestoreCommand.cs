using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Command
{
    public class GamePoleRestoreCommand : ICommand
    {

        public GamePoleRestoreCommand(GamePole b)
        {
            GamePole = b;
        }

        public void execute()
        {
            this.GamePole.Restore();
        }

        public void undo()
        {

        }
    }
}
