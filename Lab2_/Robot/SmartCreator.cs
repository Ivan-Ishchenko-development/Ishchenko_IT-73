using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Robot
{
    public class SmartCreator : RobotCreator
    {
        public override Robots Create()
        {
            return new SmartRobot( "S");
        }
    }
}
