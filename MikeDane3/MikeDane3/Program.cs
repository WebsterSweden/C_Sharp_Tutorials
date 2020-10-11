using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;

namespace MikeDane3
{
    class Program
    {
        static void Main(string[] args)
        {
            static int GetMaxOne(int num1, int num2)
            {
                int result;

                if (num1 > num2)
                {
                    result = num1;
                }
                else
                {
                    result = num2;
                }
                return result;
            }

            Console.WriteLine(GetMaxOne(3, 9));

            static int GetMaxTwo(int num1, int num2, int num3)
            {
                int result;

                if (num1 >= num2 && num1 >= num3)
                {
                    result = num1;
                }
                else if (num2 >= num1 && num2 >= num3)
                {
                    result = num2;
                }
                else
                {
                    result = num3;
                }
                return result;
            }

            Console.WriteLine(GetMaxTwo(3, 6, 9));

            int[] intArrayOne = { 3, 6, 9 };

            int numberMaxOne = intArrayOne.Max();

            Console.WriteLine(numberMaxOne);

            //Console.Write("Enter number one: ");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number two: ");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number three: ");
            //int numberThree = Convert.ToInt32(Console.ReadLine());

            //int[] numberArrayOne = new int[3];
            //numberArrayOne[0] = numberOne;
            //numberArrayOne[1] = numberTwo;
            //numberArrayOne[2] = numberThree;

            //int numberMaxTwo = numberArrayOne.Max();

            //Console.WriteLine(numberMaxTwo);

            //Console.Write("Enter a number: ");
            //double number1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Operator: ");
            //string operatorChoice = Console.ReadLine();

            //Console.Write("Enter a number: ");
            //double number2 = Convert.ToDouble(Console.ReadLine());

            //double result;

            //if (operatorChoice == "+")
            //{
            //    result = number1 + number2;
            //    Console.WriteLine(result);
            //}
            //else if (operatorChoice == "-")
            //{
            //    result = number1 - number2;
            //    Console.WriteLine(result);
            //}
            //else if (operatorChoice == "/")
            //{
            //    result = number1 / number2;
            //    Console.WriteLine(result);
            //}
            //else if (operatorChoice == "*")
            //{
            //    result = number1 * number2;
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Operator");
            //}

            //int dayOfWeekInteger = (int)DateTime.Now.DayOfWeek;
            int dayOfWeekInteger = Convert.ToInt32(DateTime.Now.DayOfWeek);

            Console.WriteLine(dayOfWeekInteger);

            string dayOfWeek = "";

            if (dayOfWeekInteger == 0)
            {
                dayOfWeek = "Sunday";
            }
            else if (dayOfWeekInteger == 1)
            {
                dayOfWeek = "Monday";
            }
            else if (dayOfWeekInteger == 2)
            {
                dayOfWeek = "Tuesday";
            }
            else if (dayOfWeekInteger == 3)
            {
                dayOfWeek = "Wednesday";
            }
            else if (dayOfWeekInteger == 4)
            {
                dayOfWeek = "Thursday";
            }
            else if (dayOfWeekInteger == 5)
            {
                dayOfWeek = "Friday";
            }
            else if (dayOfWeekInteger == 6)
            {
                dayOfWeek = "Saturday";
            }
            else
            {
                dayOfWeek = "Unknown";
            }

            Console.WriteLine("dayOfWeekInteger: " + dayOfWeekInteger + " dayOfWeek: " + dayOfWeek);

            static string GetDay(int dayNumber)
            {
                string dayName;

                switch (dayNumber)
                {
                    case 0:
                        dayName = "Sunday";
                        break;
                    case 1:
                        dayName = "Monday";
                        break;
                    case 2:
                        dayName = "Tuesday";
                        break;
                    case 3:
                        dayName = "Wednesday";
                        break;
                    case 4:
                        dayName = "Thursday";
                        break;
                    case 5:
                        dayName = "Friday";
                        break;
                    case 6:
                        dayName = "Saturday";
                        break;
                    default:
                        dayName = "Invalid Day Number";
                        break;
                }

                return dayName;
            }

            Console.WriteLine(GetDay((int)DateTime.Now.DayOfWeek));

        }
    }
}
