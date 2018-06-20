using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CI_Test;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Calculator_Add_Success()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}
