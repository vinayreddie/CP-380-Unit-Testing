using IsItALeapYear;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static IsItALeapYear.Program;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Year_2001_Is_not_a_leap_year()

        {


            // Arrange

            var p = new IsItLeapYear();

            var expected = false;

            // Act

            var actual = p.IsItLeapYearCehck(2001);

            // Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Year_1996_Is_a_leap_year()

        {


            // Arrange

            var p = new IsItLeapYear();

            var expected = true;

            // Act

            var actual = p.IsItLeapYearCehck(1996);

            // Assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Year_1900_Is_not_a_leap_year()

        {


            // Arrange

            var p = new IsItLeapYear();

            var expected = false;

            // Act

            var actual = p.IsItLeapYearCehck(1900);

            // Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Year_2000_Is_a_leap_year()

        {


            // Arrange

            var p = new IsItLeapYear();

            var expected = true;

            // Act

            var actual = p.IsItLeapYearCehck(2000);

            // Assert

            Assert.AreEqual(expected, actual);

        }
    }
}
