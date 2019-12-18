using System;
using System.Collections.Generic;
using System.Text;
using Lab2_.State;

namespace Lab2_
{
    public class Memento
    {
        public string[,] Frame { get; private set; } = new string[20,30]; // Кадр
        public int Cargo { get; private set; }
        public int Money { get; private set; }
        public int Battery { get; private set; }
        public string Target { get; private set; }
        public int Countcargo { get; private set; }
        public Memento(string[,] frame, int cargo, int money, int battery, string target , int countcargo )
        {
            Array.Copy(frame, Frame, frame.Length);
            this.Cargo = cargo;
            this.Money = money;
            this.Battery = battery;
            this.Target = target;
            this.Countcargo = countcargo;
        }
    }

    public class GameHistory
    {
        public Stack<Memento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<Memento>();
        }
    }
}
