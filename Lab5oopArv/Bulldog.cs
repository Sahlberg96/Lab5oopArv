using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5oopArv
{
    internal class Bulldog : Dog
    {
        public string DogBreed { get; set; }
        public Bulldog(string name, int age, string typeOfAnimal, string owner, string sound, string food, string toy, string dogBreed) : base(name, age, typeOfAnimal, owner, sound, food, toy)
        {
            DogBreed = dogBreed;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Hundras: " + DogBreed);
        }
    }
}
