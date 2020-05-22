using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Moq;
using System.IO;
//using NUnit;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuestionAnswerSystem.Test
{
    class InputReaderTest
    {
        [Test]
        public void TestInvalidFile()
        {
            var InputReader = new InputReader("Input888");
            Assert.Throws<FileNotFoundException>(() => InputReader.GetLines());
        }


        [Test]
        public void TestEmptyFile()
        {
            var para = new InputReader("Input7");
            CollectionAssert.AreEqual(para.GetLines(), new string[] { });
        }

        [Test]
        public void ValidateFile()
        {
            string[] lval = { "Zebra is an Animal.", "Chennai is my city.", "Who are you?", "How are things?" };
            var para = new InputReader();
            var inputLoader = new InputReader("InputTest");
            CollectionAssert.AreEqual(inputLoader.GetLines(), lval);
        }

        //[Test]
        //public void ValidateParagraph()
        //{
        //    ParagraphReader para = new ParagraphReader("InputTest");
        //    string[] lval = { "Zebra is an Animal.", "Chennai is my city.", "Who are you?", "How are things?" };
        //    CollectionAssert.AreEqual(para.GetLines(), lval);

        //    para.GetRequiredEntities();
        //    Assert.AreEqual(para.isValidInput, false);

        //    ParagraphReader para1 = new ParagraphReader("Input5");
        //    para1.GetLines();
        //   // Assert.AreEqual(para1.lines.Count(), 7);
        //    String s = "Zebras are several species of African equids (horse family) united by their distinctive black and white stripes. Their stripes come in different patterns, unique to each individual. They are generally         social animals that live in small harems to large herds. Unlike their closest relatives, horses and donkeys, zebras have never been truly domesticated. There are three species of zebras: the plains zebra,the Grévy's zebra and the mountain zebra. The plains zebra and the mountain zebra belong to the subgenus Hippotigris, but Grévy's zebrais the sole species of subgenus Dolichohippus. The latter resembles an ass, to which it is closely related, while the former two are more horse-like. All three belong to the genus Equus, along with other living equids. The unique stripes of zebras make them one of the animals most familiar to people. They occur in a variety of habitats,such as grasslands, savannas, woodlands, thorny scrublands, mountains, and coastal hills. However, various anthropogenic factors have had a severe impact on zebra populations, in particular hunting for skins and habitat destruction. Grévy's zebra and the mountain zebra are endangered. While plains zebras are much more plentiful,  one subspecies - the Quagga - became extinct in the late 19th century. Though there is currently a plan, called the Quagga Project,           that aims to breed zebras that are phenotypically similar to the Quagga, in a process called breeding back.";
        //    para1.GetRequiredEntities();
        //    Assert.AreEqual(para1.isValidInput, true);
        //    Assert.AreEqual(para1.paragraph, s);
        //}

        //[Test]
        //public void ValidateQuestion()
        //{
        //    ParagraphReader para = new ParagraphReader("Input1");
        //    para.GetLines();
        //    para.GetRequiredEntities();
        //    Assert.AreEqual(para.isValidInput, false);
        //    ParagraphReader para2 = new ParagraphReader("Input2");
        //    para2.GetLines();
        //    para2.GetRequiredEntities();
        //    Assert.AreEqual(para2.isValidInput, true);
        //    Assert.AreEqual(para2.questions.Count, 5);
        //    Assert.AreEqual(para2.questions[1], "What is the aim of the Quagga Project?");
        //}

        //[Test]
        //public void ValidateAnswer()
        //{
        //    ParagraphReader para2 = new ParagraphReader("Input5");
        //    para2.GetLines();
        //    para2.GetRequiredEntities();
        //    Assert.AreEqual(para2.isValidInput, true);
        //    Assert.AreEqual(para2.answer, "No valid answer;No valid answer;No valid answer;No valid answer;No valid answer;");
        //}

        //[Test]
        //public void ValidateFile1()
        //{
        //    string[] lval = { };
        //    var inputLoader = new ParagraphReader("InputTest1");
        //    inputLoader.GetLines();
        //   // CollectionAssert.AreEqual(inputLoader.GetLines(), lval);
        //    inputLoader.GetRequiredEntities();
        //    Assert.AreEqual(inputLoader.isValidInput, true);
        //}

        // Test Empty File content
        //[Test]
        //public void TestEmptyFileContents()
        //{
        //    var mockFileParser = new Mock<IInputReader>();
        //    mockFileParser
        //        .Setup(dp => dp.GetLines())
        //        .Returns(new string[] { });

        //    var para = new ParagraphReader(mockFileParser.Object);
        //    CollectionAssert.AreEqual(para.lines, new string[] { });
        //}

        //[Test]
        //public void TestEmptyParagraph()
        //{
        //    var mockFileParser = new Mock<IInputReader>();
        //    mockFileParser
        //        .Setup(dp => dp.GetLines())
        //        .Returns(new string[] {});

        //    var para = new ParagraphReader(mockFileParser.Object);
        //    para.GetRequiredEntities();
        //    CollectionAssert.AreEqual(para.paragraph, string.Empty);
        //}
        
        //[Test]
        //public void TestValidParagraph()
        //{
        //    var mockFileParser = new Mock<IInputReader>();
        //    mockFileParser
        //        .Setup(dp => dp.GetLines())
        //        .Returns(new string[] { "Thisl.., SXDCSZC, is sample test.","Question1?","Question2?" ,"Q3?","Q4?", "Q4?"," A1;A2;A3" });

        //    var para = new ParagraphReader(mockFileParser.Object);
        //    para.GetRequiredEntities();
        //    CollectionAssert.AreEqual(para.paragraph, "Thisl.., SXDCSZC, is sample test.");
        //}
    }
}
