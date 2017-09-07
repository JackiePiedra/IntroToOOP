using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat("Nico", "black", 3, 1, true, false, false);

            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat2.Name);
            cat1.Name = "Gato"; //changing the value, only because that field is public, we can edit them
            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat2.Age);
            Console.WriteLine(cat1.Age);
            cat2.Eat();
            cat2.Run();
            cat2.Eat();

            cat2.Sleep();
            cat2.Play();
            cat2.Sleep();
            cat1.Talk();
            cat2.Talk();
            cat1.FurColor = "red"; //this is the SET portion of the property
            Console.WriteLine(cat1.FurColor); //this is the GET portion of the property

        }
    }
}
