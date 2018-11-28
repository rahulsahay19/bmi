using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeCalcAngular.Calculations
{
    public class NormalCalc
    {
        public static string CalculateWeight(double Age, double IncomingWeight)
        {
            double TOLERANCE = 0;
            if (Math.Abs(Age - 6) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 19;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }
            if (Math.Abs(Age - 6.5) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 21;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }
            if (Math.Abs(Age - 7) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 19;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }
            if (Math.Abs(Age - 7.5) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 23;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }


            if (Math.Abs(Age - 8) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 25;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }
            if (Math.Abs(Age - 8.5) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 27;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }

            if (Math.Abs(Age - 9) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 28;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }

            if (Math.Abs(Age - 9.5) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 30;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }

            if (Math.Abs(Age - 10) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 31;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }

            if (Math.Abs(Age - 10.5) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 33;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }

            if (Math.Abs(Age - 11) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 35;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }

            if (Math.Abs(Age - 11.5) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 37;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }

            if (Math.Abs(Age - 12) <= TOLERANCE)
            {
                //Incoming weight equals 80% of Weight
                var normalWeight = 38;
                double percent = Math.Ceiling(ReturnPercent(normalWeight, IncomingWeight));
                if (percent > 80)
                {
                    return "normal";
                }
            }
            return "malnourished";

        }

        private static double ReturnPercent(double normalWeight, double incomingWeight)
        {
            return (double)(incomingWeight * 100) / normalWeight;
        }
    }
}
