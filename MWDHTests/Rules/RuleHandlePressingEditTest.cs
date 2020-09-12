using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace MWDH.Tests
{
    [TestFixture]
    public class RuleHandlePressingEditTest
    {
        Page page;
        
        RuleHandlePressingEdit ruleUnderTest;

        [SetUp]
        public void SetUp()
        {
            page = new Page();
            ruleUnderTest = new RuleHandlePressingEdit();
        }
        

        [Test]
        public void CheckConditionIsTrueTest()
        {
            string lineZero = "This line needs changing";
            page.addLine(lineZero, 0);
            string changeLineTo = "This is the changed version of the line";
            
            string editLineinput = "E 1 "+ changeLineTo;

            ruleUnderTest.CheckCondition(editLineinput, page);
            Assert.AreEqual(changeLineTo, page.Lines[0]);
        }
        [Test]
        public void CheckConditionIsWrongLetterTest()
        {
            string lineZero = "This line needs changing";
            page.addLine(lineZero, 0);
            string changeLineTo = "This is the changed version of the line";

            string editLineinput = "q 1 " + changeLineTo;

            ruleUnderTest.CheckCondition(editLineinput, page);
            Assert.AreEqual(lineZero, page.Lines[0]);
        }
        [Test]
        public void CheckConditionOutOfBounds()
        {
            string lineZero = "This line needs changing";
            page.addLine(lineZero, 0);
            string changeLineTo = "This is the changed version of the line";

            string editLineinput = "q 100 " + changeLineTo;

            ruleUnderTest.CheckCondition(editLineinput, page);
            Assert.AreEqual(lineZero, page.Lines[0]); ;
        }
    }
}