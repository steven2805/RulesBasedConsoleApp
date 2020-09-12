using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace MWDH.Tests
{
    [TestFixture]
    public class RuleHandlePressingSwapTests
    {
        Page page;
        
        RuleHandlePressingSwap ruleUnderTest;

        [SetUp]
        public void SetUp()
        {
            page = new Page();
            ruleUnderTest = new RuleHandlePressingSwap();
        }


        [Test]
        public void CheckConditionIsTrueTest()
        {
            string lineZero = "This line was originally line 0";
            page.addLine(lineZero, 0);
            string lineOne = "This line was originally line 1";
            page.addLine(lineOne, 1);

            string swapConditionString = "R 1 2";

            ruleUnderTest.CheckCondition(swapConditionString, page);
            Assert.AreEqual("This line was originally line 1", page.Lines[0]);
        }
        [Test]
        public void CheckConditionIsWrongLetterTest()
        {
            string lineZero = "This line was originally line 0";
            page.addLine(lineZero, 0);
            string lineOne = "This line was originally line 1";
            page.addLine(lineOne, 1);

            string swapConditionString = "Z 1 2";

            ruleUnderTest.CheckCondition(swapConditionString, page);
            Assert.AreEqual("This line was originally line 0", page.Lines[0]);
            Assert.AreEqual("This line was originally line 1", page.Lines[1]);
        }
        [Test]
        public void CheckConditionOutOfBounds()
        {
            string lineZero = "This line was originally line 0";
            page.addLine(lineZero, 0);
            string lineOne = "This line was originally line 1";
            page.addLine(lineOne, 1);

            string outOfBounds = "R 1 200";

            ruleUnderTest.CheckCondition(outOfBounds, page);
            Assert.AreEqual(2, page.Lines.Count);
        }
    }
}