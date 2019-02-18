using System;
using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Tests
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void WagonCompletelyFull()
        {
            Wagon wagon = FillWagonWithPlantenEters();

            Assert.AreEqual(0, wagon.Ruimte);
        }

        [TestMethod]
        public void AddTooSmallPlantenEter()
        {
            Wagon wagon = new Wagon();
            Dier plant = new Dier(Dier.Groottes.Klein, false, "nvt");
            Dier vlees = new Dier(Dier.Groottes.Groot, true, "nvt");

            wagon.AddDier(vlees);
            bool shouldBeFalse = wagon.AddDier(plant);

            Assert.AreEqual(false, shouldBeFalse);
        }
        
        [TestMethod]
        public void OverFillWagon()
        {
            Wagon wagon = FillWagonWithPlantenEters();
            Dier plantKlein = new Dier(Dier.Groottes.Klein, false, "nvt");

            bool shouldBeFalse = wagon.AddDier(plantKlein);

            Assert.AreEqual(false, shouldBeFalse);
        }

        // Fill up wagon with planteneters
        private Wagon FillWagonWithPlantenEters()
        {
            Wagon wagon = new Wagon();

            // Default set of animals
            Dier plantKlein = new Dier(Dier.Groottes.Klein, false, "nvt");
            Dier plantMiddelGroot = new Dier(Dier.Groottes.Middelgroot, false, "nvt");
            Dier plantGroot = new Dier(Dier.Groottes.Groot, false, "nvt");

            wagon.AddDier(plantKlein);
            wagon.AddDier(plantKlein);
            wagon.AddDier(plantMiddelGroot);
            wagon.AddDier(plantGroot);

            if(wagon.Ruimte != 0)
            {
                throw new Exception("Wagon Not Full");
            }

            return wagon;
        }
    }
}
