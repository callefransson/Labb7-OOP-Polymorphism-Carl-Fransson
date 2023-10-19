using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    public abstract class Geometri // Basklassen som vi gör abstrakt så vi kan sätta en abstrakt metod i klassen
    {
        public abstract double Area(); // abstract metod för att kunna skriva om de olika metoderna
    }
}
