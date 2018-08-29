﻿using System;
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
                    Wagon nieweWagon = new Wagon();

                    nieweWagon.dierAdd(currentDier);
                    nieweWagon.ruimte =- (int) currentDier.Grootte;

                    Trein1.addWagon(nieweWagon);
                    lbTrein.Items.Add(nieweWagon);
                } else
                {
                    //Trein1.Wagons
                    foreach (Wagon currentWagon in Trein1.Wagons)
                    {
                        //Check if currentdier is groter dan de vleeseter
                        if (currentDier.Grootte > currentWagon.VleesEterMaat())
                        {
                            MessageBox.Show("True");
                        }

                        ////Check voor grootste vleeseter
                        //if (currentWagon.VleesEterMaat() == Dier.Maten.Groot)
                        //{

                        //} else if (currentWagon.VleesEterMaat() == Dier.Maten.Middelgroot)
                        //{

                        //}
                    }
                }

            }
        }
    }
}