using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Worker:Abonent
    {
        protected string work;
        protected double payd;
        public Worker()
            : base()
        {
            work = "Unknown";
            payd = 0.0;
        }
        public Worker(string SurName, string Name, string MiddleName, string Adress, string Number, int InCity, int UnderCity, string Operator, string male, bool active , string work_name , double paid)
            :base( SurName,  Name,  MiddleName,  Adress,  Number,  InCity,  UnderCity,  Operator,  male,  active)
        {
            work = work_name;
            payd = paid;
        }
        public override void SaveToFile()
        {
            if (!File.Exists(@"Workers.txt"))
            {
                File.Create("Workers.txt");
            }
            string text = "";
            text += "Фамілія - " + SurName + Environment.NewLine + "Ім'я - " + Name + Environment.NewLine + "По-Батькові - " + MiddleName + Environment.NewLine + "Адреса - " + Adress + Environment.NewLine + "Номер телефону - " + Number + Environment.NewLine + "Час внутрішньо-міських розмов -  " + InCity + Environment.NewLine + "Час міжміських розмов - " + UnderCity + Environment.NewLine + "Оператор - " + Operator + Environment.NewLine + "Стать  -" + male + Environment.NewLine;
            if (active)
                text += "Активність в мережі - активний" + Environment.NewLine; 
            else
                text += "Активність в мережі - неактивний" + Environment.NewLine;
            text += "Місце роботи - " + work + Environment.NewLine + "Заробітня плата - " + payd.ToString() + Environment.NewLine + "------------------------------------------" + Environment.NewLine;
            File.AppendAllText("Workers.txt", text);
        }
        public bool AreVellPayd()
        {
            if (payd > 4000) return true;
            else return false;
        }
        public double YearPaid()
        {
            return payd * 12;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Місце роботи : {0}", work);
            Console.WriteLine("Заробітня плата : {0}", payd);
        }
    }
}
