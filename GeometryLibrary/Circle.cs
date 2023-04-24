using System;

namespace GeometryLibrary
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            CheckError(radius);
            _radius = radius;
        }

        public void SetRadius(double radius)
        {
            CheckError(radius);
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
        
        public void CheckError(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero");
            }
        }
    }
}
