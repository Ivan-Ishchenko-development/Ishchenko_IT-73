using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Lab2_.State;

namespace Lab2_.Robot
{
    public abstract class Robots
    {

        
        public string legend       { get; protected set; } = " ";
        public string hero         { get; protected set; } = " ";
        public int battery         { get; protected set; } = 0;
        public int carrying        { get; protected set; } = 0; // Грузоподъемность
        public int chanceDecoding  { get; protected set; } = 0;
        public int overload        { get; protected set; } = 0; // Оптимальная грузоподъемность до этого значения в процентах  
        public int overloadBattery { get; protected set; } = 0; // Шанс повреждения батареи при перегрузке

        public string fullHero { get; protected set; }


        public Robots(string hero)
        {

            this.hero = hero;
           
        }
       
    }
}
