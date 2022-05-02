using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OptimisingWind
{
    public partial class outputForm : Form
    {

        public programForm ownerForm;
        double potentialPowerOutput = 0;
        double powerOutput = 0;
        List<Turbine> TurbineList = new List<Turbine>();

        public outputForm(double inPotential, double inPower, List<Turbine> inTurbines)
        {
            InitializeComponent();

            potentialPowerOutput = inPotential;
            powerOutput = inPower;
            TurbineList = inTurbines;
        }

        private void outputForm_Load(object sender, EventArgs e)
        {
            int totalCost = TurbineList[0].getCost() * TurbineList.Count;

            lblPowerOutput.Text = "Power output: " + powerOutput + "kW.";
            lblPotentialPower.Text = "Potential power output: " + potentialPowerOutput + "kW.";
            lblCost.Text = "Field cost: £" + totalCost + " million.";

            foreach (Turbine turbine in TurbineList) //add turbine IDs to combo box
            {
                cmbTurbines.Items.Add(turbine.getID());
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(cmbTurbines.Text);
            foreach (Turbine turbine in TurbineList) 
            {
                if (turbine.getID() == id)
                {
                    lblLocation.Text = "This turbine is located at: (" + turbine.getxLoc() + ", " + turbine.getyLoc() + ").";
                    lblTurbinePower.Text = "Turbine power: " + Math.Round(turbine.getPower(), 2) + "kw.";
                    lblTurbinePotential.Text = "Turbine potential power: " + potentialPowerOutput/TurbineList.Count + "kw.";
                    lblTurbineCost.Text = "Turbine cost: £" + turbine.getCost() + " million.";
                }
            }
        }
    }
}
