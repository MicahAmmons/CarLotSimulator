using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            CarLot LottaCar = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car();
                car1.Make = "Toyota";
                car1.Year = 2020;
                car1.IsDrivable = true;
                car1.Model = "camry";
                car1.EngineNoise = "Loud";
                car1.HonkNoise = "Cute";
            LottaCar.ListOfCars.Add(car1);
            Car car2 = new Car() 
            { 
                EngineNoise = "Quiet", 
                Model = "Corolla", 
                HonkNoise = "LOUD", 
                IsDrivable = true, 
                Year = 2019, 
                Make = "Camry" 
            };
            LottaCar.ListOfCars.Add(car2);

            Car car3 = new Car("Toyota", 2019, false, "camry", "Medium", "Loud Enough");
            LottaCar.ListOfCars.Add(car3);

            foreach (Car item in LottaCar.ListOfCars)
            {
                Console.WriteLine($" Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
            }





            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
