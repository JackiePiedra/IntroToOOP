using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //----------these are PRIVATE fields-----------
        private string name; //private is an access modifier -- only the class has access to the cat string field
        private string furColor; //these are instance variables, so everytime we create an instance of a cat it will incl these fields
        private int furLength;
        private bool isFemale;
        private int age;
        private bool isHungry;   //not setting values to these variables here, they will be set in the property
        private bool isSleepy;
        
        //----------these are PUBLIC properties, they allow access to the private fields-----------
        public string Name //create property to allow access to this NAME field
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //short hand way to create a property -- same as above
        public string FurColor { get; set; }
        public int FurLength { get; set; }

        public int Age
        {
            get { return this.age; }
        }
        
        //allowed unlimited constructor as long as they have unique parameters

        public Cat() //default constructor -- all classes need this 
        {
            this.name = "Mittens";
        }

        public Cat(string name, string furColor, int furLength, int age, bool isFemale, bool isHungry, bool isSleepy) //method overloading constructor
        {
            this.name = name; //this.name -- setting the input to the instance variable 'name' set above
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isFemale = isFemale;
            this.isHungry = isHungry;
            this.isSleepy = isSleepy;
        }

        //create a behavior
        public void Eat()
        {
            if(isHungry)
            {
                this.isHungry = false; //can change fields within the class
                Console.WriteLine("I'm stuffed");
            }
            else if(!isHungry)
            {
                Console.WriteLine("I'm good, no food for me");
            }
        }

        public void Run()
        {
            Console.WriteLine("I am running really fast!");
            this.isHungry = true;
        }

        //create 2 more behaviors and 2 more properties

        /*public string FurColor
        {
            get { return this.FurColor; }
        }

        public int FurLength
        {
            get { return this.FurLength; }
        }*/ //created the short hand properties above

        public void Sleep()
        {
            if(isSleepy)
            {
                isSleepy = false;
                Console.WriteLine("Yawn.. Nap time.. Zzzzz");
            }
            else if(!isSleepy)
            {
                Console.WriteLine("Leave me alone..");
            }
        }

        public void Play()
        {
            Console.WriteLine("I *heart* this ball of yarn..");
            isSleepy = true;
        }

        public void Talk()
        {
            Console.WriteLine("Hello, my name is {0} and yes, I can talk", this.name); //0 means whatever you have at the end
        }
    }
}
