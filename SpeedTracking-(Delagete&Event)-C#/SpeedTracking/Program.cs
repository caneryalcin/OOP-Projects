using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SpeedTracking
{


    class Program
    {

     
        static CargoVehicle cargo_car2;
        static void Main(string[] args)
        {
            CargoVehicle cargo_car1 = new CargoVehicle("42SU1975","Fiat");
            cargo_car2 = new CargoVehicle("06CD456","Peugeout");

           
            cargo_car1.SpeedExceeded += new CargoVehicle.SpeedHandler(cargo_car_SpeedExceeded);
            cargo_car2.SpeedExceeded += new CargoVehicle.SpeedHandler(cargo_car_SpeedExceeded);
            int j = 0;
            for (byte i = 85; i < 130; i += 5)
            {

                cargo_car1.Speed = i;         
                cargo_car2.Speed = (byte)(i+j);
                j += 3;
                Console.WriteLine(cargo_car1.Plate + " plakalı aracın hızı = " + cargo_car1.Speed);
                Console.WriteLine(cargo_car2.Plate + " plakalı aracın hızı = " + cargo_car2.Speed);
                Console.WriteLine("");
                Thread.Sleep(1000);
                
            }
            Console.ReadKey();
        }

        public static void cargo_car_SpeedExceeded(string plate,string brand, int speed) {


            DateTime date = DateTime.Now;
            Console.WriteLine("Alarm " + plate + " plakalı " +brand+" marka kargo aracı hız limitini aştı " + date + " anindaki hizi = " + speed);        
        }
    }
}
