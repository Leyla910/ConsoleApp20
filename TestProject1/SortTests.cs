using Sorts;
namespace SortsTest
{
    public class SortTests
    {
        [TestCase(new int[3] {13, 11, 24}, new int[] {24, 13, 11})]
        public void SortOrders(int[] orders, int[] expected)
        {
            int[] actual = Sort.SortOrders(new int[3] {13, 11, 24});

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}