using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class ImportProducts:Product
    {
        protected string country;
        protected string end_user_country;
        protected double time;
        public ImportProducts()
            : base()
        {
            country = "Unknown";
            end_user_country = "Unknown";
            time = 0.0;
        }
        public ImportProducts(string Name, string Creater, double Price, double ShelfLife, int Count, double PeriodStorage, string country, string end_user_country , double time)
            : base(Name, Creater, Price, ShelfLife, Count, PeriodStorage)
        {
            this.country = country;
            this.end_user_country = end_user_country;
            this.time = time;
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string EndUser
        {
            get
            {
                return end_user_country;
            }
            set
            {
                end_user_country = value;
            }
        }
        public double TimeInWay
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Країна-експортер : {0}",this.country);
            Console.WriteLine("Країна-імпортер : {0}" , this.end_user_country);
            Console.WriteLine("Час транспортування : {0}", this.time);
        }
        public override bool AreUsable()
        {
            if ((ShelfLife + time) > PeriodStorage) return false;
            else return true;
        }
    }
}
