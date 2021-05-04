using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test
{
    class UnitTest_Triangle
    {
        [Test]
        public void TestArea(
            [Range(1, 20)] double side_a,
            [Range(1, 20)] double side_b,
            [Range(1, 20)] double side_c)
    {
        var result = GeometricFigures.Triangle.GetArea(side_a, side_b, side_c);
        var polp = (side_a + side_b + side_c) / 2;
        Assert.IsTrue(Math.Sqrt(polp*(polp-side_a)*(polp-side_b)*(polp-side_c))== result, $"{result}");
    }



    [Test]
    public void TestLength(
            [Range(1, 20)] double side_a,
            [Range(1, 20)] double side_b,
            [Range(1, 20)] double side_c)
        {
        var result = GeometricFigures.Triangle.GetLength(side_a, side_b, side_c);
        Assert.IsTrue(side_a + side_b + side_c == result, $"{result}");
    }
}
}
