using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    public class Ellips : Geometri
    {
        //egenskaperna för klassen
        public int YAxis { get; set; }
        public int XAxis { get; set; }
        public Ellips()
        { // sätter värdet på egenskaperna i konstruktorn
            YAxis = 8;
            XAxis = 11;
        }
        public override double Area() // Metoden som räknar ut och retunerar arean
        {
            return Math.PI * XAxis * YAxis;
        }
    }
}
