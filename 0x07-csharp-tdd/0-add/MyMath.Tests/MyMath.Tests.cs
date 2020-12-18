using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int a = 1;
            int b = 1;
            int c = Operations.Add(a, b);
            Assert.AreEqual(a + b, c);
        }
    }
}