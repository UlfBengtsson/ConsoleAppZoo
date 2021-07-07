using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    class Dog : Animal, IDangerus
    {
        public string Tail { get; set; }
        public string Pelt { get; set; }
        public int DangerLevel { get; set; }

        public Dog(int id, string name, string tail, string pelt) : base(id, name)
        {
            Tail = tail;
            Pelt = pelt;
            DangerLevel = 8;
        }

        public override string Info()
        {
            return $"--- Dog type ---\nId: {Id}\nName: {Name}\nPelt: {Pelt}\nTail: {Tail}\n";
        }

        public string DangerInfo()
        {
            return "Claw, Bite";
        }
    }
}
