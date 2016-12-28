using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleClasses
{
    public class Phone
    {
        protected string SurName;
        protected string Name;
        protected string MiddleName;
        protected string Adress;
        protected string Number;
        protected int InCity;
        protected int UnderCity;
        protected string Operator;
        public string operators { set; get; }
        public string surname
        {
            get
            {
                return SurName;
            }
        }
        public string number
        {
            set
            {
                string str = value;
                string rstr = @"(\+\d{12})";
                Regex reg = new Regex(rstr);
                if (reg.IsMatch(str)) Number = value;
            }
        }
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                string str = value;
                string strr = @"\b([A-ZА-ЯІЇЄ][a-zа-яіїє]+)\b";
                Regex reg = new Regex(strr);
                if (reg.IsMatch(str)) Name = value;
            }
        }
        public Phone()
        {
            SurName = "Unknown";
            Name = "Unknown";
            MiddleName = "Unknown";
            Adress = "Nowhere";
            Number = "0000000000";
            InCity = 0;
            UnderCity = 0;
            Operator = "Unknown";
        }
        public Phone(Phone a)
        {
            SurName = a.SurName;
            Name = a.Name;
            MiddleName = a.MiddleName;
            Adress = a.Adress;
            Number = a.Number;
            InCity = a.InCity;
            UnderCity = a.UnderCity;
            Operator = a.Operator;
        }
        public Phone(string SurName, string Name, string MiddleName, string Adress, string Number, int InCity, int UnderCity, string Operator)
        {
            this.SurName = SurName;
            this.Name = Name;
            this.MiddleName = MiddleName;
            this.Adress = Adress;
            this.Number = Number;
            this.InCity = InCity;
            this.UnderCity = UnderCity;
            this.Operator = Operator;
        }
        public virtual void SaveToFile()
        {
            if (File.Exists(@"Phones.txt"))
            {
                string text = "";
                text += "Фамілія - " + SurName + Environment.NewLine + "Ім'я - " + Name + Environment.NewLine + "По-Батькові - " + MiddleName + Environment.NewLine + "Адреса - " + Adress + Environment.NewLine + "Номер телефону - " + Number + Environment.NewLine + "Час внутрішньо-міських розмов -  " + InCity + Environment.NewLine + "Час міжміських розмов - " + UnderCity + Environment.NewLine + "Оператор - " + Operator + Environment.NewLine + "------------------------------------------" + Environment.NewLine;
                File.AppendAllText("Phones.txt", text);
            }
            else
            {
                File.Create("Phones.txt");
                string text = "";
                text += "Фамілія - " + SurName + Environment.NewLine + "Ім'я - " + Name + Environment.NewLine + "По-Батькові - " + MiddleName + Environment.NewLine + "Адреса - " + Adress + Environment.NewLine + "Номер телефону - " + Number + Environment.NewLine + "Час внутрішньо-міських розмов -  " + InCity + Environment.NewLine + "Час міжміських розмов - " + UnderCity + Environment.NewLine + "Оператор - " + Operator + Environment.NewLine + "------------------------------------------" + Environment.NewLine;
                File.AppendAllText("Phones.txt", text);
            }

        }
        public virtual void Show()
        {
            Console.WriteLine("Фамілія - {0}",SurName);
            Console.WriteLine("Ім'я - {0}",Name);
            Console.WriteLine("По-Батькові - {0}", MiddleName);
            Console.WriteLine("Адреса - {0}", Adress);
            Console.WriteLine("Номер телефону - {0}", Number);
            Console.WriteLine("Час внутрішньо-міських розмов - {0} хв", InCity);
            Console.WriteLine("Час міжміських розмов - {0} хв", UnderCity);
            Console.WriteLine("Оператор - {0}", Operator);
        }
        public void SetSurname(string SurName) { this.SurName = SurName; }
        public string GetSurname() { return SurName; }
        public void SetName(string Name) { this.Name = Name; }
        public string GetName() { return Name; }
        public void SetMiddleName(string MiddleName) { this.MiddleName = MiddleName; }
        public string GetMiddleName() { return MiddleName; }
        public void SetAdress(string Adress) { this.Adress = Adress; }
        public string GetAdress() { return Adress; }
        public void SetNumber(string Number) { this.Number = Number; }
        public string GetNumber() { return Number; }
        public void SetInCity(int InCity) { this.InCity = InCity; }
        public int GetInCity() { return InCity; }
        public void SetUnderCity(int UnderCity) { this.UnderCity = UnderCity; }
        public int GetUnderCity() { return UnderCity; }
        public void SetOperator(string Operator) { this.Operator = Operator; }
        public string GetOperator() { return Operator; }
    }
}
