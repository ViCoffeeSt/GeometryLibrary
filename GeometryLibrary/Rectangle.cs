namespace GeometryLibrary
{
    public class Rectangle : IShape
    {
        private double _lenght;
        private double _width;

        public Rectangle(double lenght, double width)
        {
            _lenght = lenght;
            _width = width;
        }

        public double CalculateArea()
        {
            return _lenght * _width;
        }
    }
}
