using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionAnswerSystem.Test
{
    class ParagraphTest
    {
        public void TestValidInput()
        {
            var mockFileParser = new Mock<IInputReader>();
            mockFileParser
                .Setup(dp => dp.GetLines())
                .Returns(new string[] { "Thisl.., SXDCSZC, is sample test.", "Question1?", "Question2?", "Q3?", "Q4?", "Q4?", " A1;A2;A3" });

            var line = new InputData(mockFileParser.Object);
            Assert.IsTrue(line.isValidInput);
            CollectionAssert.AreEqual(line.lines, "Thisl.., SXDCSZC, is sample test.", "Question1?", "Question2?", "Q3?", "Q4?", "Q4?", " A1;A2;A3");

            var Para = new Paragraph(line);
            Para.GetEntity();
            CollectionAssert.AreEqual(Para.paragraph, "Thisl.., SXDCSZC, is sample test.");

        }
    }
}
