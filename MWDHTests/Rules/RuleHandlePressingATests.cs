using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace MWDH.Tests
{
    [TestFixture]
    public class RuleHandlePressingATests
    {
        Page page;
        RuleHandlePressingA ruleUnderTest;

        [SetUp]
        public void SetUp()
        {
            page = new Page();
            ruleUnderTest = new RuleHandlePressingA();

        }


        [Test]
        public void CheckConditionIsTrueTest()
        {
            string inputText = "a";

            ruleUnderTest.CheckCondition(inputText, page);
            Assert.AreEqual(1, page.Lines.Count);
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
            string toBigArray = "A 21";

            ruleUnderTest.CheckCondition(toBigArray, page);
            Assert.AreEqual(0, page.Lines.Count);
        }
    }
}