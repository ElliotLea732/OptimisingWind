﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OptimisingWind
{
    public partial class setupNewFile : Form
    {
        programForm programForm;
        public setupNewFile()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblWidthGuide_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Owner.Show();  //Show the previous form
            Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //implement input verification
            string fileName = txtName.Text;
            string areaLenInput = txtAreaLength.Text;
            string areaWidthInput = txtAreaWidth.Text;
            string noTurbinesInput = txtNoTurbines.Text;

            if (int.TryParse(areaLenInput, out int areaLenTry) == false)
            {
                // pop up box with please enter an integer in the length box
            } else if (int.TryParse(areaWidthInput, out int areaWidthTry) == false)
            {
                // pop up box with please enter an integer in the width box
            } else if (int.TryParse(noTurbinesInput, out int noTurbinesTry) == false)
            {
                // pop up box with please enter an integer in the turbines no box
            } else if (areaLenTry > 4000 || areaLenTry < 800)
            {
                // pop up box with values outside allowed area
            } else if (areaWidthTry > 4000 || areaWidthTry < 800)
            {
                // pop up box with values outside allowed area
            } else if (noTurbinesTry > 20 || noTurbinesTry < 0)
            {
                // pop up box with values outside allowed area
            } else
            {
                //assign final variables and make new form

                //assign variables to newly created form??

                if (programForm == null)
                {
                    programForm = new programForm();   //Create form if not created
                    programForm.FormClosed += programForm_FormClosed;  //Add eventhandler to cleanup after form closes
                }

                //if all variables validated, assign variables to main program form
                programForm.programName = fileName;
                programForm.areaLen = areaLenTry;
                programForm.areaWidth = areaWidthTry;
                programForm.noTurbines = noTurbinesTry;

                programForm.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }

        }

        void programForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            programForm = null;  //If form is closed make sure reference is set to null
            Show();
        }
    }
}
