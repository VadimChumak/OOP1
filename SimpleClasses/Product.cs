using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    public class Product
    {
        private string Name;
        private string Creater;
        private double Price;
        private double ShelfLife;
        private int Count;
        private double PeriodStorage;

        public Product()
        {
            Name = "NULL";
            Creater = "Unknown";
            Price = 0;
            ShelfLife = 0;
            Count = 0;
            PeriodStorage = 0;
        }
        public Product(string Name, string Creater, double Price, double ShelfLife, int Count, double PeriodStorage)
        {
            this.Name = Name;
            this.Creater = Creater;
            this.Price = Price;
            this.ShelfLife = ShelfLife;
            this.Count = Count;
            this.PeriodStorage = PeriodStorage;
        }
        public Product(Product a)
        {
            Name = a.Name;
            Creater = a.Creater;
            Price = a.Price;
            ShelfLife = a.ShelfLife;
            Count = a.Count;
            PeriodStorage = a.PeriodStorage;
        }
        public void Show()
        {
            Console.WriteLine("Назва - {0}", Name);
            Console.WriteLine("Виробник - {0}", Creater);
            Console.WriteLine("Ціна - {0} грн", Price);
            Console.WriteLine("Термін зберігання - {0}", ShelfLife);
            Console.WriteLine("Кількість - {0}", Count);
            Console.WriteLine("Термін придатності - {0}", PeriodStorage);
            Console.WriteLine("------------------------------------------");
        }
        public void SetName(string Name) { this.Name = Name; }
        public string GetName() { return Name;}
        public void SetCreater(string Creater) { this.Creater = Creater; }
        public string GetCreater() { return Creater; }
        public void SetPrice(double Price) { this.Price = Price; }
        public double GetPrice() { return Price; }
        public void SetShelfLife(double ShelfLife) { this.ShelfLife = ShelfLife; }
        public double GetShelfLife() { return ShelfLife; }
        public void SetCount(int Count) { this.Count = Count; }
        public int GetCount() { return Count; }
        public void SetPeriodStorage(double PeriodStorage) { this.PeriodStorage = PeriodStorage; }
        public double GetPeriodStorage() { return PeriodStorage; }
    }
}
