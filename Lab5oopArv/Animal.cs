using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5oopArv
{
    internal abstract class Animal
    {
        public string Name { get; set; } = "Vänta och se";
        public int Age { get; set; } = 1;
        public string TypeOfAnimal { get; set; } = "Okänd sort";
        public string Owner { get; set; } = "En snäll människa";
        public string Sound { get; set; } = "Låter";


        public Animal(string name, int age, string typeOfAnimal, string owner, string sound)
        {
            Name = name;
            Age = age;
            TypeOfAnimal = typeOfAnimal;
            Owner = owner;
            Sound = sound;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}");
            Console.WriteLine($"Ålder: {Age}");
            Console.WriteLine($"Djurras: {TypeOfAnimal}");
            Console.WriteLine($"Ägare: {Owner}");
            
        }

        public abstract void MakeSound();

        public abstract void Eat();
        




    }
}
