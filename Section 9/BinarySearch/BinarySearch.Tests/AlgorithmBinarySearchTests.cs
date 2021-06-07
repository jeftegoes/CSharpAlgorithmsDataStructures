using NUnit.Framework;

namespace BinarySearch.Tests
{
    [TestFixture]
    public class AlgorithmBinarySearchTests
    {
        [Test]
        public void BinarySearch_SortedInput_ReturnsCorrectIndex()
        {
            var input = new int[] { 0, 3, 4, 7, 8, 12, 15, 22 };
            Assert.AreEqual(2, AlgorithmBinarySearch.BinarySearch(input, 4));
            Assert.AreEqual(4, AlgorithmBinarySearch.BinarySearch(input, 8));
            Assert.AreEqual(6, AlgorithmBinarySearch.BinarySearch(input, 15));
            Assert.AreEqual(7, AlgorithmBinarySearch.BinarySearch(input, 22));

            Assert.AreEqual(2, AlgorithmBinarySearch.RecursiveBinarySearch(input, 4));
            Assert.AreEqual(4, AlgorithmBinarySearch.RecursiveBinarySearch(input, 8));
            Assert.AreEqual(6, AlgorithmBinarySearch.RecursiveBinarySearch(input, 15));
            Assert.AreEqual(7, AlgorithmBinarySearch.RecursiveBinarySearch(input, 22));
        }
    }
}