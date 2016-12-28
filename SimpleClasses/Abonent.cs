using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Abonent:Phone
    {
        protected string male;
        protected bool active;
        public Abonent()
            : base()
        {
            male = "Unknown";
            active = false;
        }
        public Abonent(string SurName, string Name, string MiddleName, string Adress, string Number, int InCity, int UnderCity, string Operator, string male, bool active)
            : base(SurName, Name, MiddleName, Adress, Number, InCity, UnderCity, Operator)
        {
            this.male = male;
            this.active = active;
        }
        public bool IsActive()
        {
            if (active == true) return true;
            else return false;
        }
        public override void SaveToFile()
        {
            if (!File.Exists(@"Abonents.txt"))
            {
                File.Create("Abonents.txt");
            }
                string text = "";
                text += "Фамілія - " + SurName + Environment.NewLine + "Ім'я - " + Name + Environment.NewLine + "По-Батькові - " + MiddleName + Environment.NewLine + "Адреса - " + Adress + Environment.NewLine + "Номер телефону - " + Number + Environment.NewLine + "Час внутрішньо-міських розмов -  " + InCity + Environment.NewLine + "Час міжміських розмов - " + UnderCity + Environment.NewLine + "Оператор - " + Operator + Environment.NewLine +"Стать  -"+ male+Environment.NewLine;
                if(active)
                text+="Активність в мережі - активний" +Environment.NewLine+"------------------------------------------" + Environment.NewLine;
                else
                    text += "Активність в мережі - неактивний" + Environment.NewLine + "------------------------------------------" + Environment.NewLine;
                File.AppendAllText("Abonents.txt", text);
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Стать : {0}", male);
            if(active)
            Console.WriteLine("Активність і мережі : активний");
            else
                Console.WriteLine("Активність і мережі : неактивний");

        }
    }
}
