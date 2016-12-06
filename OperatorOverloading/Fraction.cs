using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Fraction
    {
        private int numerator;
        private int denumerator;
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }
        public int Denumerator
        {
            get
            {
                return denumerator;
            }
            set
            {
                if (value != 0) denumerator = value;
                else denumerator = 1;
            }
        }
        public int intPart
        {
            get
            {
                return numerator / denumerator;
            }
        }
        public Fraction():this(1 , 1)
        {
        }
        public Fraction(int numerator, int denumerator)
        {
            this.numerator = numerator;
            this.denumerator = denumerator;
        }
        public Fraction(int number)
        {
            numerator = number;
            denumerator = 1;
        }
        public Fraction(Fraction a):this(a.numerator,a.denumerator)
        {
        }
        public void PrintFraction()
        {
            Console.WriteLine(numerator + "/" + denumerator);
        }
        public void Cancellation()
        {
            if (numerator != 0)
            {
                int m = denumerator, n = numerator, ost = m % n;
                while (ost != 0)
                {
                    m = n;
                    n = ost;
                    ost = m % n;
                }
                int nod = n;
                if (nod != 1)
                {
                    numerator /= nod;
                    denumerator /= nod;
                }
            }
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c.Numerator = a.numerator*b.denumerator + b.numerator*a.denumerator;
            c.Denumerator = a.denumerator * b.denumerator;
            c.Cancellation();
            return c;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c.Numerator = a.numerator*b.denumerator - b.numerator*a.denumerator;
            c.Denumerator = a.denumerator * b.denumerator;
            c.Cancellation();
            return c;
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c.Numerator = a.numerator * b.numerator;
            c.Denumerator = a.denumerator * b.denumerator;
            c.Cancellation();
            return c;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c.Numerator = a.numerator * b.denumerator;
            c.Denumerator = a.denumerator * b.numerator;
            c.Cancellation();
            return c;
        }
        public static explicit operator double(Fraction a)
        {
            double num=(double)a.numerator/(double)a.denumerator;
            return num;
        }
        public static explicit operator string(Fraction a)
        {
            string str="";
            if (a.Numerator > 0 && a.Denumerator > 0)
                str = Math.Abs(a.Numerator) + "/" + Math.Abs(a.Denumerator);
            else str = "-" + Math.Abs(a.Numerator) + "/" + Math.Abs(a.Denumerator);
            return str;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (a.Numerator * b.Denumerator == a.Denumerator * b.Numerator) return true;
            else return false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if (a.Numerator * b.Denumerator != a.Denumerator * b.Numerator) return true;
            else return false;
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            if ((double)a > (double)b) return true;
            else return false;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            if ((double)a < (double)b) return true;
            else return false;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            if ((double)a >= (double)b) return true;
            else return false;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            if ((double)a <= (double)b) return true;
            else return false;
        }
        public static Fraction operator -(Fraction a)
        {
            Fraction c=new Fraction();
            c.Numerator=a.numerator*-1;
            c.Denumerator=a.denumerator;
            return c;
        }
        public static bool operator true(Fraction a)
        {
            if (a.Numerator > 0 && a.denumerator>0) return true;
            else return false;
        }
        public static bool operator false(Fraction a)
        {
            if (a.Numerator < 0 || a.denumerator<0) return true;
            else return false;
        }
    }
}
