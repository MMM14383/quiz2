using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalRose = int.Parse(Console.ReadLine());
            int TotalSunflower = int.Parse(Console.ReadLine());
            
            
        }


    }

    class flower
    {
        public int Id;
        public string Name;
        public string Description;
        public int Amount;
        public string Height;
        public string Circenference;

        public flower(int id, string name, string description, int amount, string height, string circenference)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circenference = circenference;
        }

    }

    class Rose:flower
    {
        public int TotalRose;
        public Rose(int id, string name, string description, int amount, string height, string circenference):base(id,name,description,amount,height,circenference)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circenference = circenference;
        }

        public void informationRose()
        {
            Id = int.Parse(Console.ReadLine());
            Name = Console.ReadLine();
            Description = Console.ReadLine();
            Amount = int.Parse(Console.ReadLine());
            Height = Console.ReadLine();
            Circenference = Console.ReadLine();
        }
    }

    class SunFlower:flower
    {
        public int TotalSumflower;
        public SunFlower(int id, string name, string description, int amount, string height, string circenference) : base(id, name, description, amount, height, circenference)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circenference = circenference;
        }

        public void informationRose()
        {
            Id = int.Parse(Console.ReadLine());
            Name = Console.ReadLine();
            Description = Console.ReadLine();
            Amount = int.Parse(Console.ReadLine());
            Height = Console.ReadLine();
            Circenference = Console.ReadLine();

        }
    }
}
