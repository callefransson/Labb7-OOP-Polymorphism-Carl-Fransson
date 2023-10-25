using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    public class Parallellogram : Geometri
    {
        // egenskaperna för klassen
        public double Lenght { get; set; }
        public double Height { get; set; }
        public Parallellogram()
        { // sätter värdet på egenskaperna i konstruktorn
            Lenght = 4.4;
            Height = 6.8;
        }
        public override double Area() // Metoden som räknar ut och retunerar arean
        {
            return Lenght * Height;
        }
    }
}
