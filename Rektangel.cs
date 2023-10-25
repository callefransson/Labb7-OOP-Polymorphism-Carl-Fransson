using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    public class Rektangel : Geometri // Ny klass som heter Rektangel som ärver från basklassen Geometri
    {
        // De unika egenskaperna för klassen Rektangel
        public int _lenght { get; set; }
        public int _height { get; set; }

        public Rektangel() //Konstruktorn där vi sätter värderna på de propertys som används
        {
            _lenght = 4;
            _height = 8;
        }
        public override double Area() // Metoden som räknar ut och retunerar arean
        {
            return _lenght * _height;
        }

    }
}
