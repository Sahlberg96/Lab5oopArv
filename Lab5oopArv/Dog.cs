using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5oopArv
{
    internal class Dog : Animal
    {
        public string Food { get; set; }
        public string Toy { get; set; }

        public Dog(string name, int age, string typeOfAnimal, string owner, string sound, string food, string toy) : base(name, age, typeOfAnimal, owner, sound)
        {
            Food = food;
            Toy = toy;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} {Sound} högt!");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} gillar att äta {Food} till middag");
        }
        public virtual void FavoriteToy()
        {
            Console.WriteLine($"Gillar att leka med en {Toy}"); 
        }

    }
}
