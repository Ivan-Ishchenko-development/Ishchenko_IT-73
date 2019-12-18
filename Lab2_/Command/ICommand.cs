using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lab2_.Command
{
    public interface ICommand
    {
        void execute();
        void undo();
    }
}
