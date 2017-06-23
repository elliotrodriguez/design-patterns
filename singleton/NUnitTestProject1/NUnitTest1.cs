using System;
using NUnit.Framework;
using singleton;

namespace NUnitTestProject1
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void IsPolicyASingleton()
        {
            Assert.AreSame(InsurancePolicy.Instance, InsurancePolicy.Instance);
        }
    }
}