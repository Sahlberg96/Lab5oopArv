using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5oopArv
{
    internal class Bear : Animal
    {
        public Bear(string name, int age, string typeOfAnimal, string owner, string sound) : base(name, age, typeOfAnimal, owner, sound)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} ryter så det ekar!");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} gillar att äta  till middag");
        }
    }
}
