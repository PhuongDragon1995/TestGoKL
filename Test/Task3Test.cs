using CodingTask3;
using NUnit.Framework;

namespace Test
{
    class Task3Test
    {
        [Test]
        public void CyclicSortTest()
        {
            var input = "ABCDEFGHIJ".ToCharArray();
            var order = 7;
            var output = Task3.CyclicSort(input, order);
            Assert.True(new string(output) == "GDBACFJEHI");
        }
    }
}
