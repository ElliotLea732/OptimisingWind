using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OptimisingWind
{
    public partial class runSettings : Form
    {

        public programForm ownerForm;
        public runSettings()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Owner.Show();
            ownerForm.createAreaBoxes();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)    //validate inputs, update programForm variables
        {
            string direction = cmbDirection.Text;
            string speed = txtSpeed.Text;

            if (int.TryParse(direction, out int directionTry) == false)
            {
                // pop up box with please enter an integer in the length box
                System.Windows.Forms.MessageBox.Show("Please enter an integer in the direction box");
            }
            else if (int.TryParse(speed, out int speedTry) == false)
            {
                // pop up box with please enter an integer in the width box
                System.Windows.Forms.MessageBox.Show("Please enter an integer in the speed box");
            }
            else if (directionTry == 1 || directionTry == 2 || directionTry == 3 || directionTry == 4)
            {
                ownerForm.windDirection = directionTry;    //update programForm variables
                ownerForm.windSpeed = speedTry;

                Owner.Show();    //exit current form
                ownerForm.createAreaBoxes();
                this.Close();
            }
            else {
                // pop up box with please enter a suggested number
                System.Windows.Forms.MessageBox.Show("Please enter a suggested number in the direction box");
            }
        }
    }
}
