using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Robot
{
    public class SmartCreator : RobotCreator
    {
        public override Robots Create(string name)
        {
            return new SmartRobot(name, "S");
        }
    }
}
