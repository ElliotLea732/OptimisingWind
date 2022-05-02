using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OptimisingWind
{
    public partial class programForm : Form
    {
        public string programName;
        public int areaLen;
        public int areaWidth;
        public int noTurbines;

        public int windSpeed = 14;
        public int windDirection = 1;

        public List<Turbine> TurbineList = new List<Turbine>();
        public List<Turbine> orderedTurbineList = new List<Turbine>();
        public runSettings settingsForm;
        public outputForm programOutput;

        public programForm()
        {
            InitializeComponent();
        }

        private void programForm_Load(object sender, EventArgs e)
        {

            lblProgramName.Text = programName;

            this.Show(); //ensures rectangle is visible

            createAreaBoxes(); //create the box to place turbines in

            makeTurbines(); //create turbines and add them to turbine store table

        }
     

        public void createAreaBoxes()
        {
            int boxWidth = areaLen / 5;
            int boxHeight = areaWidth / 5;

            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(60, 130, boxWidth, boxHeight));
 

            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(655, 130, 200, 160));
            myPen.Dispose();
            formGraphics.Dispose();


        }

        private void makeTurbines()
        {
            for (int i = 1; i <= noTurbines; i++)
            {
 
                Turbine newTurbine = new Turbine(i, 0, 0, this); //make new turbine picture
                newTurbine.Name = "pictureBox" + i.ToString();
                newTurbine.Size = new Size(30, 30);         

                if (i <= 5){     //set start location for new turbine
                    newTurbine.Location = new Point((660 + (i - 1) * 40), 135);
                } else if (i <= 10 && i > 5){
                    newTurbine.Location = new Point((660 + (i - 6) * 40), 175);
                } else if (i <= 15 && i > 10){
                    newTurbine.Location = new Point((660 + (i - 11) * 40), 215);
                } else if (i <= 20 && i > 15){
                    newTurbine.Location = new Point((660 + (i - 16) * 40), 255);
                } 

                newTurbine.Image = Image.FromFile("..\\turbineImage.jpg");
                newTurbine.SizeMode = PictureBoxSizeMode.StretchImage;
                newTurbine.BringToFront();
                newTurbine.AllowDrop = true;
                this.Controls.Add(newTurbine);


                TurbineList.Add(newTurbine); //add turbine picture to list
            }

        }

        public double calculatePotentialPowerOutput()
        {
            double powerOutput;

            if (windSpeed >= 2.3 & windSpeed <= 12.8)
            {
                powerOutput = 0.3 * Math.Pow(windSpeed, 3);
            }
            else if (windSpeed > 12.8 & windSpeed < 18)
            {
                powerOutput = 630;
            }
            else
            {
                powerOutput = 0;
            }
            return powerOutput;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            double powerOutput = 0;
            double potentialPowerOutput = 0;

            foreach (Turbine turbine in TurbineList) //set the wind speed for each turbine
            {
                turbine.setSpeed(windSpeed);
            }

            orderedTurbineList = createOrderedList();

            foreach (Turbine turbine in TurbineList) //make wind wakes for each turbine
            {
                turbine.createWake(windSpeed);
            }

            foreach (Turbine turbine in TurbineList) //get the power output for all wind turbines
            {
                powerOutput += turbine.calculatePowerOutput();
            }
            for (int i = 1; i <= noTurbines; i++) //gets the potential power output so it can be compared to achieved power output
            {
                potentialPowerOutput += calculatePotentialPowerOutput();
            }
            
            powerOutput = Math.Round(powerOutput, 2);
           
            //System.Windows.Forms.MessageBox.Show("The total power output is: " + powerOutput + "kW.");
            //System.Windows.Forms.MessageBox.Show("The total potential power output is: " + potentialPowerOutput + "kW.");

            programOutput = new outputForm(potentialPowerOutput, powerOutput, TurbineList);   //Create form 
            programOutput.FormClosed += programOutput_FormClosed;  //Add eventhandler to cleanup after form closes
            programOutput.Show(this);  //Show Form assigning this form as the forms owner
            programOutput.ownerForm = this;
            

            //foreach (Turbine turbine in orderedTurbineList) 
            //{
            //    System.Windows.Forms.MessageBox.Show("ordered list y value: " + turbine.getyLoc());
            //}

        }

        private List<Turbine> createOrderedList()
        {
            List<Turbine> orderedTurbineList = new List<Turbine>();
            int id = 1;
            orderedTurbineList = TurbineList;

            if (windDirection == 1)           //sort turbines for north wind direction
            {
                orderedTurbineList.Sort((x, y) => x.getyLoc().CompareTo(y.getyLoc()));

            } else if (windDirection == 2)    //sort turbines for east wind direction
            {
                orderedTurbineList.Sort((x, y) => x.getxLoc().CompareTo(y.getxLoc()));
                orderedTurbineList.Reverse();

            } else if (windDirection == 3)    //sort turbines for south wind direction
            {
                orderedTurbineList.Sort((x, y) => x.getyLoc().CompareTo(y.getyLoc()));
                orderedTurbineList.Reverse();

            } else if (windDirection == 4)    //sort turbines for west wind direction
            {
                orderedTurbineList.Sort((x, y) => x.getxLoc().CompareTo(y.getxLoc()));
            }

            foreach (Turbine turbine in orderedTurbineList) //set IDs for ordered list
            {
                turbine.setID(id);
                id += 1;
            }

            return orderedTurbineList;
        }

        private void btnRunSettings_Click(object sender, EventArgs e)
        {
            settingsForm = new runSettings();   //Create form 
            settingsForm.FormClosed += settingsForm_FormClosed;  //Add eventhandler to cleanup after form closes
            settingsForm.Show(this);  //Show Form assigning this form as the forms owner
            settingsForm.ownerForm = this;
            Hide();
        }

        void settingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingsForm = null;  //If form is closed make sure reference is set to null
            Show();
        }

        void programOutput_FormClosed(object sender, FormClosedEventArgs e)
        {
            programOutput = null;  //If form is closed make sure reference is set to null
            Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)   //returns to setupNewFile form
        {
            Owner.Show();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)  //returns to the menu
        {
            Owner.Owner.Show();
            this.Hide();
        }
    }
}
