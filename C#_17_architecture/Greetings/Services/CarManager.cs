﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greetings;
using Greetings.Models;

namespace Greetings.Services
{
    public class CarManager
    {
        private readonly Car _car;

        /// <summary>
        /// Constructor not sending through a car but starting with a blank one
        /// </summary>
        /// <param name="car"></param>
        public CarManager()
        {
            _car = new Car();
        }

        /// <summary>
        /// Constructor recieving the car to work with
        /// </summary>
        /// <param name="car"></param>
        public CarManager(Car car)
        {
            _car = car;
        }

        /// <summary>
        /// This will display the make and model of the car to the console
        /// </summary>
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car: " + _car.Make + "," + _car.Model);
        }

        /// <summary>
        /// This method will prompt the user to enter make and model for a new car entity
        /// </summary>
        /// <returns>The car class populated with the new values</returns>
        public Car InputCar()
        {
            Car newCar = new Car();
            bool optionSelected = false;

            Console.WriteLine();


            Console.WriteLine("What is the make of your car?");
            Console.WriteLine("Please enter one of the options below:");
            Console.WriteLine("1 for Mercedes");
            Console.WriteLine("2 for BMW");
            Console.WriteLine("3 for LandRover");
            Console.WriteLine("4 for Toyota");
            Console.WriteLine("5 for Ford");
            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        newCar.Make = Car.MakesOfCars.Mercedes;
                        Console.WriteLine("You selected: " + Car.MakesOfCars.Mercedes.ToString());
                        optionSelected = true;
                        break;
                    case "2":
                        newCar.Make = Car.MakesOfCars.BMW;
                        Console.WriteLine("You selected: " + Car.MakesOfCars.BMW.ToString());
                        optionSelected = true;
                        break;
                    case "3":
                        newCar.Make = Car.MakesOfCars.LandRover;
                        Console.WriteLine("You selected: " + Car.MakesOfCars.LandRover.ToString());
                        optionSelected = true;
                        break;
                    case "4":
                        newCar.Make = Car.MakesOfCars.Toyota;
                        Console.WriteLine("You selected: " + Car.MakesOfCars.Toyota.ToString());
                        optionSelected = true;
                        break;
                    case "5":
                        newCar.Make = Car.MakesOfCars.Ford;
                        Console.WriteLine("You selected: " + Car.MakesOfCars.Ford.ToString());
                        optionSelected = true;
                        break;
                    default:
                        Console.WriteLine("Your selection was invalid, Please try again:");
                        break;
                }
            } while (!optionSelected);

            Console.WriteLine();
            Console.WriteLine("What model is your car?");
            newCar.Model = Console.ReadLine();

            return newCar;

        }


    }
}
