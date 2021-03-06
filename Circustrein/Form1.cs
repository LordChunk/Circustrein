﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        readonly Trein Trein1 = new Trein();
        List<Dier> alleDieren = new List<Dier>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtAddDier_Click(object sender, EventArgs e)
        {
            bool eetVlees = rbVleesEter.Checked;
            Dier.Groottes grootte;

            if (rbGroot.Checked)
            {
                grootte = Dier.Groottes.Groot;
            }
            else if (rbMiddel.Checked)
            {
                grootte = Dier.Groottes.Middelgroot;
            }
            else
            {
                grootte = Dier.Groottes.Klein;
            }

            string naam = tbDierNaam.Text;

            Dier nieuwDier = new Dier(grootte, eetVlees, naam);

            alleDieren.Add(nieuwDier);
            lbDierenLijst.Items.Add(nieuwDier);
        }

        private void LbDierenLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbDierenLijst.SelectedIndex;

            Dier selectedDier = alleDieren[selectedIndex];

            labelSelected.Text = "Naam: "+ selectedDier.Naam + 
                                "\nGrootte:" + selectedDier.Grootte +
                                "\nSoort: " + selectedDier.getSoort();
        }

        private void BtConfirm_Click(object sender, EventArgs e)
        {
            Trein1.Wagons.Clear();

            Trein1.FillWagons(alleDieren);
            
            // Vul listboxes
            lbDierenLijst.Items.Clear();
            foreach (Dier item in alleDieren)
            {
                lbDierenLijst.Items.Add(item);
            }
            lbTrein.Items.Clear();
            foreach (Wagon currentWagon in Trein1.Wagons)
            {
                lbTrein.Items.Add(currentWagon);
            }
        }


        //Update listboxes met relevante informatie als je elementen selecteerd
        private void LbWagon_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedWagonIndex = lbTrein.SelectedIndex;
            int selectedDierIndex = lbWagon.SelectedIndex;

            Dier selectedDier = Trein1.Wagons[selectedWagonIndex].Dieren[selectedDierIndex];

            labelSelected.Text = "Naam: " + selectedDier.Naam + "\nGrootte:" + selectedDier.Grootte + "\nSoort: " + selectedDier.getSoort();
        }

        private void LbTrein_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = lbTrein.SelectedIndex;

            Wagon selectedWagon = Trein1.Wagons[selectedIndex];

            lbWagon.Items.Clear();

            foreach (Dier wagonDier in selectedWagon.Dieren)
            {
                lbWagon.Items.Add(wagonDier);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
