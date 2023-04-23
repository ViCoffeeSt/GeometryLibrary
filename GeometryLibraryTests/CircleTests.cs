using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

namespace GeometryLibraryTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleAreaTest_4_double50returned()
        {
            double radius = 4;
            double delta = 0.1;
            double expectedArea = 50.2654824574367;

            Circle circle = new Circle(radius);

            double actualArea = circle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea,delta);
        }
    }
}
