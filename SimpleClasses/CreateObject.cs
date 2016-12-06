using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class CreateObject
    {
        public class FindPhone
        {
            public static void FindBySurname(string Surname, Phone[] p)
            {
                foreach (Phone a in p)
                {
                    if (a.surname == Surname) a.Show();
                }
            }
            public static void FindByName(string Name, Phone[] p)
            {
                foreach (Phone a in p)
                {
                    if (a.name == Name) a.Show();
                }
            }
            public static void FindByMiddleName(string Middlename, Phone[] p)
            {
                foreach (Phone a in p)
                {
                    if (a.GetMiddleName() == Middlename) a.Show();
                }
            }
            public static void FindByAdress(string Adress, Phone[] p)
            {
                foreach (Phone a in p)
                {
                    if (a.GetAdress() == Adress) a.Show();
                }
            }
            public static void FindByNumber(string Number, Phone[] p)
            {
                foreach (Phone a in p)
                {
                    if (a.GetNumber() == Number) a.Show();
                }
            }
            public static void FindByOperator(string Operator, Phone[] p)
            {
                foreach (Phone a in p)
                {
                    if (a.GetOperator() == Operator) a.Show();
                }
            }
        }
        public class FindProduct
        {
            public static void FindByName(string Name, Product[] p)
            {
                foreach (Product a in p)
                {
                    if (a.GetName() == Name) a.Show();
                }
            }
            public static void FindByCreator(string Creator, Product[] p)
            {
                foreach (Product a in p)
                {
                    if (a.GetCreater() == Creator) a.Show();
                }
            }
            public static void FindByPrice(double Price, Product[] p)
            {
                foreach (Product a in p)
                {
                    if (a.GetPrice() == Price) a.Show();
                }
            }
            public static void FindByShelfLife(double ShelfLife, Product[] p)
            {
                foreach (Product a in p)
                {
                    if (a.GetShelfLife() == ShelfLife) a.Show();
                }
            }
            public static void FindByCount(int Count, Product[] p)
            {
                foreach (Product a in p)
                {
                    if (a.GetCount() == Count) a.Show();
                }
            }
            public static void FindByPeriodStorage(double PeriodStorage, Product[] p)
            {
                foreach (Product a in p)
                {
                    if (a.GetPeriodStorage() == PeriodStorage) a.Show();
                }
            }
        }
        public class FindHouse
        {
            public static void FindByAdress(string Adress, House[] p)
            {
                foreach (House a in p)
                {
                    if (a.GetAdress() == Adress) a.Show();
                }
            }
            public static void FindByFloor(int Floor, House[] p)
            {
                foreach (House a in p)
                {
                    if (a.GetFloor() == Floor) a.Show();
                }
            }
            public static void FindByCountRoom(int Count, House[] p)
            {
                foreach (House a in p)
                {
                    if (a.GetCountRoom() == Count) a.Show();
                }
            }
            public static void FindBySquere(double s, House[] p)
            {
                foreach (House a in p)
                {
                    if (a.GetSquere() == s) a.Show();
                }
            }
            public static void FindByYear(int Year, House[] p)
            {
                foreach (House a in p)
                {
                    if (a.GetYear() == Year) a.Show();
                }
            }
        }

        public static House[] CreateHouse()
        {
            string[] arr = File.ReadAllLines(@"House.txt");
            House[] h = new House[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                string[]s = arr[i].Split('|');
                h[i] = new House();
                h[i].SetAdress(s[0]);
                h[i].SetFloor(int.Parse(s[1]));
                h[i].SetCountRoom(int.Parse(s[2]));
                h[i].SetSquere(double.Parse(s[3]));
                h[i].SetYear(int.Parse(s[4]));
                h[i].SetCoords(double.Parse(s[5]), double.Parse(s[6]));
            }
            return h;
        }
        public static Product[] CreateProduct()
        {
            string[] arr = File.ReadAllLines(@"Product.txt");
            Product[] h = new Product[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                string[] s = arr[i].Split('|');
                h[i] = new Product();
                h[i].SetName(s[0]);
                h[i].SetCreater(s[1]);
                h[i].SetPrice(double.Parse(s[2]));
                h[i].SetShelfLife(double.Parse(s[3]));
                h[i].SetCount(int.Parse(s[4]));
                h[i].SetPeriodStorage(double.Parse(s[5]));
            }
            return h;
        }

        public static Phone[] CreatePhone()
        {
            string[] arr = File.ReadAllLines(@"Phone.txt");
            Phone[] h = new Phone[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                string[] s = arr[i].Split('|');
                h[i] = new Phone();
                h[i].SetSurname(s[0]);
                h[i].name=s[1];
                h[i].SetMiddleName(s[2]);
                h[i].SetAdress(s[3]);
                h[i].number = s[4];
                h[i].SetInCity(int.Parse(s[5]));
                h[i].SetUnderCity(int.Parse(s[6]));
                h[i].SetOperator(s[7]);
            }
            return h;
        }
    }
}
