using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using MWDH;

namespace MWDH.Tests
{
    [TestFixture]
    public class RuleHandlePressingLTests
    {
        Page page;
        RuleHandlePressingL ruleUnderTest;


        [SetUp]
        public void SetUp()
        {
            page = new Page();
            ruleUnderTest = new RuleHandlePressingL();

        }


        [Test]
        public void CheckConditionIsTrueTest()
        {
            string inputText = "L";

            ruleUnderTest.CheckCondition(inputText, page);
            Assert.AreEqual(4, page.Lines.Count);
        }
        [Test]
        public void CheckConditionIsWrongLetterTest()
        {
            string inputText = "K";

            ruleUnderTest.CheckCondition(inputText, page);
            Assert.AreEqual(0, page.Lines.Count);
        }
        [Test]
        public void CheckConditionArrayToBigTest()
        {

            string toBigString = "L 21";

            ruleUnderTest.CheckCondition(toBigString, page);
            Assert.AreEqual(0, page.Lines.Count);
        }
    }
}