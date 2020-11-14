using System;

namespace GolfExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            double hittingAngle;
            double hittingVelocity;
            double hittingDistance;
            double golfCourseDistance;
            double cupHoleDiameter = 0.10;
            double greenDistance;

            Random courseDistance = new Random();

            string acceptingInputValues = "n";
            double[] hittingDistanceTable = new double[10];
            bool reachedGreen = false;

            // Length of course and number of swings.
            golfCourseDistance = Convert.ToDouble(courseDistance.Next(200, 900));

            // Assign the first swing and maxSwing.
            int swing = 1;
            int maxSwing = Convert.ToInt32(golfCourseDistance / 100) + 1;

            // Assign the length of the green and the size of the cup.
            greenDistance = golfCourseDistance / 10;

            Console.WriteLine("Golf Console Application");
            //Console.WriteLine("\n");
            Console.WriteLine("The golf course is {0} meter long and you have a maximum of {1} swings", golfCourseDistance, maxSwing); // {0:0.00}
            //Console.WriteLine("\n");
            Console.WriteLine("Enter angle in degrees and velocity speed in m/s for the golf swing");

            do
            {
                do
                {
                    Console.WriteLine("Swing number: {0}", swing);

                    do
                    {

                        Console.Write("Angle between 1-50 degrees: ");
                        hittingAngle = checkValues(0, 50);
                    }
                    while (hittingAngle <= 0 || hittingAngle >= 51);

                    do
                    {
                        Console.Write("Velocity speed between 1-100 m/s: ");
                        hittingVelocity = checkValues(0, 101);
                    }
                    while (hittingVelocity <= 0 || hittingVelocity >= 101);

                    do
                    {
                        Console.Write("Confirm an angle of {0} degrees and a velocity speed of {1} m/s (Y/N): ", hittingAngle, hittingVelocity);
                        acceptingInputValues = Console.ReadLine();
                        if (acceptingInputValues != "y" && acceptingInputValues != "n")
                        {
                            Console.Write("The answer {0} is not Y/N. Please enter Y for yes and N for no: ", acceptingInputValues);
                        }
                    }
                    while ((acceptingInputValues != "y") && (acceptingInputValues != "Y" && (acceptingInputValues != "n") && (acceptingInputValues != "N")));
                }
                while (acceptingInputValues == "n");
                Console.WriteLine("Golf ball travel distance: {0:0.00}", hittingDistance = Math.Pow(hittingVelocity, 2) / 9.8 * (Math.Sin(2 * (Math.PI / 180) * hittingAngle)));
                hittingDistanceTable[swing - 1] = hittingDistance;

                if ((golfCourseDistance > cupHoleDiameter) && (golfCourseDistance < hittingDistance))
                {
                    golfCourseDistance = (golfCourseDistance - hittingDistance) * -1;
                }
                else
                {
                    golfCourseDistance = golfCourseDistance - hittingDistance;
                    Console.WriteLine("Remaining distance is: {0:0.00}", golfCourseDistance);
                }

                if (golfCourseDistance < greenDistance && golfCourseDistance > cupHoleDiameter && reachedGreen == false)
                {
                    reachedGreen = true;
                }
                else if ((golfCourseDistance + hittingDistance) > greenDistance && reachedGreen == true && swing <= maxSwing)
                {
                    printScoreCard(hittingDistanceTable, swing, "Golf ball is out in the forest.");
                    swing = maxSwing + 1;
                    Console.ReadKey();
                }

                if (golfCourseDistance <= cupHoleDiameter && swing <= maxSwing)
                {
                    printScoreCard(hittingDistanceTable, swing, "Golf ball in the cup!");
                    swing = maxSwing + 1;
                    Console.ReadKey();
                }
                else if (golfCourseDistance > cupHoleDiameter && swing == maxSwing)
                {
                    printScoreCard(hittingDistanceTable, swing, "Too many swings");
                    swing = maxSwing + 1;
                    Console.ReadKey();
                }
                swing++;
            }
            while (swing <= maxSwing);
        }

        static void printScoreCard(double[] scoreCard, int numberOfSwings, string endingMessage)
        {
            Console.WriteLine("{0} Swings:", endingMessage);

            for (int i = 1; i <= numberOfSwings; i++)
            {
                Console.WriteLine("Swing number: {0}\t{1:0.00}", i, scoreCard[i - 1]);
            }
        }

        static double checkValues(double minValue, double maxValue)
        {
            double inputValue = 0;

            try
            {
                inputValue = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a degree number: ");
                if (inputValue <= minValue)
                {
                    Console.WriteLine($"The value {minValue} is to low. Please enter a higher value: ");
                }
                if (inputValue >= maxValue)
                {
                    Console.Write($"The value {maxValue} is to high. Please enter a lower value: ");
                }
            }

            return inputValue;
        }
    }
}
