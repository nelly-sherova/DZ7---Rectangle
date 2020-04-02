using System;

namespace Rectangle
{
    class Rectangle
    {
        private double side1 { get; set; }
        private double side2 { get; set; }
        private double area { get; set; }
        private double perimeter { get; set; }
        public Rectangle () {}
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator(double side1, double side2)
        {
            area = side1*side2;
            return area;
        }
        public double PerimeterCalculator(double side1, double side2)
        {
            perimeter = 2*(side1 + side2);
            return perimeter;
        }
        public double Area {get{return area;}}
        public double Perimeter{get{return perimeter;}}
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
