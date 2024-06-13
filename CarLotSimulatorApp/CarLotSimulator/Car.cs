using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car(int year, string make, string model)
        {

            Year = year;
            Make = make;
            Model = model;




        }
        public int Year { get; set; } = 2024;
        public string Make { get; set } = "toyota";
        public string Model { get; set; } = "corolla";
        public string EngineNoise { get; set } = "vroom vroom";
        public string Hawknoise { get; set; } = "honk honk";
        public string IsDriveabke { get; set; } = true;

        public void MakeEngineNoise() 
        {
            Console.WriteLine($"{EngineNoise}");

        }
        public void MakeHonkNoise() 
        {
            Console.WriteLine($"{Hawknoise}");
            

        }
    }
    
}
