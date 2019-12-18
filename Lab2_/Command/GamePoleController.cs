using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Command
{
    public class GamePoleController
    {
        ICommand moveUp;
        ICommand moveLeft;
        ICommand moveRight;
        ICommand moveDown;
        ICommand save;
        ICommand restore;

        public GamePoleController(ICommand moveUp, ICommand moveDown, ICommand moveRight, ICommand moveLeft, ICommand save, ICommand restore)
        {
            this.moveUp = moveUp;
            this.moveDown = moveDown;
            this.moveRight = moveRight;
            this.moveLeft = moveLeft;
            this.save = save;
            this.restore = restore;
        }

        public void MoveUp()
        {
            this.moveUp.execute();
        }

        public void MoveDown()
        {
            this.moveDown.execute();
        }

        public void MoveLeft()
        {
            this.moveLeft.execute();
        }

        public void MoveRight()
        {
            this.moveRight.execute();
        }

        public void Save()
        {
            this.save.execute();
        }

        public void Restore()
        {
            this.restore.execute();
        }
    }
}
