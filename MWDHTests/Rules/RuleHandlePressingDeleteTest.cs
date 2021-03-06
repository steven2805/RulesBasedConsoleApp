﻿using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace MWDH.Tests
{
    [TestFixture]
    public class RuleHandlePressingDeleteTests
    {
        Page page;
        
        RuleHandlePressingDelete ruleUnderTest;

        [SetUp]
        public void SetUp()
        {
            page = new Page();
            ruleUnderTest = new RuleHandlePressingDelete();
        }


        [Test]
        public void CheckConditionIsTrueTest()
        {
            string inputText = "This is the line to be deleted";
            page.addLine(inputText, 0);
            string deleteInputText = "D 1";

            ruleUnderTest.CheckCondition(deleteInputText, page);
            Assert.AreEqual(0, page.Lines.Count);
        }
        [Test]
        public void CheckConditionIsWrongLetterTest()
        {
            string inputText = "This is the line to be deleted";
            page.addLine(inputText, 0);
            string deleteInputText = "Z 0";

            ruleUnderTest.CheckCondition(deleteInputText, page);
            Assert.AreEqual(1, page.Lines.Count);
        }
        [Test]
        public void CheckConditionOutOfBounds()
        {
            string inputText = "This is the line to be deleted";
            page.addLine(inputText, 0);
            string outOfBounds = "d 500";

            ruleUnderTest.CheckCondition(outOfBounds, page);
            Assert.AreEqual(1, page.Lines.Count);
        }
        [Test]
        public void CheckConditionOutOfBoundsLower()
        {
            page.addLine("This is the line to be not be deleted");
            page.addLine("This is the line to be not be deleted");
            page.addLine("This is the line to be not be deleted");
            page.addLine("This is the line to be not be deleted");

            string outOfBounds = "d 0";
            ruleUnderTest.CheckCondition(outOfBounds, page);

            Assert.AreEqual(4, page.Lines.Count);

        }

        [Test]
        public void CheckDeletingSameLineTwice()
        {
            page.addLine("This is the line to be deleted");
            page.addLine("This is the line to be deleted");
            page.addLine("This is the line to be not be deleted");
            page.addLine("This is the line to be not be deleted");

            string outOfBounds = "d 1";
            ruleUnderTest.CheckCondition(outOfBounds, page);         
            ruleUnderTest.CheckCondition(outOfBounds, page);

            Assert.AreEqual(2, page.Lines.Count);

        }
    }
}