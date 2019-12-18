using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab2_.Target;
using Lab2_.Robot;
using Lab2_.Command;
using Lab2_.State;

namespace Lab2_
{
    public class GamePole
    {
        public Robots robot;
        public Game game;
        private string emptyCell = " ";
        private string target = "N";
        //private List<string[]> frame  = new List<string[]>(); // Кадр
        public int battery { get; set; } = 0;
        private string[,] frame;
        private int money = 0;
        private int chanceDecodingRand = 0;
        private int randomcargo = 0;
        private int randX = 0;
        private int randY = 0;
        private int cargo = 70;
        private int countcargo = 0;
        private int overheatRand = 0; // Для шанса посадить батарею после перегруза
        private int overheat = 0; // Для перегрева за привышении грузоподъемности за один раз


        readonly Random rand = new Random();

        public GamePole(Game game, Robots robot)
        {
            this.game = game;
            this.robot = robot;
            this.battery = robot.battery;
             

        }
        public void CreatePole()
        {
            frame = new string[,]
            {
                { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "N", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", robot.hero, " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#"}

            };
            Render();
           /* Console.WriteLine("Ряд = " + frame.GetLength(0) + "Столбцы = " + frame.GetLength(1));
            System.Threading.Thread.Sleep(1000);*/
        }
        public void Render()
        {
            Console.Clear();
            
            for (int i = 0; i < frame.GetLength(0); i++)
            {
                for (int j = 0; j < frame.GetLength(1); j++)
                {
                    Console.Write(frame[i,j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }

        public void MoveUp()
        {
            for (int x = frame.GetLength(0) - 1; x >= 0; x--)
            {
                for (int y = 0; y < frame.GetLength(1); y++)
                {
                    if (frame[x,y] == robot.hero)
                    {
                        if (frame[x - 1,y] == emptyCell)
                        {
                            frame[x,y] = emptyCell;
                            frame[x - 1,y] = robot.hero;
                            battery -= 1;
                            Render();
                            return;
                        }
                        else if (frame[x - 1,y] == target)
                        {
                            LiftCargo();
                            frame[x,y] = emptyCell;
                            frame[x - 1,y] = robot.hero;
                            battery -= 20;
                            OverHeat();
                            NewTarget();
                            Render();
                            return;
                        }

                    }
                }
            }

        }
        public void MoveDown()
        {
            for (int x = frame.GetLength(0) - 1; x >= 0; x--)
            {
                for (int y = 0; y < frame.GetLength(1); y++)
                {
                    if (frame[x,y] == robot.hero)
                    {
                        if (frame[x + 1,y] == emptyCell)
                        {
                            frame[x,y] = emptyCell;
                            frame[x + 1,y] = robot.hero;
                            battery -= 1;
                            Render();
                            return;
                        }
                        else if (frame[x + 1,y] == target)
                        {
                            LiftCargo();
                            frame[x,y] = emptyCell;
                            frame[x + 1,y] = robot.hero;
                            battery -= 20;
                            OverHeat();
                            NewTarget();
                            Render();
                            return;
                        }

                    }
                }
            }
            Render();
        }
        public void MoveLeft()
        {
            for (int x = frame.GetLength(0) - 1; x >= 0; x--)
            {
                for (int y = 0; y < frame.GetLength(1); y++)
                {
                    if (frame[x,y] == robot.hero)
                    {
                        if (frame[x,y - 1] == emptyCell)
                        {
                            frame[x,y] = emptyCell;
                            frame[x,y - 1] = robot.hero;
                            battery -= 1;
                            Render();
                            return;
                        }
                        else if (frame[x,y - 1] == target)
                        {
                            LiftCargo();
                            frame[x,y] = emptyCell;
                            frame[x,y - 1] = robot.hero;
                            battery -= 20;
                            OverHeat();
                            NewTarget();
                            Render();
                            return;
                        }

                    }
                }
            }
            Render();
        }
        public void MoveRight()
        {
            for (int x = frame.GetLength(0) - 1; x >= 0; x--)
            {
                for (int y = 0; y < frame.GetLength(1); y++)
                {
                    if (frame[x,y] == robot.hero)
                    {
                        if (frame[x,y + 1] == emptyCell)
                        {
                            frame[x,y] = emptyCell;
                            frame[x,y + 1] = robot.hero;
                            battery -= 1;
                            Render();
                            return;
                        }
                        else if (frame[x,y + 1] == target)
                        {
                            
                            LiftCargo();
                            frame[x,y] = emptyCell;
                            frame[x,y + 1] = robot.hero;
                            battery -= 20;
                            OverHeat();
                            NewTarget();
                            Render();
                            return;
                        }
                    }
                }
            }
            Render();
        }

        public void Save()
        {

            game.GameHistory.History.Push(SaveGame());
            
        }
        public void Restore()
        {
            if(game.GameHistory.History.Count > 0)
            RestoreGame(game.GameHistory.History.Pop());
            
        }


        public void NewTarget()
        {
            
            randomcargo = rand.Next(0, 101); // Нужно для рандома (100%)
            randX = rand.Next(2, frame.GetLength(0) - 1); // Вставляем в рандомную ячейку  и убераем два первых , последний рядка. (Чтобы не вышло за границу) 
            randY = rand.Next(2, frame.GetLength(1) - 1);
            {

                if (randomcargo <= 60)
                {
                    Targets box = new TNormalCreator().Create();
                    target = box.Name;
                    cargo = box.Cargo;
                    
                }
                else if (randomcargo <= 70)
                {
                    Targets box = new TPoisonCreator().Create();
                    target = box.Name;
                    cargo = box.Cargo;
                }
                else
                {
                    Targets box = new TDecodingCreator().Create();
                    target = box.Name;
                    cargo = box.Cargo;
                }

                if (frame[randX,randY] == robot.hero)
                    frame[randX + 1,randY + 1] = target;
                else frame[randX,randY] = target;
            }
        }
        public void LiftCargo()
        {
            Console.WriteLine(" Ожидайте идет поднятие груза ");
            System.Threading.Thread.Sleep(2000);
            if (robot.carrying > cargo)
            {
                countcargo += 1;
                if (target == "N")
                {
                    Console.WriteLine("Груз поднят  ");
                    System.Threading.Thread.Sleep(2000);
                    money += 10;
                }
                else if (target == "P" && robot.hero != "C")
                {
                    Console.WriteLine("Едкий груз поднят");
                    System.Threading.Thread.Sleep(3000);
                    money += 10;

                }
                else if (target == "P")
                {
                    Console.WriteLine("Едкий груз поднят");
                    System.Threading.Thread.Sleep(3000);
                    money += 60;
                    battery -= 60;
                    Console.WriteLine("Вы обпекли тело , на регенерацию живих тканей уйдет больше энергии");
                    System.Threading.Thread.Sleep(4000);
                }
                else if (target == "D")
                {
                    Console.WriteLine("Подождите 4 секунды идет декодеровка груза");
                    System.Threading.Thread.Sleep(3000);
                    chanceDecodingRand = rand.Next(0, 101);
                    if (robot.chanceDecoding < chanceDecodingRand)
                        Console.WriteLine("Декодеровка не удалась");
                    else
                    {
                        Console.WriteLine("Декодеровка удалась");
                        if (robot.chanceDecoding <= 10) money += 100;
                        else if (robot.chanceDecoding <= 20) money += 90;
                        else if (robot.chanceDecoding <= 30) money += 80;
                        else if (robot.chanceDecoding <= 40) money += 70;
                        else if (robot.chanceDecoding <= 50) money += 60;
                        else if (robot.chanceDecoding <= 60) money += 50;
                        else if (robot.chanceDecoding <= 70) money += 40;
                        else if (robot.chanceDecoding <= 80) money += 30;
                        else if (robot.chanceDecoding <= 90) money += 20;
                        else if (robot.chanceDecoding <= 100) money += 10;
                    }
                    System.Threading.Thread.Sleep(1000);

                }
                
            }
            else
            {
                Console.WriteLine("Извините но у вас не достаточно грузоподъемности. Груз {0} > Грузоподъемность {1}", cargo, robot.carrying);
                System.Threading.Thread.Sleep(2000);
            }
        }
        public void OverHeat()
        {
            
            if (cargo < (robot.overload * robot.carrying) / 100 && robot.overload != 0)
            {

                overheat += 1;
                if (overheat == 3)
                {
                    Console.WriteLine("У вас произошел перегрев");
                    System.Threading.Thread.Sleep(1500);
                    overheatRand = rand.Next(0, 100);
                    if (robot.overloadBattery < overheatRand )
                    {
                        battery -= 50;
                        Console.WriteLine("Вы посадили батарею из-за длительного перегруза ");
                    }
                    overheat = 0;
                }
            }
            else
            {

            }
                overheat = 0;
        }

        public Memento SaveGame()
        {
            return new Memento(frame, cargo, money, battery, target, countcargo);
        }

        public void RestoreGame(Memento memento)
        {
            
            Array.Copy(memento.Frame, this.frame, frame.Length);
            this.cargo = memento.Cargo;
            this.money = memento.Money;
            this.battery = memento.Battery;
            this.target = memento.Target;
            this.countcargo = memento.Countcargo;

            Render();
        }
        public void ShowState()
        {
            Console.WriteLine("Деньги = {0} Батарея = {1}  Последний собраный груз = {2}  Количество поднятого груза {3}", money, battery , target, countcargo);
        }
        public bool Victory()
        {
            return true;
        }

        public GamePoleController GamePoleController
        {
            get => default;
            set
            {
            }
        }

        public GameHistory GameHistory
        {
            get => default;
            set
            {
            }
        }
    }
}
