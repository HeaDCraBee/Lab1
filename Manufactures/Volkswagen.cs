using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Manufactures
{
    internal class Volkswagen : Manufactor
    {
        public Volkswagen()
        {
            ModelsList = new()
            {
                { "Polo", 30000 },
                { "Golf", 40000 },
                { "Passat", 50000 },
                { "Tiguan", 60000 },
                { "Tuareg", 70000 }
            };

            LeatherPrice = 500;
            AlcantaraPrice = 1000;
            TyresPrice = 250;
            ImprovedSoundSystemPrice = 150;
            PaintProtectionPrice = 500;
        }
    }
}
