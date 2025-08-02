using System;

namespace Operator_Overloading_Example
{
    class point
    {
        int x{get;}
        int y{get;}
        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static point operator +(point p1, point p2)
        {
            return new point(p1.x + p2.x, p1.y + p2.y);
        }
        public static point operator -(point p1, point p2)
        {
            return new point(p1.x - p2.x, p1.y - p2.y);
        }
        public static point operator *(point p1, point p2)
        {
            return new point(p1.x * p2.x, p1.y * p2.y);
        }
        public static point operator /(point p1, point p2)
        {
            if (p2.x == 0 || p2.y == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return new point(p1.x / p2.x, p1.y / p2.y);
        }
        public override string ToString()
        {
            return $"Point({x}, {y})";
        }
        public static bool operator ==(point p1, point p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }
        public static bool operator !=(point p1, point p2)
        {
            return !(p1 == p2);
        }
   
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            point p1 = new point(3, 4);
            point p2 = new point(1, 2);

            point sum = p1 + p2;
            point difference = p1 - p2;
            point product = p1 * p2;
            point quotient = p1 / p2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            Console.WriteLine($"Are points equal? {p1 == p2}");
            Console.WriteLine($"Are points not equal? {p1 != p2}");
            
        }
    }
}