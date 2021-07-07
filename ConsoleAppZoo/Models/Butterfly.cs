using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    internal class Butterfly : Animal
    {
        public Butterfly(
            int id, 
            string name, 
            string colorPalet, 
            string colorPatern, 
            int lifeTimeInDays) 
            : base(id,name)
        {
            ColorPalet = colorPalet;
            ColorPatern = colorPatern;
            LifeTimeInDays = lifeTimeInDays;
        }

        public string ColorPalet { get; set; }
        public string ColorPatern { get; set; }
        public int LifeTimeInDays { get; set; }

        public override string Info()
        {
            return $"--- Butterfly type ---\nId: {Id}\nName: {Name}\nColor Palet: {ColorPalet}\nColorPatern: {ColorPatern}\nLives for {LifeTimeInDays} days\n";
        }
    }
}
