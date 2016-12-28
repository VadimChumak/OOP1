using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class SellHouse:House
    {
        protected string owner;
        protected double price;
        public SellHouse()
            : base()
        {
            owner = "Unknown";
            price = 0.0;
        }
        public SellHouse(string Adress, int Floor, int CountRoom, double Squere, int Year, double Coords1, double Coords2, string owner, double price)
            : base(Adress, Floor, CountRoom, Squere, Year, Coords1, Coords2)
        {
            this.owner = owner;
            this.price = price;
        }
        public double GetHousePrice()
        {
            return Squere * price;
        }
        public void ChangeOwner(string NewOwner)
        {
            owner = NewOwner;
        }

        public override string BuildInfo()
        {
            string str= base.BuildInfo();
            str += "Власник : " + owner + Environment.NewLine + "Ціна за метр квадратний : " + price.ToString() + Environment.NewLine;
            return str;
        }

        public override void SaveToFile()
        {
            if (!File.Exists("SellHouses.txt")) File.Create("SellHouses.txt");
            File.AppendAllText("SellHouses.txt", BuildInfo() + "---------------------------------------" + Environment.NewLine);
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Ціна за метр квадратний :{0} грн",price);
            Console.WriteLine("Власник :{0}", owner);
        }
    }
}
