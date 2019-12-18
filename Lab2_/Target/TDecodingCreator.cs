using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Target
{
    public class TDecodingCreator : TargetsCreator
    {
        public override Targets Create()
        {
            return new TDecoding();
        }
        
    }
}
