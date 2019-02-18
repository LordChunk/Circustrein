using System;
using System.Collections.Generic;
using System.Linq;
using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Tests
{
    [TestClass]
    public class TreinTest
    {
        [TestMethod]
        public void AddWagon()
        {
            Trein trein = new Trein();

            trein.CreateWagon();
            trein.CreateWagon();

            Assert.AreEqual(2, trein.Wagons.Count);
        }
        [TestMethod]
        public void AlgorithmEfficiencyTest()
        {
            Trein trein = new Trein();
            List<Dier> dieren = new List<Dier>();
            int expectedRemainingSpace = 7;

            MaakDier(Dier.Groottes.Groot, true);
            // 5 ruimte over
            MaakDier(Dier.Groottes.Groot, false);
            MaakDier(Dier.Groottes.Middelgroot, true);
            // 7 ruimte over

            // Maak 10 kleine planteneters
            for (int i = 0; i < 10; i++)
            {
                MaakDier(Dier.Groottes.Klein, false);
            }

            // run algorithm
            trein.FillWagons(dieren);

            // Get total amount of used space
            int ActualRemainingSpace = trein.Wagons.Sum(Wagon => Wagon.Ruimte);


            Assert.AreEqual(expectedRemainingSpace, ActualRemainingSpace);

            // Voeg dieren aan lijst toe
            void MaakDier(Dier.Groottes grootte, bool eetVlees)
            {
                dieren.Add(new Dier(grootte, eetVlees, "nvt"));
            }
        }
    }
}
