using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LogAnalyzer;

namespace LogAnalyzer.UnitTests
{
    [TestFixture]
    public class MyLogAnalyzerTests
    {
        [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            MyLogAnalyzer analyzer = new MyLogAnalyzer();

            bool result = analyzer.IsValidLogFileName("FileWithBadExtension.log");

            Assert.False(result);
        }

        [Test]
        public void IsValidLogFileName_GoodExtensionLowerCase_ReturnsTrue()
        {
            MyLogAnalyzer analyzer = new MyLogAnalyzer();

            bool result = analyzer.IsValidLogFileName("FileWithGoodExtension.slf");

            Assert.True(result);
        }

        [Test]
        public void IsValidLogFileName_GoodExtensionUpperCase_ReturnsTrue()
        {
            MyLogAnalyzer analyzer = new MyLogAnalyzer();

            bool result = analyzer.IsValidLogFileName("FileWithGoodExtension.SLF");

            Assert.True(result);
        }

        // Refactored positive tests, less clarity between positive test cases.
        [TestCase("FileWithGoodExtension.slf")]
        [TestCase("FileWithGoodExtension.SLF")]
        public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string fileName)
        {
            MyLogAnalyzer analyzer = new MyLogAnalyzer();

            bool result = analyzer.IsValidLogFileName(fileName);

            Assert.True(result);
        }
        
        // Refactored positive and negative test cases.  Test names become too generic.  Lose readability, but increase in maintanability.
        [TestCase("FileWithGoodExtension.slf", true)]
        [TestCase("FileWithGoodExtension.SLF", true)]
        [TestCase("FileWithBadExtension.log", false)]
        public void IsValidLogFileName_VariousExtensions_ChecksThem(string fileName, bool expectedResult)
        {
            MyLogAnalyzer analyzer = new MyLogAnalyzer();

            bool result = analyzer.IsValidLogFileName(fileName);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
