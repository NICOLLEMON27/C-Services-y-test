using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using pkgServices;

namespace uTestDemo
{
    [TestClass]
    public class uTestUtilities
    {
        [TestMethod]
        public void testAddTwoChar()
        {
            #region Setup
            char varExpectedResult =(char) 10;
            char varActualResult = default;
            #endregion
            #region Test
            varActualResult = clsUtilities.opAdd((char)4, (char)6);
            #endregion
            #region Assert
            Assert.AreEqual(varExpectedResult, varActualResult);
            #endregion
        }
    }
}
