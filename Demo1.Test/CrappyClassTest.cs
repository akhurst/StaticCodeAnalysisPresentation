using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo1.Test
{
    [TestClass]
    public class CrappyClassTest
    {
        [TestMethod]
        public void TestMethodWithTerribleComplexityWithValidInput()
        {
            var crappyClass = new CrappyClass();

            var returnValue = crappyClass.MethodWithTerribleComplexity("H3llo WUrLD!");

            Assert.IsTrue(returnValue);
        }
    }
}
