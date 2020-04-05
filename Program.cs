using System;

namespace ConsoleAPlication
{
    class Rectangle
    {   
        double side1,side2;
        public Rectangle(double side1, double side2)
        {
            this.side1=side1;
            this.side2=side2;
        }
        double AreaCalculator()
        {
            return side1*side2;
        }
        double PerimetrCalculator()
        {
            return 2*(side1+side2);
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimetr
        {
            get
            {
                return PerimetrCalculator();
            }
        }
        static void Main(string[] args)
        {
           
        }
    }
}
