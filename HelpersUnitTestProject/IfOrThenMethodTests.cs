using Leos.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace HelpersUnitTestProject
{
    [TestClass]
    public class IfOrThenMethodTests
    {
        [TestMethod]
        public void TestNoTuples()
        {
            int val = 1;
            try
            {
                var result = (string)val.IfOrThen();
            }
            catch (Exception)
            {
                // correct. At least one tuple must be provided
            }            
        }

        [TestMethod]
        public void TestIncompleteTuple()
        {
            int val = 1;
            try
            {
                var result = (string)val.IfOrThen(1);
            }
            catch (Exception)
            {
                // correct. At least one tuple must be provided
            }
        }

        [TestMethod]
        public void TestElementInSet()
        {
            int val = 2;
            string o = val.IfOrThen(1, "one", 2, "two", 3, "three") as String;

            Debug.Assert(o.Equals("two"));
        }

        [TestMethod]
        public void TestElseStatement()
        {
            int val = 999;
            string o = val.IfOrThen(
                1, "one", 
                2, "two", 
                3, "three",
                "unknown") as String;

            Debug.Assert(o.Equals("unknown"));
        }
    }
}
