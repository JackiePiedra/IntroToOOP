using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        private int hairLength;
        private int height;
        private int runningSpeed;
        private double weight;

        
        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public Dog() //default constructor
        {
            this.weight = 90d;
            this.height = 24;
            this.runningSpeed = 15;
            this.hairLength = 1;
        }

        public Dog(int hairLength, int height, int runningSpeed, double weight) //method overloading -- polymorphism
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public void Run()
        {
            Console.WriteLine("I'm running at {0} miles per hour", this.runningSpeed);
        }

        public void Bark()
        {
            Console.WriteLine("WOOF WOOF");
        }

        public void Potty()
        {
            Console.WriteLine("Please let me out");
        }

        public void Cuddle()
        {
            Console.WriteLine("Let's snuggle..");
        }
    }
}
