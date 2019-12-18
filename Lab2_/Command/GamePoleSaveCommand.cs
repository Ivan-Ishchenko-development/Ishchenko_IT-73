using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Command
{
    public class GamePoleSaveCommand : ICommand
    {

        public GamePoleSaveCommand(GamePole b)
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
