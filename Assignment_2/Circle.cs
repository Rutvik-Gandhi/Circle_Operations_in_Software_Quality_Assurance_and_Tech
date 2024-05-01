using System;

namespace Assignment_2
{
    public class Circle
    {
        private int radius;

        public Circle()
        {
            radius = 1;
        }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int GetRadius()
        {
            return radius;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}