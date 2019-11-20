using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Target
{
    class TNormalCreator : TargetsCreator
    {
        public override Targets Create()
        {
            return new TNormal();
        }
    }
}
