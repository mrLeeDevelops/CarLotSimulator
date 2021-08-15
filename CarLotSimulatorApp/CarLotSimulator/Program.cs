using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE--Create a seperate class file called Car
            //DONE--Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE--Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE--The methods should take one string parameter: the respective noise property


            //DONE--Now that the Car class is created we can instantiate 3 new cars
            //DONE--Set the properties for each of the cars
            //DONE--Call each of the methods for each car
            var myCarLot = new List<Car>();
            var myCar1 = new Car();
            Console.WriteLine($"The Number of Cars on this lot is {CarLot.numberOfCars}."); 
            myCarLot.Add(myCar1);
            myCar1.Year = 2019;
            myCar1.Make = "Ford";
            myCar1.Model = "Focus";
            myCar1.EngineNoise = "KLINK";
            myCar1.HonkNoise = "AAAOOOGAH!";
            myCar1.IsDriveable = true;
            myCar1.MakeEngineNoise(myCar1.EngineNoise);
            myCar1.MakeHonkNoise(myCar1.HonkNoise);

            var myCar2 = new Car()
            {
                Year = 2021,
                Make = "GMC",
                Model = "Denali",
                EngineNoise = "VROOM",
                HonkNoise = "HONK",
                IsDriveable = true
            };
            Console.WriteLine($"The Number of Cars on this lot is {CarLot.numberOfCars}."); 
            myCarLot.Add(myCar2);
            myCar2.MakeEngineNoise(myCar2.EngineNoise);
            myCar2.MakeHonkNoise(myCar2.HonkNoise);
            var myCar3 = new Car(1978, "Chevy", "El Camino", "...", "BEEP", false);
            //CarLot.numberOfCars++;
            Console.WriteLine($"The Number of Cars on this lot is {CarLot.numberOfCars}."); 
            myCarLot.Add(myCar3);
            myCar3.MakeEngineNoise(myCar3.EngineNoise);
            myCar3.MakeHonkNoise(myCar3.HonkNoise);
            Console.WriteLine($"The List Count is: {myCarLot.Count}");
            foreach (Car vehicle in myCarLot)
            {
                Console.WriteLine($"YEAR--{vehicle.Year} MAKE--{vehicle.Make} MODEL--{vehicle.Model}.");
            }


            //*************BONUS*************//

            // DONE--Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            // DONE--Create a CarLot class
            // DONE--It should have at least one property: a List of cars
            // DONE--InstanTiate the Carlot at the beginning of the program and as you create a car add the car to the list.
            // DONE--At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
