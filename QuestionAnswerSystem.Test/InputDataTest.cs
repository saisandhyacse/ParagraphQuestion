using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionAnswerSystem.Test
{
    class InputDataTest
    {
        [Test]
        public void TestEmptyFileContents()
        {
            var mockFileParser = new Mock<IInputReader>();
            mockFileParser
                .Setup(dp => dp.GetLines())
                .Returns(new string[] { });

            var para = new InputData(mockFileParser.Object);
            CollectionAssert.AreEqual(para.lines, new string[] { });
        }


        [Test]
        public void TestValidInput()
        {
            var mockFileParser = new Mock<IInputReader>();
            mockFileParser
                .Setup(dp => dp.GetLines())
                .Returns(new string[] { "Thisl.., SXDCSZC, is sample test.", "Question1?", "Question2?", "Q3?", "Q4?", "Q4?", " A1;A2;A3" });

            var para = new InputData(mockFileParser.Object);
            Assert.IsTrue(para.isValidInput);
            CollectionAssert.AreEqual(para.lines, new string[] { "Thisl.., SXDCSZC, is sample test.", "Question1?", "Question2?", "Q3?", "Q4?", "Q4?", " A1;A2;A3"});

        }

      
    }
}
