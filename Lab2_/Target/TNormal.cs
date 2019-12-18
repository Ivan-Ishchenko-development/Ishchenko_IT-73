using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Target
{
    public class TNormal : Targets
    {
        public TNormal()
            : base("N")
        { }

        public TPoisonCreator TPoisonCreator
        {
            get => default;
            set
            {
            }
        }
    }
}
