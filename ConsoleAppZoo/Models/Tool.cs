using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    abstract class Tool
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string StoragePlace { get; set; }


        public abstract string HowToUse();
        public abstract string Mantenecs();
        public abstract string Info();

    }
}
