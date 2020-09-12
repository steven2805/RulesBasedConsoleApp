using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace MWDH.Tests
{
    [TestFixture]
    public class RuleHandlePressingInsertTests
    {
        Page page;
        RuleHandlePressingInsert ruleUnderTest;


        [SetUp]
        public void SetUp()
        {
            page = new Page();
            ruleUnderTest = new RuleHandlePressingInsert();

        }

        [Test]
        public void CheckConditionIsTrueTest()
        {
            string inputText = "I 2 This is a test message";

            ruleUnderTest.CheckCondition(inputText, page);
            // Should be 3 count as we have to insert to empty lines to stop out of range
            Assert.AreEqual(2, page.Lines.Count);
            Assert.AreEqual("This is a test message", page.Lines[1]);
        }
        [Test]
        public void CheckConditionIsWrongLetterTest()
        {
            string inputText = "K 2 This is a test message";

            ruleUnderTest.CheckCondition(inputText, page);
            Assert.AreEqual(0, page.Lines.Count);
        }
        [Test]
        public void CheckConditionInvalidINTTest()
        {
            string toBigString = "L l testing with l ";

            ruleUnderTest.CheckCondition(toBigString, page);
            Assert.AreEqual(0, page.Lines.Count);
        }

        [Test]
        public void CheckConditionInvalidINT2Test()
        {
            string toBigString = "L testing with l ";

            ruleUnderTest.CheckCondition(toBigString, page);
            Assert.AreEqual(0, page.Lines.Count);
        }

        [Test]
        public void CheckHighintSelection()
        {
            String highIntSelection = "I 100 Testing this very high int";
            ruleUnderTest.CheckCondition(highIntSelection, page);
            // Should be 100 count as we have to insert to empty lines to stop out of range
            Assert.AreEqual(100, page.Lines.Count);
            Assert.AreEqual("Testing this very high int", page.Lines[99]);

        }

    }
}