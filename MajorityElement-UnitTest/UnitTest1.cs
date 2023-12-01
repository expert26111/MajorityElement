using Moq;
using MajorityElement;

namespace MajorityElement_UnitTest
{
    public class Tests
    {
        private Solution sol;
        [SetUp]
        public void Setup()
        {
            sol = new Solution();
           // int solution = sol.MajorityElement(nums);
        }

        [Test]
        public void Test1()
        {
            int[] nums = { 1, 2, 1 };
            int solution = Solution.MajorityElement(nums);
            Assert.That(solution,Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            int[] nums = { 1};
            int solution = Solution.MajorityElement(nums);
            Assert.That(solution, Is.EqualTo(1));
        }
        [Test]
        public void Test3()
        {
            int[] nums = { 3,2,3 };
            int solution = Solution.MajorityElement(nums);
            Assert.That(solution, Is.EqualTo(3));
        }
    }
}