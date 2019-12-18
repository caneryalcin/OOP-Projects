using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTracking
{
    class CargoVehicle
    {
        public delegate void SpeedHandler(string _plate,string _brand, int _speed);

        public event SpeedHandler SpeedExceeded;

        public CargoVehicle(string plate,string brand)
        {

            Plate = plate;
            Brand = brand;
        }


        string plate,brand;
        int speed;

        public string Plate
        {
            get
            {
                return plate;
            }
            set
            {
                plate = value;
            }
        }

        public string Brand
        {

            get
            {

                return brand;

            }
            set
            {

                brand = value;

            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {

                if (speed >= 110)
                {

                    speed = value;
                    SpeedExceeded(Plate, Brand , Speed);

                }
                else
                    speed = value;
            }

        }

    }
}
