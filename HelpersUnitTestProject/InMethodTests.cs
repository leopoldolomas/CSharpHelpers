using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leos.Helpers;
using System;
using System.Diagnostics;

namespace HelpersUnitTestProject
{
    [TestClass]
    public class InMethodTests
    {
        [TestMethod]
        public void TestEmptySet()
        {
            int num = 4;

            try
            {
                num.In(); // must throw an Exception
            }
            catch (Exception)
            {
                // correct. No elements were provided in the set
            }
        }

        [TestMethod]
        public void TestElementNotInSet()
        {
            int num = 4;
            Debug.Assert(!num.In(1, 2, 3));
        }

        [TestMethod]
        public void TestElementInSet()
        {
            int num = 4;
            Debug.Assert(num.In(1, 2, 3, 4));
        }

        [TestMethod]
        public void TestNonPrimitiveInSet()
        {
            String s = "two";
            Debug.Assert(s.In("one", "two", "three"));
        }
    }
}
