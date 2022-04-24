using System;
using System.Collections.Generic;
using System.Text;

namespace OptimisingWind
{
    class WindWake
    {

        double initialWindVelocity;
        int turbineDistance;
        int wakeRadius;

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


        public WindWake(double inVel, int inDis)
        {
            initialWindVelocity = inVel;
            turbineDistance = inDis;
            calculateWake();

        }

        public void calculateWake()
        {

        }

        public double getFinalVelocity()
        {
            return finalWindVelocity;
        }

    }
}
