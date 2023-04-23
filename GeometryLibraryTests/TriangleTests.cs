using GeometryLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryLibraryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void SetSide_SortsSidesArray()
        {
            double[] sides = { 3, 5, 4 };
            Triangle triangle = new Triangle(sides);

            double[] expected = { 3, 4, 5 };
            double[] actual = triangle.GetSides();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateArea_345array_6return()
        {
            double[] sides = { 3, 4, 5 };
            Triangle triangle = new Triangle(sides);

            double expected = 6;
            double actual = triangle.CalculateArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRight_ReturnsTrueForRightTriangle()
        {
            double[] sides = { 3, 4, 5 };
            Triangle triangle = new Triangle(sides);

            bool expected = true;
            bool actual = triangle.IsRight();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRight_ReturnsFalseForNonRightTriangle()
        {
            double[] sides = { 2, 3, 4 };
            Triangle triangle = new Triangle(sides);

            bool expected = false;
            bool actual = triangle.IsRight();

            Assert.AreEqual(expected, actual);
        }
    }
}
