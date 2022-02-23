using System;
using System.Collections.Generic;
using System.Text;

namespace OptimisingWind
{
    class Turbine
    {

        int xLoc = 0;
        int yLoc = 0;
        double receivedWind = 0;
        double powerOutput = 0;
        int cost = 100;

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

    }
}
