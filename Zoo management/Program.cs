using System;
using System.Collections.Generic;

namespace ZooManagement
{
       public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Legs { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            Legs = 4;
        }

        public abstract void MakeSound();

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Legs: {Legs}");
        }
    }

    public interface ISpecialAbility
    {
        void PerformAbility();
    }

    public class Lion : Animal
    {
        public Lion(string name, int age, int legs) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roarsss!");
        }
    }
    public class Eagle : Animal, ISpecialAbility
    {
        public Eagle(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} screeches!");
        }

        public void PerformAbility()
        {
            Console.WriteLine($"{Name} flies high in the sky!");
        }
    }

    public class Dolphin : Animal, ISpecialAbility
    {
        public Dolphin(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} clicks and whistles!");
        }

        public void PerformAbility()
        {
            Console.WriteLine($"{Name} swims gracefully!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>
            {
                new Lion("Leo", 5, 4),
                new Eagle("Eddy", 13),
                new Dolphin("Dolly", 23)
            };

            foreach (var animal in zoo)
            {
                animal.DisplayInfo();
                animal.MakeSound();

                if (animal is ISpecialAbility specialAbilityAnimal)
                {
                    specialAbilityAnimal.PerformAbility();
                }

                Console.WriteLine();
            }
        }
    }
}
