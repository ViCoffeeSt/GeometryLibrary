using System;

namespace GeometryLibrary
{
    public class Rectangle : IShape
    {
        private double _lenght;
        private double _width;

        public Rectangle(double lenght, double width)
        {
            CheckError(lenght, width);
            _lenght = lenght;
            _width = width;
        }

        public double CalculateArea()
        {
            return _lenght * _width;
        }
        
        public void CheckError(double lenght, double width)
        {
            if (lenght <= 0 || width <= 0)
            {
                throw new ArgumentException("Length and width must be greater than zero");
            }
        }
    }
}
