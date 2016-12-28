using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    public class House
    {
        protected string Adress;
        protected int Floor;
        protected int CountRoom;
        protected double Squere;
        protected int Year;
        protected double[] Coords;
        public House()
        {
            Adress = "Unknown";
            Floor = 0;
            CountRoom = 0;
            Squere = 0;
            Year = 0;
            Coords = new double[2];
            Coords[0] = 0;
            Coords[1] = 0;
        }
        public House(House a)
        {
            Adress = a.Adress;
            Floor = a.Floor;
            CountRoom = a.CountRoom;
            Squere = a.Squere;
            Year = a.Year;
            Coords = a.Coords;
        }
        public House(string Adress, int Floor, int CountRoom, double Squere, int Year, double Coords1, double Coords2)
        {
            this.Adress = Adress;
            this.Floor = Floor;
            this.CountRoom=CountRoom;
            this.Squere=Squere;
            this.Year=Year;
            this.Coords = new double[2];
            this.Coords[0]=Coords1;
            this.Coords[1]=Coords2;
        }
        public virtual void Show()
        {
            Console.WriteLine("Адреса - {0}", Adress);
            Console.WriteLine("Поверх - {0}", Floor);
            Console.WriteLine("Кількість кімнат - {0}", CountRoom);
            Console.WriteLine("Площа - {0} метрів квадратних", Squere);
            Console.WriteLine("Рік побудови - {0}", Year);
            Console.WriteLine("Координати - {0}:{1}",Coords[0] , Coords[1]);
        }
        public virtual string BuildInfo()
        {
            string text = "";
            text += "Адреса : " + Adress + Environment.NewLine + "Поверх : " + Floor + Environment.NewLine + "Кількість кімнат : " + CountRoom + Environment.NewLine + "Площа : " + Squere + Environment.NewLine + "Рік побудови : " + Year + Environment.NewLine + "Координати : " + Coords[0].ToString() + ":" + Coords[1].ToString() + Environment.NewLine;
            return text;
        }
        public virtual void SaveToFile()
        {
            if(!File.Exists("Houses.txt")) File.Create("Houes.txt");
            File.AppendAllText("Houses.txt", BuildInfo()+"---------------------------------------"+Environment.NewLine);
        }
        public void SetAdress(string Adress) { this.Adress = Adress; }
        public string GetAdress() { return Adress; }
        public void SetFloor(int Floor) { this.Floor = Floor; }
        public int GetFloor() { return Floor; }
        public void SetCountRoom(int CountRoom) { this.CountRoom = CountRoom; }
        public int GetCountRoom() { return CountRoom; }
        public void SetSquere(double Squere) { this.Squere = Squere; }
        public double GetSquere() { return Squere; }
        public void SetYear(int Year) { this.Year = Year; }
        public int GetYear() { return Year; }
        public void SetCoords(double x, double y) { Coords[0] = x; Coords[1] = y; }
        public void SetCoords(double[]x) { Coords[0] = x[0]; Coords[1] = x[1]; }
        public double[] GetCoords() { return Coords; }
    }
}
