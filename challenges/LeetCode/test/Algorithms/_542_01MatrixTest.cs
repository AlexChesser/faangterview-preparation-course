using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace test
{
    partial class DataStructuresTests : TestTemplate
    {

        [Test]
        [TestCase("foo", "bar")]
        public void _542_01Matrix(string arr, string expected)
        {
            var s = new _542_01Matrix.Solution();
            //int result = s.LengthOfLongestSubstring(arr);
            //Assert.AreEqual(expected, result);
            Assert.Pass();
        }
    }
}