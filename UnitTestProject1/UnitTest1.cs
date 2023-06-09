using Library_main;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void CircleAreaTest()
        {
            Circle circle = new Circle(5);
            double expectedArea = Math.PI * Math.Pow(5, 2);
            Assert.AreEqual(expectedArea, circle.CalculateArea(), 2);
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, triangle.CalculateArea(), 2);
        }

        [TestMethod]
        public void TriangleIsRightTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

    }
}
