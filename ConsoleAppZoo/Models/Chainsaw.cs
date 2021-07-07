using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    class Chainsaw : Tool, IDangerus
    {
        public Chainsaw(int id, string name, int amount, string storageLoacation)
        {
            Id = id;
            Name = name;
            Amount = amount;
            StoragePlace = storageLoacation;
            DangerLevel = 7;
        }

        public int DangerLevel { get; set; }

        public string DangerInfo()
        {
            return "Cutting/burns if on";
        }

        public override string HowToUse()
        {
            return $"Check fual, prime, pull to start";
        }

        public override string Info()
        {
            return $"Chainsaw - Id: {Id} - Name: {Name}\n";
        }

        public override string Mantenecs()
        {
            return "Check oil, ......";
        }
    }
}
