using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Robot
{
    public class CyborgCreator : RobotCreator
    {
        public override Robots Create(string name)
        {
            return new CyborgRopot(name, "C");
        }
        
    }
}
