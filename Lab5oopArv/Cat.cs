using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab5oopArv
{
    internal class Cat : Animal
    {
        public string Food { get; set; }
        public string Bed { get; set; }
        public Cat(string name, int age, string typeOfAnimal, string owner, string sound, string food, string bed) : base(name, age, typeOfAnimal, owner, sound)
        {
            Food = food;
            Bed = bed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} jamar efter maten!");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} gillar att äta {Food} till middag");
        }
        public virtual void FavoriteBed()
        {
            Console.WriteLine($"{Name}s favorit plats att sova på är {Bed}");
        }
    }
}
