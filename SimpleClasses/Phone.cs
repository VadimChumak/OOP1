using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    public class Phone
    {
        private string SurName;
        private string Name;
        private string MiddleName;
        private string Adress;
        private string Number;
        private int InCity;
        private int UnderCity;
        private string Operator;
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
        public void Show()
        {
            Console.WriteLine("Фамілія - {0}",SurName);
            Console.WriteLine("Ім'я - {0}",Name);
            Console.WriteLine("По-Батькові - {0}", MiddleName);
            Console.WriteLine("Адреса - {0}", Adress);
            Console.WriteLine("Номер телефону - {0}", Number);
            Console.WriteLine("Час внутрішньо-міських розмов - {0} хв", InCity);
            Console.WriteLine("Час міжміських розмов - {0} хв", UnderCity);
            Console.WriteLine("Оператор - {0}", Operator);
            Console.WriteLine("------------------------------------------");
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
