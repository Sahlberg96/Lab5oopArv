using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5oopArv
{
    internal class Animal
    {
        string Name { get; set; }
        int Age { get; set; }
        int Weight { get; set; }
        string Owner { get; set; }
        string Sound { get; set; }


        public Animal(string name, int age, int weight, string owner, string sound)
        {

        }
        public virtual void PrintInfo()
        {

        }
        public virtual void MakeSound()
        {

        }
        public static void IsHealthy(int overWeight)
        {
            
        }

    }
}
