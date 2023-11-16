using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public Car(string make, int year, bool isDrivable, string model, string engineNoise, string honkNoise)
        {
           Make = make;
            Year = year;
            IsDrivable = isDrivable;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
              
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string EngineNoise)
        {

        }
        public void MakeHonkNoise(string HonkNoise)
        {

        }

        
    }
}


