using System;

namespace GeometryLibrary
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public void SetRadius(double radius)
        {
            _radius = radius;
        }

        public double GetRadius()
        {
            return _radius;
        }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
