using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TestClass
{
    public class TriangleTest
    {
        [TestFixture]

        public class TriangleTest1
        {
            [Test]

            public void AnalyzeTriangle_Input6and6and6_EquilateralTriangle()
            {
                //Arrange
                int firstSide = 6;
                int secondSide = 6;
                int thirdSide = 6;

                string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);  
            }

            [Test]

            public void AnalyzeTriangle_Input6and9and6_IsoscelesTriangle()
            {
                //Arrange
                int firstSide = 6;
                int secondSide = 9;
                int thirdSide = 6;

                string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Input9and6and6_IsoscelesTriangle()
            {
                //Arrange
                int firstSide = 9;
                int secondSide = 6;
                int thirdSide = 6;

                string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Input6and6and9_IsoscelesTriangle()
            {
                //Arrange
                int firstSide = 6;
                int secondSide = 6;
                int thirdSide = 9;

                string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Input2and3and4_ScaleneTriangle()
            {
                //Arrange
                int firstSide = 2;
                int secondSide = 3;
                int thirdSide = 4;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Input14and13and9_ScaleneTriangle()
            {
                //Arrange
                int firstSide = 14;
                int secondSide = 13;
                int thirdSide = 9;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Input9and13and14_ScaleneTriangle()
            {
                //Arrange
                int firstSide = 9;
                int secondSide = 13;
                int thirdSide = 14;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Input15and34and32_ScaleneTriangle()
            {
                //Arrange
                int firstSide = 15;
                int secondSide = 34;
                int thirdSide = 32;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Input29and36and44_ScaleneTriangle()
            {
                //Arrange
                int firstSide = 29;
                int secondSide = 36;
                int thirdSide = 44;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Input0and3and4_InvalidTriangle()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 3;
                int thirdSide = 4;

                string expected = "At least one side of your triangle has a zero length and is thus invalid";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Input0and0and4_InvalidTriangle()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 4;

                string expected = "At least one side of your triangle has a zero length and is thus invalid";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }


            [Test]

            public void AnalyzeTriangle_Input0and0and0_InvalidTriangle()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 0;

                string expected = "At least one side of your triangle has a zero length and is thus invalid";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Inputnegative1and3andnegative4_InvalidTriangle()
            {
                //Arrange
                int firstSide = -1;
                int secondSide = 3;
                int thirdSide = -4;

                string expected = "Based on the values entered, the triangle is INVALID";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Inputnegative2andnegative5and7_InvalidTriangle()
            {
                //Arrange
                int firstSide = -2;
                int secondSide = -5;
                int thirdSide = 7;

                string expected = "Based on the values entered, the triangle is INVALID";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void AnalyzeTriangle_Input8andnegative9andnegative7_InvalidTriangle()
            {
                //Arrange
                int firstSide = 8;
                int secondSide = -9;
                int thirdSide = -7;

                string expected = "Based on the values entered, the triangle is INVALID";

                //Act
                Triangle obj = new Triangle();
                string actual = obj.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

    }
}
