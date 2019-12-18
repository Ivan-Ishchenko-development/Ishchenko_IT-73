using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Target
{
    public class TPoison : Targets
    {
        public TPoison()
            : base("P")
        { }

        public TDecodingCreator TDecodingCreator
        {
            get => default;
            set
            {
            }
        }
    }
}
