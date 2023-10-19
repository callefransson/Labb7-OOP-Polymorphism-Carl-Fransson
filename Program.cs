//Carl Fransson .Net23
namespace Labb7_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        { // Skapar nya instanser från klasserna och lagrar dem i de olika variabelnamnen och tar värdet som sätts i konstruktorn för de olika klasserna
            Rektangel rectangle = new Rektangel();
            Fyrkant square = new Fyrkant();
            Cirkel circle = new Cirkel();
            Parallellogram parallellogram = new Parallellogram();
            Ellips ellips = new Ellips();
            //Skriver ut arean från de olika metoderna 
            Console.WriteLine("Aran på rektangeln är: {0}", rectangle.Area());
            Console.WriteLine("Aran på fyrkant är: {0}", square.Area());
            Console.WriteLine("Aran på cirkel är: {0}", circle.Area());
            Console.WriteLine("Aran på parallellogram är: {0}", parallellogram.Area());
            Console.WriteLine("Aran på ellips är: {0}", ellips.Area());
            Console.ReadKey();
        }
    }
}
