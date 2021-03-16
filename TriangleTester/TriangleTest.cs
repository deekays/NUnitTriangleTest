using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SDraperMidterm;


namespace TriangleTester
{
    public class TriangleTest
    {
        [TestFixture]
        public class TriangleTests
        {
            [Test]
            public void ValidTriangle_Input3and3and3_Output_Equilateral()
            {
                // Arrange
                int firstLength = 3;
                int secondLength = 3;
                int thirdLength = 3;

                string expected = "equilateral";

                // Act
                string actual = TriangleSolver.Analyze(firstLength, secondLength, thirdLength);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ValidTriangle_Input4and4and5_Output_Isosceles()
            {
                // Arrange
                int firstLength = 4;
                int secondLength = 4;
                int thirdLength = 5;

                string expected = "isosceles";

                // Act
                string actual = TriangleSolver.Analyze(firstLength, secondLength, thirdLength);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ValidTriangle_Input5and6and7_Output_Scalene()
            {
                // Arrange
                int firstLength = 5;
                int secondLength = 6;
                int thirdLength = 7;

                string expected = "scalene";

                // Act
                string actual = TriangleSolver.Analyze(firstLength, secondLength, thirdLength);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void InvalidTriangle_Input1and1and11_Output_Invalid()
            {
                // Arrange
                int firstLength = 1;
                int secondLength = 1;
                int thirdLength = 11;

                string expected = "invalid";

                // Act
                string actual = TriangleSolver.Analyze(firstLength, secondLength, thirdLength);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ValidTriangle_Input99and99and99_Output_Equilateral()
            {
                // Arrange
                int firstLength = 99;
                int secondLength = 99;
                int thirdLength = 99;

                string expected = "equilateral";

                // Act
                string actual = TriangleSolver.Analyze(firstLength, secondLength, thirdLength);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ValidTriangle_Input142and100and142_Output_Isosceles()
            {
                // Arrange
                int firstLength = 142;
                int secondLength = 100;
                int thirdLength = 142;

                string expected = "isosceles";

                // Act
                string actual = TriangleSolver.Analyze(firstLength, secondLength, thirdLength);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ValidTriangle_Input88and77and66_Output_Scalene()
            {
                // Arrange
                int firstLength = 88;
                int secondLength = 77;
                int thirdLength = 66;

                string expected = "scalene";

                // Act
                string actual = TriangleSolver.Analyze(firstLength, secondLength, thirdLength);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void InvalidTriangle_Input4and1and2_Output_Invalid()
            {
                // Arrange
                int firstLength = 4;
                int secondLength = 1;
                int thirdLength = 2;

                string expected = "invalid";

                // Act
                string actual = TriangleSolver.Analyze(firstLength, secondLength, thirdLength);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void InvalidTriangle_Input16and32and16_Output_Invalid()
            {
                // Arrange
                int firstLength = 16;
                int secondLength = 32;
                int thirdLength = 16;

                string expected = "invalid";

                // Act
                string actual = TriangleSolver.Analyze(firstLength, secondLength, thirdLength);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void InvalidTriangle_Input2000and1000and1000_Output_Invalid()
            {
                // Arrange
                int firstLength = 2000;
                int secondLength = 1000;
                int thirdLength = 1000;

                string expected = "invalid";

                // Act
                string actual = TriangleSolver.Analyze(firstLength, secondLength, thirdLength);

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
