using NUnit.Framework;
using System;
namespace Test
{
    public class Test
    {
        [Test]
        public void TestCase()
        {
			int Value = 60;
			Assert.IsTrue(Value > 50);
        }
    }
}
