using System;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            Car car1 = new Car();
            car1.Make = "bmw";
            car1.Model = "X2;";
             car1.Year = 2025;
            car1.EngineNoise = "brrr";
            car1.MakeEngineNoise();
            car1.MakeHonknoise();
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            Car car2 = new Car();
            car2.Make = toyota;
                car2.Model = "camry";
                car2.Year = 2025;
            car2.EngineNoise = "BRR"
                car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            Car car3 = new car();
            Car2. Make = toyota
                car3.Model= "rav4"
                car3.Year = 2026;
            car3.EngineNoise = "BRRR"
                car3.MakeEngineNoise();
                car3.MakeHonkNoise();
                










        }

        
        
        }

        
        
        
        
        
        
        
        
        
        

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

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
