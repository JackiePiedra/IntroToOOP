using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        private string name; //private is an access modifier -- only the class has access to the cat string field
        private string furColor; //these are instance variables, so everytime we create an instance of a cat it will incl these fields
        private int furLength;
        private bool isFemale;
        private int age;
        private bool isHungry;   //not setting values to these variables here, they will be set in the property

        public string Name //create property to allow access to this NAME field
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
        }
        
        //allowed unlimited constructor as long as they have unique parameters

        public Cat() //default constructor -- all classes need this 
        {
            this.name = "Mittens";
        }

        public Cat(string name, string furColor, int furLength, int age, bool isFemale) //overriding constructor
        {
            this.name = name; //this.name -- setting the input to the instance variable 'name' set above
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isFemale = isFemale;
        }
    }
}
