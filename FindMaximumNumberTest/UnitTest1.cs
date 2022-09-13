using FindMaximumNumber;
using NUnit.Framework;

namespace FindMaximumNumberTest
{
    public class Tests
    {
        //UC1
        //TC1 for Int
        [Test]
        public void GivenMaxFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            int num = max.FindMaxIntNumber(3, 1, 2);
            Assert.AreEqual(num,3);
        }
        [Test]
        public void GivenMaxSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            int num = max.FindMaxIntNumber(1, 3, 2);
            Assert.AreEqual(num,3);
        }
        [Test]
        public void GivenMaxThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            int num = max.FindMaxIntNumber(1, 2, 3);
            Assert.AreEqual(num,3);
        }
        //TC2 for float
        [Test]
        public void GivenMaxFloatFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            float num = max.FindMaxFloatNumber(3.5f, 1.2f, 0.1f);
            Assert.AreEqual(num,3.5f);
        }
        [Test]
        public void GivenMaxFloatSecondtNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            float num = max.FindMaxFloatNumber(0.1f, 3.5f, 1.2f);
            Assert.AreEqual(num,3.5f);
        }
        [Test]
        public void GivenMaxFloatThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximum max = new FindMaximum();
            float num = max.FindMaxFloatNumber(0.1f, 1.2f, 3.5f);
            Assert.AreEqual(num,3.5f);
        }
    }
}