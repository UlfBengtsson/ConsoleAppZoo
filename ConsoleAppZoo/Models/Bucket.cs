using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    class Bucket : Tool
    {
        public int VolumeInDeciliter { get; set; }

        public Bucket(int id, string name, int amount, string storageLoacation, int volumeInDeciliter)
        {
            Id = id;
            Name = name;
            Amount = amount;
            StoragePlace = storageLoacation;
            VolumeInDeciliter = volumeInDeciliter;
        }

        public override string HowToUse()
        {
            throw new NotImplementedException();
        }

        public override string Info()
        {
            return $"Chainsaw - Id: {Id} - Name: {Name}\n";
        }

        public override string Mantenecs()
        {
            return "check for cracks";
        }
    }
}
