using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ClassLibrary
{
    public class Class
    {

        public static void FileWriterToLog(string nameofVariable, int variable)
        {
            StreamWriter sw = null;

            if (variable < 0)
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(nameofVariable + "Negative Value: " + variable + " " + DateTime.Now.ToString());
                sw.Flush();
                sw.Close();
            }
            else
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(nameofVariable + "Pozitive Value: " + variable + "Date: " + DateTime.Now.ToString());
                sw.Flush();
                sw.Close();
            }

        }

        public enum Type
        {

            Daire,
            Bahceli,
            Dubleks,
            Mustakil


        }
        public abstract class House
        {
            static List<int> sameEstateNumber = new List<int>();
            private int roomNumber;
            private int floorNumber;
            private int area;
            private string district;
            private string imageUrl;
            private string rental;
            private string forSale;

            private DateTime dateOfBuilt;
            

            private Type type;//
            private bool active;//
            private int estateNumber;

            private decimal rentalDeposit;
            private decimal rentPrice;
            private decimal forSalePrice;

            public House()
            {

                roomNumber = 1;
                floorNumber = 2;
                district = "Yenimahalle";
                area = 60;

            }

            public House(int estateNumber)
            {
                this.estateNumber = EstateNumber;
                roomNumber = 3;
                floorNumber = 5;
                district = "Batıkent";
                area = 200;

            }


            public int RoomNumber
            {

                get { return roomNumber; }

                set
                {
                    roomNumber = value;
                    FileWriterToLog("RoomNumber: ", roomNumber);

                    if (roomNumber < 0)
                    {
                        roomNumber = 0;

                    }
                }
            }

            public int FloorNumber
            {

                get
                {
                    return floorNumber;
                }

                set
                {
                    floorNumber = value;
                    FileWriterToLog("FloorNumber: ", floorNumber);

                    if (floorNumber < 0)
                    {

                        floorNumber = 0;

                    }


                }

            }

            public int EstateNumber
            {

                get
                {
                    return estateNumber;

                }
                set
                {
                    estateNumber = value;
                    FileWriterToLog("Estate Number: ", estateNumber);
                    if (estateNumber < 0)
                    {

                        estateNumber = 0;

                    }

                    else if (sameEstateNumber.Contains(estateNumber))
                    {
                        estateNumber++;
                        sameEstateNumber.Add(estateNumber);
                    }

                    else
                    {
                        sameEstateNumber.Add(estateNumber);
                    }

                }

            }

            public string Rental
            {

                get
                {
                    return rental;
                }
                set
                {
                    rental = value;

                }

            }

            public string ForSale
            {
                get
                {
                    return forSale;
                }
                set
                {

                    forSale = value;
                }

            }

            public int Area
            {

                get
                {

                    return area;

                }

                set
                {
                    area = value;
                    FileWriterToLog("Area: ", area);
                    if (area < 0)
                    {
                        area = 0;
                    }

                }

            }

            public string District
            {

                get
                {

                    return district;
                }
                set
                {

                    district = value;

                }

            }

            public DateTime DateOfBuilt
            {

                get
                {
                    return dateOfBuilt.Date;

                }
                set
                {
                    dateOfBuilt = value;
                }

            }

            public Type Type
            {

                get
                {

                    return type;

                }
                set
                {

                    type = value;

                }

            }

            public bool Active
            {

                get
                {
                    return active;
                }
                set
                {

                    active = value;

                }

            }


            public decimal RentalDeposit
            {
                get
                {

                    return rentalDeposit;
                }
                set
                {

                    rentalDeposit = value;
                    FileWriterToLog("Rental Deposit: ", (int)rentalDeposit);
                    if (rentalDeposit < 0)
                    {
                        rentalDeposit = 0;
                    }
                }
            }

            public decimal RentPrice
            {

                get
                {
                    return rentPrice;
                }
                set
                {

                    rentPrice = value;

                    FileWriterToLog("Rent Price: ", (int)rentPrice);
                    if (rentPrice < 0)
                    {
                        rentPrice = 0;
                    }
                }

            }

            public decimal ForSalePrice
            {

                get
                {

                    return forSalePrice;
                }
                set
                {

                    forSalePrice = value;
                    FileWriterToLog("Rent Price: ", (int)forSalePrice);

                    if (forSalePrice < 0)
                    {
                        forSalePrice = 0;
                    }

                }

            }

            public string ImageUrl
            {

                get
                {

                    return imageUrl;
                }
                set
                {
                    imageUrl = value;

                }
            }


            public int DaysOfAge()
            {

                DateTime date2 = DateTime.Today;
                int daysDiff = ((TimeSpan)(date2 - dateOfBuilt)).Days;
                return daysDiff;
            }

            public int calculatePrice()
            {
                int price = (RoomNumber * floorNumber) * 200;
                return price;


            }

            public abstract string HouseInfo();



        }

        public class RentHouse : House
        {

            public RentHouse(int roomNumber, int floorNumber, int estateNumber, string district, int area, Type type, bool active,
                decimal rentalDeposit, decimal rentPrice, DateTime dateOfBuilt,string rental,string imageUrl)
            {
                base.RoomNumber = roomNumber;
                base.FloorNumber = floorNumber;
                base.EstateNumber = estateNumber;
                base.District = district;
                base.Area = area;
                base.Type = type;
                base.Active = active;
                base.RentalDeposit = rentalDeposit;
                base.RentPrice = rentPrice;
                base.DateOfBuilt = dateOfBuilt.Date;
                base.Rental = rental;
                base.ImageUrl = imageUrl;

            }


            public override string HouseInfo()
            {            
                string result = string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}-{9}-{10}-{11}-{12}-{13}",
                    base.RoomNumber, base.FloorNumber, base.EstateNumber, base.District, base.Area, base.Type, base.Active, base.RentalDeposit, base.RentPrice, calculatePrice(), base.DateOfBuilt, DaysOfAge(),base.Rental,base.ImageUrl);                   
                return result;
            }
            


        }
        public class ForSaleHouse : House
        {

            public ForSaleHouse(int roomNumber, int floorNumber, int estateNumber, string district, int area, Type type, bool active,
                decimal forSalePrice, DateTime dateOfBuilt,string forSale,string imageUrl)
            {
                base.RoomNumber = roomNumber;
                base.FloorNumber = floorNumber;
                base.EstateNumber = estateNumber;
                base.District = district;
                base.Area = area;
                base.Type = type;
                base.Active = active;
                base.ForSalePrice = forSalePrice;
                base.DateOfBuilt = dateOfBuilt.Date;
                base.ForSale = forSale;
                base.ImageUrl = imageUrl;
            }


            public override string HouseInfo()
            {
                string result = string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}-{9}-{10}-{11}-{12}",
                    base.RoomNumber, base.FloorNumber, base.EstateNumber, base.District, base.Area, base.Type, base.Active,ForSalePrice, calculatePrice(), base.DateOfBuilt, DaysOfAge(),base.ForSale,base.ImageUrl);
                return result;
            }

        }

    }
}
