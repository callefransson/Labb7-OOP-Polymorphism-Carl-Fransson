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
        public double _lenght { get; set; }
        public double _height { get; set; }
        public Parallellogram()
        { // sätter värdet på egenskaperna i konstruktorn
            _lenght = 4.4;
            _height = 6.8;
        }
        public override double Area() // Metoden som retunerar arean
        {
            return _lenght * _height;
        }
    }
}
