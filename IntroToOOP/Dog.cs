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

        public Dog()
        {

        }

        public Dog(int hairLength, int height, int runningSpeed, double weight)
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
