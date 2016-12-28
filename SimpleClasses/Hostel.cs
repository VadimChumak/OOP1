using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Hostel:House
    {
        protected string name_of_hostel;
        protected double price_of_room;
        public Hostel()
            : base()
        {
            name_of_hostel = "Unknown";
            price_of_room = 0.0;
        }
        public Hostel(string Adress, int Floor, int CountRoom, double Squere, int Year, double Coords1, double Coords2, string name, double price)
            : base(Adress, Floor, CountRoom, Squere, Year, Coords1, Coords2)
        {
            name_of_hostel = name;
            price_of_room = price;
        }

        public override string BuildInfo()
        {
            string str= base.BuildInfo();
            str += "Назва Хостелу : " + name_of_hostel + Environment.NewLine + "Вартість кімнати (за день) : " + price_of_room.ToString() + Environment.NewLine;
            return str;
        }

        public override void SaveToFile()
        {
            if (!File.Exists("Hostels.txt")) File.Create("Hostels.txt");
            File.AppendAllText("Hostels.txt", BuildInfo() + "---------------------------------------" + Environment.NewLine);
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Вартість кімнати (за день) :{0} грн", price_of_room);
            Console.WriteLine("Назва Хостелу :{0}", name_of_hostel);
        }
        public double GetPriceByDay(int day)
        {
            return (double)day * price_of_room;
        }
    }
}
