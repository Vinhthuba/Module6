using System;

namespace Constructors
{
    public  class Rectangle
    {
        double _length;
        double _breadth;
        public Rectangle()
        {
            _breadth = 13.5;
            _breadth = 20.5;
        }
        public Rectangle(double len,double wide)
        {
            _length = len;
            _breadth = wide;
        }
        public double Area()
        {
            return _breadth * _length;
        }
        static void Main(string[] args)
        {
            Rectangle objRectl = new Rectangle();
            Console.WriteLine("Area of Rectangle = " + objRectl.Area());

            Rectangle objRectl2 = new Rectangle(2.5,6.9);
            Console.WriteLine("Ara of Rectangle = "+objRectl2.Area());

            Console.ReadKey();
        }
    }
}