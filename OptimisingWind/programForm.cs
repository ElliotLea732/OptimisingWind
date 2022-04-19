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

        public int windSpeed = 8;

        public List<Turbine> TurbineList = new List<Turbine>();

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Owner.Show();  //Show the previous form
            Hide();
        }

     

        public void createAreaBoxes()
        {
            int boxWidth = areaLen / 5;
            int boxHeight = areaWidth / 5;

            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(71, 100, boxWidth, boxHeight));
 

            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(585, 130, 200, 160));
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
                    newTurbine.Location = new Point((590 + (i - 1) * 40), 135);
                } else if (i <= 10 && i > 5){
                    newTurbine.Location = new Point((590 + (i - 6) * 40), 175);
                } else if (i <= 15 && i > 10){
                    newTurbine.Location = new Point((590 + (i - 11) * 40), 215);
                } else if (i <= 20 && i > 15){
                    newTurbine.Location = new Point((590 + (i - 16) * 40), 255);
                } 

                newTurbine.Image = Image.FromFile("..\\turbineImage.jpg");
                newTurbine.SizeMode = PictureBoxSizeMode.StretchImage;
                newTurbine.BringToFront();
                newTurbine.AllowDrop = true;
                this.Controls.Add(newTurbine);


                TurbineList.Add(newTurbine); //add turbine picture to list
            }

        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            double powerOutput = 0;

            foreach (Turbine turbine in TurbineList) //set the wind speed for each turbine
            {
                turbine.setSpeed(windSpeed);
            }
            foreach (Turbine turbine in TurbineList) //get the power output for all wind turbines
            {
                powerOutput += turbine.calculatePowerOutput();
            }
            powerOutput = Math.Round(powerOutput, 2);
            System.Windows.Forms.MessageBox.Show("The total power output is: " + powerOutput + "kW.");
        }


    }
}
