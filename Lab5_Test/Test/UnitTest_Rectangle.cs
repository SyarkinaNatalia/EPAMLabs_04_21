using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test
{
    public class UnitTest_Rectangle
    {

        [Test]
        public void TestArea([Range(1, 20)] double side_a,
                             [Range(1, 20)] double side_b)
        {
            var result = GeometricFigures.Rectangle.GetArea(side_a, side_b);
            Assert.IsTrue(side_a * side_b == result, $"{result}");
        }



        [Test]
        public void TestLength([Range(1, 20)] double side_a,
                               [Range(1, 20)] double side_b)
        {
            var result = GeometricFigures.Rectangle.GetLength(side_a, side_b);
            Assert.IsTrue((side_a + side_b) * 2 == result, $"{result}");
        }
    }

}
