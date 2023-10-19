using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
        public class Fyrkant : Geometri // Ny klass som heter Fyrkant som ärver från basklassen Geometri
    {
        public int _sideLenght { get; set; } //egenskapen för klassen
        public Fyrkant() //Konstruktorn där vi sätter värdet på variabeln
        {
            _sideLenght = 4;
        }

        public override double Area() // Metoden som retunerar arean
        {
            return _sideLenght * _sideLenght;
        }
    }
}
