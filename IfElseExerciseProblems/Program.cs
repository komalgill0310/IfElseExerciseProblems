using System;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace IfElseExerciseProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //CheckIfNumberIsValid();
           //FindMaximumNumber();
            //CheckImageLandScapeOrPortrait();
            CheckkSpeedLimit();
        }


        //Problem#1
        //Write a program and ask the user to enter a number.The number should be between 1 to 10.
        //If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".
        //(This logic is used a lot in applications where values entered into input boxes need to be validated.)
        private static void CheckIfNumberIsValid()
        {
            Console.WriteLine("Please Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number > 0 && number < 10)
            {
                Console.WriteLine("Valid\n");
            }
            else
            {
                Console.WriteLine("Invalid\n");
            }
        }


        //Problem#2
        //Write a program which takes two numbers from the console and displays the maximum of the two.

        private static void FindMaximumNumber()
        {
            Console.WriteLine("Please enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int maxNum = number1 > number2 ? number1 : number2;
            Console.WriteLine("\nMaximum Number is: " + maxNum);
        }


        //Problem#3
        //Write a program and ask the user to enter the width and height of an image.
        //Then tell if the image is landscape or portrait.

        private static void CheckImageLandScapeOrPortrait()
        {
            Console.WriteLine("\nPlease enter the width of an image: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the height of an image: ");
            int height = Convert.ToInt32(Console.ReadLine());

            int imageOrientation = width > height ? width : height;
            Console.WriteLine(imageOrientation == width ? "Image is Landscape!" : "Image is Portrait!");
        }


        //Problem#4
        //Your job is to write a program for a speed camera.
        //For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
        //Write a program that asks the user to enter the speed limit.
        //Once set, the program asks for the speed of a car.
        //If the user enters a value less than the speed limit, program should display Ok on the console.
        //If the value is above the speed limit, the program should calculate the number of demerit points.
        //For every 5km/hr above the speed limit,
        //1 demerit points should be incurred and displayed on the console.
        //If the number of demerit points is above 12, the program should display License Suspended.

        private static void CheckkSpeedLimit()
        {
            Console.WriteLine("\nPlease enter a Speed Limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the speed of your car: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if(carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int overSpeedDiff = carSpeed - speedLimit;
                int demeritPoints = overSpeedDiff / 5;
                Console.WriteLine("Number of Demerit Points is: " + demeritPoints);

                if(demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended!");
                }

            }
        }


    }
}
