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

        List<Turbine> TurbineList = new List<Turbine>();

        public programForm()
        {
            InitializeComponent();
        }

        private void programForm_Load(object sender, EventArgs e)
        {

            lblProgramName.Text = programName;

            createAreaTable(); //create table representing planned area

            makeTurbines(); //create turbines and add them to turbine store table

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Owner.Show();  //Show the previous form
            Hide();
        }

        private void createAreaTable()
        {
            int numCol = areaLen / 200;  //get the number of rows and coloumns from user's input
            int numRow = areaWidth / 200;

            TableLayoutPanel windTurbineArea = new TableLayoutPanel(); //create table and add table info
            windTurbineArea.Location = new Point(80, 135);
            windTurbineArea.Name = "tblTurbineArea";
            windTurbineArea.Size = new Size(areaLen / 5, areaWidth / 5);
            windTurbineArea.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            windTurbineArea.ColumnCount = numCol;
            windTurbineArea.RowCount = numRow;

            for (int i = 1; i <= (numCol + 1); i++) //make sure all cells are equal size
            {
                windTurbineArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100 / numCol)));
            }
            for (int i = 1; i <= (numRow + 1); i++)
            {
                windTurbineArea.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / numRow)));
            }

            this.Controls.Add(windTurbineArea);
        }

        private void makeTurbines()
        {
            for (int i = 1; i <= noTurbines; i++)
            {
 
                PictureBox newPictureBox = new PictureBox(); //make new turbine picture
                newPictureBox.Name = "PictureBox" + i.ToString();
                newPictureBox.Size = new Size(30, 30);
                newPictureBox.Image = Image.FromFile("..\\turbineImage.jpg");
                newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                newPictureBox.BringToFront();
                newPictureBox.AllowDrop = true;
                //this.Controls.Add(newPictureBox);
                tblTurbineStore.Controls.Add(newPictureBox);

                TurbineList.Add(new Turbine(newPictureBox.Location.X, newPictureBox.Location.Y)); //add turbine picture to list
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
