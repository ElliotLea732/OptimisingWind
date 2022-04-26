using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OptimisingWind
{
    public class Turbine : PictureBox
    {

        int ID;
        int xLoc = 0;
        int yLoc = 0;
        int startTop;
        int startLeft;
        double receivedWind = 0;
        double powerOutput = 0;
        int cost = 100;
        programForm programForm;

        WindWake turbineWake;

        Point point;

        public Turbine(int Id, int inX, int inY, programForm inForm)
        {
            ID = Id;
            xLoc = inX;
            yLoc = inY;
            programForm = inForm;

        }

        public double calculatePowerOutput()
        {
            if (receivedWind >= 2.3 & receivedWind <= 12.8)
            {
                powerOutput = 0.3 * Math.Pow(receivedWind, 3);
            } else if (receivedWind > 12.8 & receivedWind < 18)
            {
                powerOutput = 630;
            } else
            {
                powerOutput = 0;
            }
            return powerOutput;
        }

        public void setxLoc(int inXloc)
        {
            xLoc = inXloc;
        }

        public int getxLoc()
        {
            return xLoc;
        }

        public void setyLoc(int inYloc)
        {
            yLoc = inYloc;
        }

        public int getyLoc()
        {
            return yLoc;
        }

        public int getCost()
        {
            return cost;
        }

        public void setSpeed(int inSpeed)
        {
            receivedWind = inSpeed;
        }

        public void createWake(double inVel, int inDis) //create wind wake, then update the receivedWind variable
        {
            turbineWake = new WindWake(inVel, inDis);
            receivedWind = turbineWake.getFinalVelocity();

        }

        protected override void OnMouseDown(MouseEventArgs e)  //implemented drag and drop functionality for turbines
        {
            startLeft = this.Left;
            startTop = this.Top;

            point = e.Location;
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
                xLoc = this.Left;
                yLoc = this.Top;
            }
            base.OnMouseMove(e);

        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (this.Left < 60 || this.Left > 460 || this.Top < 130 || this.Top > 530)   //ensure new location is allowed
            {
                this.Left = startLeft;
                this.Top = startTop;
            }


            foreach (Turbine turbine in programForm.TurbineList)     //check if new location overlaps with any other turbine
            {
                if (ID != turbine.ID)
                {
                    if ((turbine.xLoc - this.Left < 40 && turbine.xLoc - this.Left > -40) && (turbine.yLoc - this.Top < 40 && turbine.yLoc - this.Top > -40))
                    {
                       this.Left = startLeft;
                       this.Top = startTop;
                    }
                }
            }

            programForm.createAreaBoxes(); //fix boxes

        }

 
    }
}
