using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract string Info();


        public Animal(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public override string ToString()
        {
            return $"Id: {Id}\tName: {Name}";
        }
    }
}
