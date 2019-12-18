using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Target
{
    public abstract class Targets
    {
        public string Name { get; protected set; }
        public int Cargo { get; protected set; }
        Random C_rand = new Random(); // Рандомный груз
        public Targets(string name)
        {
            this.Name = name;
            Cargo = C_rand.Next(1, 200);
        }

    }

}
