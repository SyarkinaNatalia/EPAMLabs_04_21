using NUnit.Framework;

namespace Test
{
    public class UnitTest_Square
    {

        [Test]
        public void TestArea([Range(1, 20)] double side_a)
        {
            var result = GeometricFigures.Square.GetArea(side_a);
            Assert.IsTrue(side_a * side_a == result,$"{result}");
        }

        

        [Test]
        public void TestLength([Range(1,20)] double side_a)
        {
            var result = GeometricFigures.Square.GetLength(side_a);
            Assert.IsTrue(side_a * 4 == result, $"{result}");
        }
    }

}