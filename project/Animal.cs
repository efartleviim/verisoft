using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{     
    internal abstract class Animal
    {
        private bool mammals;
        private bool carnivorous;
        public const int MODE_HAPPY = 1;
        public const int MODE_SCARE = 2;
        public int mood { get; set; }
        public Animal(bool m ,bool c, int mood)
        {
            mammals = m;
            carnivorous = c;
            this.mood = mood; 
        }
        public virtual void sayHello() { }
        public abstract void sayHello(int mood);
        public bool isMammals() { return mammals; }
        public bool isCarnivorous() { return carnivorous; }
        public void setMammals(bool  mammals) { this.mammals = mammals; } 
        public void setCarnivorous(bool carnivorous) { this.carnivorous = carnivorous; }    


    }
    interface ILand
    {
        int getNumberOfLegs();
    }
    interface IWater
    {
        bool hasGills();
        bool hasLaysEggs();
    }


    internal class Cat : Animal, ILand
    {
        private int numberOfLegs;
        public Cat(bool m, bool c, int mood,int num) : base(m, c, mood)
        {
            numberOfLegs = num;
        }

        

        public override void sayHello() { Console.WriteLine("meow"); } 
        public override  void  sayHello(int mood) {
            if (mood ==MODE_HAPPY )
                Console.WriteLine( "purr, purr");
            else if(mood ==MODE_SCARE )
                Console.WriteLine("hiss");
        }

        public int getNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
    internal class Dog:Animal, ILand
    {
        private int numberOfLegs;

        public Dog(bool m, bool c, int mood, int num) : base(m, c, mood)
        {
            numberOfLegs = num;

        }

        public int getNumberOfLegs()
        {
            return numberOfLegs;
        }

        public override void sayHello() { Console.WriteLine("wapping their tails"); }
        public override void sayHello(int mood) {
            if (mood == MODE_HAPPY)
                Console.WriteLine("wow wow");
            else if (mood == MODE_SCARE)
                Console.WriteLine("whooping");
        }



    }
    internal class Frog : Animal,ILand, IWater
    {
        private int numberOfLegs;
       


        public Frog(bool m, bool c, int mood, int num) : base(m, c, mood)
        {
            numberOfLegs = num;
           
        }

        public int getNumberOfLegs()
        {
            return numberOfLegs;
        }

        public bool hasGills()
        {
            return true;
        }

        public bool hasLaysEggs()
        {
            return true;
        }

        public override void sayHello(int mood) {
            if (mood == MODE_HAPPY)
                Console.WriteLine("quack quack quack");
            else if (mood == MODE_SCARE)
                Console.WriteLine("plop into the water");
        }



    }
}
