using System;
using System.Collections.Generic;
using System.Text;

namespace OptimisingWind
{
    class WindWake
    {

        double initialWindVelocity;
        int turbineDistance;

        double finalWindVelocity;

        const double thrustCoEf = 0.88;            //these values will not change after program is started, therefore can be declared as constants
        const double axIndFactor = 0.3267949192;
        const int rotorRadius = 20;
        const int rotorDiameter = 40;
        const int turbineHeight = 60;
        const double terrainRoughness = 0.03;
        const double wakeDecay = 0.0943695829;
        const double airDensity = 1.225;
        const double powerCoEf = 0.39;
        const double sweptArea = 1256.64;

        programForm programForm;
        Turbine attachedTurbine;


        public WindWake(double inVel, Turbine inTurbine, programForm inProgramForm)
        {
            initialWindVelocity = inVel;
            attachedTurbine = inTurbine;
            programForm = inProgramForm;
            calculateWake();

        }

        public void calculateWake()
        {
            List<double> wakes = new List<double>();
            double rotor = 20 * Math.Sqrt((1 - axIndFactor) / (1 - 2 * axIndFactor));

            foreach (Turbine wakeTurbine in programForm.orderedTurbineList) //loop through other turbines, get their wakes
            {
                if (attachedTurbine.getID() > wakeTurbine.getID()) //if current turbine ID is greater than each turbine (is downwind)
                {                                                  //get wind wake effect of selected turbine on attached turbine

                    if (inWakeArea(wakeTurbine, rotor) == true)    //if wind turbine is in the wake area of the other turbine, calculate wake then add to list
                    {
                        double v = 0;
                        v = initialWindVelocity * (1 - (1 - Math.Sqrt(1 - thrustCoEf)) * (rotorDiameter / (rotorDiameter + 2 * wakeDecay * turbineDistance)));
                        wakes.Add(v);
                    }

                }
            }

            if (wakes != null) //use sum of squares to get final new wind speed
            {
                double waketotal = 0;
                foreach (double wake in wakes)
                {
                    waketotal += Math.Pow(1 - wake / initialWindVelocity, 2);
                }

                finalWindVelocity = Math.Sqrt(1 - waketotal) * initialWindVelocity;

            }

        }

        public bool inWakeArea(Turbine wakeTurbine, double rotor)
        {
            bool inWake = false;

            if (programForm.windDirection == 1)    //calculate wake region, depending on wind direction, see if turbine is in wake area
            {
                double wakeRegion = wakeDecay * (attachedTurbine.getyLoc() - wakeTurbine.getyLoc()) + rotor;
                if (Math.Abs(wakeTurbine.getxLoc() - attachedTurbine.getxLoc()) < wakeRegion)
                {
                    inWake = true;
                    turbineDistance = attachedTurbine.getyLoc() - wakeTurbine.getyLoc();
                }
            }
            else if (programForm.windDirection == 2)
            {
                double wakeRegion = wakeDecay * (wakeTurbine.getxLoc() - attachedTurbine.getxLoc()) + rotor;
                if (Math.Abs(wakeTurbine.getyLoc() - attachedTurbine.getyLoc()) < wakeRegion)
                {
                    inWake = true;
                    turbineDistance = wakeTurbine.getxLoc() - attachedTurbine.getxLoc();
                }
            }
            else if (programForm.windDirection == 3)
            {
                double wakeRegion = wakeDecay * (wakeTurbine.getyLoc() - attachedTurbine.getyLoc()) + rotor;
                if (Math.Abs(wakeTurbine.getxLoc() - attachedTurbine.getxLoc()) < wakeRegion)
                {
                    inWake = true;
                    turbineDistance = wakeTurbine.getyLoc() - attachedTurbine.getyLoc();
                }
            }
            else if (programForm.windDirection == 4)
            {
                double wakeRegion = wakeDecay * (attachedTurbine.getxLoc() - wakeTurbine.getxLoc()) + rotor;
                if (Math.Abs(wakeTurbine.getyLoc() - attachedTurbine.getyLoc()) < wakeRegion)
                {
                    inWake = true;
                    turbineDistance = attachedTurbine.getxLoc() - wakeTurbine.getxLoc();
                }
            }



            return inWake;
        }

        public double getFinalVelocity()
        {
            return finalWindVelocity;
        }

    }
}
