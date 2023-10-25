using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    public class Cirkel : Geometri 
    {
        public double Radius { get; set; } //egenskapen för klassen
        public Cirkel()
        { // sätter värdet på egenskapen i konstruktorn
            Radius = 5;
        }
        public override double Area() // Metoden som räknar ut och retunerar arean
        {
            return Radius * Radius * Math.PI;
        }

    }
}
