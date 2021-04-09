using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01OOP_Ex2
{
    class Animal
    {
        string Type;
        string Name;

        public string Type1 { get => Type; set => Type = value; }
        public string Name1 { get => Name; set => Name = value; }

        public Animal(string type, string name)
        {
            Type = type;
            Name = name;
        }
        public Animal() { }
        public virtual void Sound()
        {
            
        }
        public virtual void Information()
        {
            
        }
    }
    class Dog : Animal
    {
        string Breed;

        public Dog()
        {
        }

        public Dog(string breed,string type, string name) : base(type, name)
        {
            Breed = breed;
        }

        public string Breed1 { get => Breed; set => Breed = value; }

        public override void Information()
        {
            Console.WriteLine($"Name: {this.Name1}, Type: {this.Type1}, Breed: {this.Breed1} ");
        }

        public override void Sound()
        {
            Console.WriteLine("gau gau");
        }
    }
    class Cat : Animal
    {
        string Climb;

        public Cat()
        {
        }

        public Cat(string climb,string type, string name) : base(type, name)
        {
            Climb = climb;
        }

        public string Climb1 { get => Climb; set => Climb = value; }

        public override void Information()
        {
            Console.WriteLine($"Name: {this.Name1}, Type: {this.Type1}, Climb: {this.Climb1} ");
        }

        public override void Sound()
        {
            Console.WriteLine("meo meo");
        }
    }
    class Duck : Animal
    {
        string Swim;

        public Duck()
        {
        }

        public Duck(string swim,string type, string name) : base(type, name)
        {
            Swim = swim;
        }

        public string Swim1 { get => Swim; set => Swim = value; }

        public override void Information()
        {
            Console.WriteLine($"Name: {this.Name1}, Type: {this.Type1}, Swim: {this.Swim1} ");
        }

        public override void Sound()
        {
            Console.WriteLine("quak quak");
        }
    }
    class Program
    {
        static void Main(string[] args)

        {
            Duck d1 = new Duck();
            d1.Name1 = "duk";
            d1.Type1 = "bird";
            d1.Swim1 = "pool";
            d1.Sound();
            d1.Information();
            Dog d2 = new Dog();
            d2.Name1 = "dog";
            d2.Type1 = "mammal";
            d2.Breed1 = "Husky";
            d2.Sound();
            d2.Information();
            Cat c = new Cat();
            c.Name1 = "cat";
            c.Type1 = "mammal";
            c.Climb1 = "tree";
            c.Sound();
            c.Information();
            Console.ReadLine();
        }
    }
}
