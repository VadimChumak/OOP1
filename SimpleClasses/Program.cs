﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Phone[] phone=CreateObject.CreatePhone();
            House[] house = CreateObject.CreateHouse();
            Product[] product = CreateObject.CreateProduct();
            ImportProducts import = new ImportProducts("Банани", "Екзотичні фрукти", 12.50, 20, 150, 200, "Індія", "Україна", 3);
            Hostel hostel = new Hostel("м.Київ", 12, 4, 120, 1980, 23.456, 87.123, "ТуристХост", 299);
            SellHouse sell_house = new SellHouse("м.Житомир", 2, 2, 45, 2000, 10.56, 25.21, "Петров П.П.", 8999);
            Abonent abonent = new Abonent("Іванов", "Іван", "Іванович", "м.Житомир , вул.Черняховського , 103Б", "+380625182923", 1000, 500, "МТС", "Чоловіча", true);
            Worker worker = new Worker("Петров", "Петро", "Петрович", "м.Житомир , вул.Велика Бердичівська , 12А", "+380662661123", 200, 50, "Life", "Чоловіча", false, "охоронець в 'КВАРТАЛ'", 2300);
            Console.WriteLine("----------PRODUCT<-iMPORT_PRODUCT----------");
            import.Show();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("----------HOUSE<-HOSTEL----------");
            hostel.Show();
            Console.WriteLine("------------------------------------------");
            hostel.SaveToFile();
            Console.WriteLine("----------HOUSE<-SELLHOUSE----------");
            sell_house.Show();
            Console.WriteLine("------------------------------------------");
            sell_house.SaveToFile();
            Console.WriteLine("----------PHONE<-ABONENT----------");
            abonent.Show();
            Console.WriteLine("------------------------------------------");
            abonent.SaveToFile();
            Console.WriteLine("----------PHONE<-ABONENT<-WORKER----------");
            worker.Show();
            Console.WriteLine("------------------------------------------");
            worker.SaveToFile();
            Console.WriteLine("--------------------HOUSE---------------------");
            foreach (House a in house) { a.Show(); Console.WriteLine("-----------------------------------------"); }
            Console.WriteLine("--------------------PRODUCT---------------------");
            foreach (Product a in product) { a.Show(); Console.WriteLine("-----------------------------------------"); }
            Console.WriteLine("--------------------PHONE---------------------");
            foreach (Phone a in phone) { a.Show(); Console.WriteLine("-----------------------------------------"); }
            Console.WriteLine("1.Знайти в продуктах");
            Console.WriteLine("2.Знайти в телефонах");
            Console.WriteLine("1.Знайти в будинках");
            int key = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (key)
            {
                case 1:
                    Console.WriteLine("1.Знайти за назвою");
                    Console.WriteLine("2.Знайти за виробником");
                    Console.WriteLine("3.Знайти за ціною");
                    Console.WriteLine("4.Знайти за терміном зберігання");
                    Console.WriteLine("5.Знайти за кількістю");
                    Console.WriteLine("6.Знайти за терміном придатності");
                    int but = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (but)
                    {
                        case 1:
                            string name = Console.ReadLine();
                            CreateObject.FindProduct.FindByName(name, product);
                            break;
                        case 2:
                            string create = Console.ReadLine();
                            CreateObject.FindProduct.FindByCreator(create , product);
                            break;
                        case 3:
                            double price = double.Parse(Console.ReadLine());
                            CreateObject.FindProduct.FindByPrice(price, product);
                            break;
                        case 4:
                            double self = double.Parse(Console.ReadLine());
                            CreateObject.FindProduct.FindByShelfLife(self, product);
                            break;
                        case 5:
                            int count = int.Parse(Console.ReadLine());
                            CreateObject.FindProduct.FindByCount(count, product);
                            break;
                        case 6:
                            double period = double.Parse(Console.ReadLine());
                            CreateObject.FindProduct.FindByPeriodStorage(period, product);
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1.Знайти за фамілією");
                    Console.WriteLine("2.Знайти за ім'ям");
                    Console.WriteLine("3.По-батькові");
                    Console.WriteLine("4.Знайти за адресою");
                    Console.WriteLine("5.Знайти за номером телефону");
                    Console.WriteLine("6.Знайти за топератором");
                    int b = int.Parse(Console.ReadLine());
                    Console.Clear();
                        switch(b)
                        {
                            case 1:
                                string surname=Console.ReadLine();
                                CreateObject.FindPhone.FindBySurname(surname , phone);
                                break;
                            case 2:
                                string name = Console.ReadLine();
                                CreateObject.FindPhone.FindByName(name, phone);
                                break;
                            case 3:
                                string midl = Console.ReadLine();
                                CreateObject.FindPhone.FindByMiddleName(midl, phone);
                                break;
                            case 4:
                                string adr = Console.ReadLine();
                                CreateObject.FindPhone.FindByAdress(adr, phone);
                                break;
                            case 5:
                                string number = Console.ReadLine();
                                CreateObject.FindPhone.FindByNumber(number, phone);
                                break;
                            case 6:
                                string op = Console.ReadLine();
                                CreateObject.FindPhone.FindByOperator(op, phone);
                                break;
                        }
                        break;
                case 3:
                     Console.WriteLine("1.Знайти за адресою");
                    Console.WriteLine("2.Знайти за поверхом");
                    Console.WriteLine("3.Знайти за кімнатами");
                    Console.WriteLine("4.Знайти за площею");
                    Console.WriteLine("5.Знайти за роком");
                    int bit = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (bit)
                    {
                        case 1:
                            string adr = Console.ReadLine();
                            CreateObject.FindHouse.FindByAdress(adr, house);
                            break;
                        case 2:
                            int floor = int.Parse(Console.ReadLine());
                            CreateObject.FindHouse.FindByFloor(floor, house);
                            break;
                        case 3:
                            int room  = int.Parse(Console.ReadLine());
                            CreateObject.FindHouse.FindByCountRoom(room, house);
                            break;
                        case 4:
                            double s = double.Parse(Console.ReadLine());
                            CreateObject.FindHouse.FindBySquere(s, house);
                            break;
                        case 5:
                            int year = int.Parse(Console.ReadLine());
                            CreateObject.FindHouse.FindByYear(year, house);
                            break;
                    }
                    break;
            }
        }
    }
}
