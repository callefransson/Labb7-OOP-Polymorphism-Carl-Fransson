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
        public int _yAxis { get; set; }
        public int _xAxis { get; set; }
        public Ellips()
        { // sätter värdet på egenskaperna i konstruktorn
            _yAxis = 8;
            _xAxis = 11;
        }
        public override double Area() // Metoden som retunerar arean
        {
            return Math.PI * _xAxis * _yAxis;
        }
    }
}
