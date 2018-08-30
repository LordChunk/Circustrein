using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {

        Trein Trein1 = new Trein();
        List<Dier> alleDieren = new List<Dier>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btAddDier_Click(object sender, EventArgs e)
        {
            bool eetVlees = rbVleesEter.Checked;
            Dier.Maten grootte;

            if (rbGroot.Checked)
            {
                grootte = Dier.Maten.Groot;
            }
            else if (rbMiddel.Checked)
            {
                grootte = Dier.Maten.Middelgroot;
            }
            else
            {
                grootte = Dier.Maten.Klein;
            }

            string naam = tbDierNaam.Text;

            Dier nieuwDier = new Dier(grootte, eetVlees, naam);

            alleDieren.Add(nieuwDier);
            lbDierenLijst.Items.Add(nieuwDier);
        }

        private void lbDierenLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbDierenLijst.SelectedIndex;

            Dier selectedDier = alleDieren[selectedIndex];

            labelSelected.Text = "Naam: "+ selectedDier.Naam + "\nGrootte:" + selectedDier.Grootte +"\nSoort: " + selectedDier.getSoort();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            //Sorteer dierenlijst
            alleDieren = Trein1.sorteerDieren(alleDieren);

            //Vul gesorteerde lijst in listbox
            lbDierenLijst.Items.Clear();
            foreach (Dier item in alleDieren)
            {
                lbDierenLijst.Items.Add(item);
            }

            //maak wagon voor elke vleeseter
            for (int i = 0; i < alleDieren.Count; i++)
            {
                Dier currentDier = alleDieren[i];
                if (currentDier.Vleeseter)
                {
                    Wagon nieuweWagon = MaakWagon();

                    nieuweWagon.dierAdd(currentDier);
                } else
                {
                    //Set bool to default
                    bool dierHasSpot = false;

                    //Cycle door alle huidige wagons voor een plaats voor het dier
                    for ( int j = 0; j < Trein1.Wagons.Count && !dierHasSpot /*check of dier al een plek heeft */; j++)
                    {
                        Wagon currentWagon = Trein1.Wagons[j];

                        dierHasSpot = currentWagon.dierAdd(currentDier);
                    }
                    //Check of dier niet in een wagon meer kan en maak een nieuwe wagon
                    if (!dierHasSpot)
                    {
                        Wagon nieuweWagon = MaakWagon();

                        dierHasSpot = nieuweWagon.dierAdd(currentDier);
                    }
                }
            }
        }


        //Update listboxes met relevante informatie als je elementen selecteerd
        private void lbWagon_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedWagonIndex = lbTrein.SelectedIndex;
            int selectedDierIndex = lbWagon.SelectedIndex;

            Dier selectedDier = Trein1.Wagons[selectedWagonIndex].Dieren[selectedDierIndex];

            labelSelected.Text = "Naam: " + selectedDier.Naam + "\nGrootte:" + selectedDier.Grootte + "\nSoort: " + selectedDier.getSoort();
        }

        private void lbTrein_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = lbTrein.SelectedIndex;

            Wagon selectedWagon = Trein1.Wagons[selectedIndex];

            lbWagon.Items.Clear();

            foreach (Dier wagonDier in selectedWagon.Dieren)
            {
                lbWagon.Items.Add(wagonDier);
            }
        }

        private Wagon MaakWagon()
        {
            Wagon nieuweWagon = new Wagon();

            Trein1.addWagon(nieuweWagon);

            lbTrein.Items.Clear();

            foreach (Wagon currentWagon in Trein1.Wagons)
            {
                lbTrein.Items.Add(currentWagon);
            }

            return nieuweWagon;
        }
    }
}
