using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppZoo.Models
{
    class AnimalService : ICRUD<Animal, int>
    {
        static int IdCounter = 0;
        static List<Animal> animals = new List<Animal>();

        public Animal Create(Animal dataType)
        {
            dataType.Id = ++IdCounter;
            animals.Add(dataType);
            return dataType;
        }

        public List<Animal> FindAll()
        {
            return animals;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idType"></param>
        /// <returns>Retunds Animal with Id, null if not found.</returns>
        public Animal FindById(int idType)
        {
            //foreach (Animal animal in animals)
            //{
            //    if (animal.Id == idType)
            //    {
            //        return animal;
            //    }
            //}
            //return null;

            //Animal found = null;
            //foreach (Animal animal in animals)
            //{
            //    if (animal.Id == idType)
            //    {
            //        found = animal;
            //        break;
            //    }
            //}
            //return found;

            return animals.SingleOrDefault(animal => animal.Id == idType);
        }

        public Animal Update(Animal dataType)
        {
            throw new NotImplementedException();
        }
        public bool Delete(Animal dataType)
        {
            throw new NotImplementedException();
        }
    }
}
