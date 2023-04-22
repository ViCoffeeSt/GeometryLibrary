using System;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        private double[] _sides;

        private bool _isRight;

        public Triangle(double[] sides)
        {
            SetSide(sides);
        }

        public void SetSide(double[] sides)
        {
            _sides = sides;
            Array.Sort(_sides);
            _isRight = sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
        }

        public double[] GetSides()
        {
            return _sides;
        }

        public double CalculateArea()
        {
            double p = (_sides[0] + _sides[1] + _sides[2]) / 2;

            return Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));
        }

        public bool IsRight()
        {
            return _isRight;
        }
    }
}
