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

        int xLoc = 0;
        int yLoc = 0;
        double receivedWind = 0;
        double powerOutput = 0;
        int cost = 100;

        Point point;

        public Turbine(int inX, int inY)
        {
            xLoc = inX;
            yLoc = inY;

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

        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
            base.OnMouseMove(e);
        }

    }
}
