using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;

namespace Unit_Tests
{
    [TestClass]
    public class DierTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            Dier dier = new Dier(
                Dier.Groottes.Middelgroot,
                true,
                "hallo wereld");

            Assert.AreEqual("Middelgroot (Vlees)", dier.ToString());

        }
    }
}
