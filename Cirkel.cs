using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    public class Cirkel : Geometri 
    {
        public double _radius { get; set; } //egenskapen för klassen
        public Cirkel()
        { // sätter värdet på egenskapen i konstruktorn
            _radius = 5;
        }
        public override double Area() // Metoden som retunerar arean
        {
            return _radius * _radius * Math.PI;
        }

    }
}
