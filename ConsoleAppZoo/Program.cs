using System;
using System.Collections.Generic;
using ConsoleAppZoo.Models;

namespace ConsoleAppZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Zoo!");
            //DogButNotAnimal();
            DangerusForPeople();
        }

        static void DogButNotAnimal()
        {
            //Animal animal = new Animal();//cant instanciat a abstract class
            Dog dog = new Dog(1, "Wolf", "Long coated", "Long coat");
            Animal animalDog = new Dog(2, "Bulldog", "Stump", "Short coat");
            Butterfly butterfly = new Butterfly(6, "Fantasy", "All colors", "Rainbow", 1);

            Animal[] animals = new Animal[] { animalDog, dog, butterfly };

            Console.WriteLine("ToString list");
            foreach (Animal race in animals)
            {
                Console.WriteLine(race);//will use ToString method on object sent into it
            }

            Console.WriteLine("\nInfo list");
            foreach (Animal race in animals)
            {
                Console.WriteLine(race.Info());
            }
        }

        static void DangerusForPeople()
        {
            Dog dog = new Dog(2, "Bulldog", "Stump", "Short coat");
            Chainsaw chainsaw = new Chainsaw(1, "Huskvarna", 12, "Huvudlager");

            List<IDangerus> danger = new List<IDangerus>() { chainsaw, dog };

            foreach (IDangerus dangerToUs in danger)
            {
                Console.WriteLine(dangerToUs.DangerLevel + " - " + dangerToUs.DangerInfo());
            }
        }
    }
}
