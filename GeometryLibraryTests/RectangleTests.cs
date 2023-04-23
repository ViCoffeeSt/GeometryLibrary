using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

namespace GeometryLibraryTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void RectangleAreaTest_5and10_50returned()
        {
            double widht = 5;
            double lenght = 10;
            double expected = 50;

            Rectangle rectangle = new Rectangle(lenght, widht);

            double actual = rectangle.CalculateArea();

            Assert.AreEqual(expected, actual);
        }
    }
}
