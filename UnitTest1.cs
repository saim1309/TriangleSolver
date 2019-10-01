using NUnit.Framework;
using TriangleIdentification;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_Equilateral()
        {
            //Arrange
            string expectedOutput = "Equilateral Triangle";
            //Act
            string actual = TriangleSover.Analyze(2, 2, 2);
            //Assert
            Assert.AreEqual(expectedOutput, actual);
        }

        [Test]
        public void Test_Isosceles()
        {
            //Arrange
            string expectedOutput = "Isosceles Triangle";
            //Act
            string actual = TriangleSover.Analyze(4, 2, 4);
            //Assert
            Assert.AreEqual(expectedOutput, actual);
        }

        [Test]
        public void Test_Scalene()
        {
            //Arrange
            string expectedOutput = "Scalene Triangle";
            //Act
            string actual = TriangleSover.Analyze(4, 3, 2);
            //Assert
            Assert.AreEqual(expectedOutput, actual);
        }

        [Test]
        public void Test_NoTriangleFormation()
        {
            //Arrange
            string expectedOutput = "Sorry...traigle cannot be formed!!!";
            //Act
            string actual = TriangleSover.Analyze(2, 1, 6);
            //Assert
            Assert.AreEqual(expectedOutput, actual);
        }

        [Test]
        public void Test_NegativeSide()
        {
            //Arrange
            string expectedOutput = "Side cannot be negative";
            //Act
            string actual = TriangleSover.Analyze(2, 2, -2);
            //Assert
            Assert.AreEqual(expectedOutput, actual);
        }

        [Test]
        public void Test_SideEqualZero()
        {
            //Arrange
            string expectedOutput = "Side cannot be zero";
            //Act
            string actual = TriangleSover.Analyze(2, 0, 2);
            //Assert
            Assert.AreEqual(expectedOutput, actual);
        }



        [Test]
        public void Test_AllSideEqualZero()
        {
            //Arrange
            string expectedOutput = "Side cannot be zero";
            //Act
            string actual = TriangleSover.Analyze(0, 0, 0);
            //Assert
            Assert.AreEqual(expectedOutput, actual);
        }


        [Test]
        public void Test_AllSideNegative()
        {
            //Arrange
            string expectedOutput = "Side cannot be negative";
            //Act
            string actual = TriangleSover.Analyze(-5, -8, -5);
            //Assert
            Assert.AreEqual(expectedOutput, actual);
        }
    }
}















