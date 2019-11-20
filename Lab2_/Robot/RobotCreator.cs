using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Robot
{
    public abstract class RobotCreator
    {
        abstract public Robots Create(string name);
    }
}
