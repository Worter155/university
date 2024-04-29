using System;
namespace OP_L5
{
	public class Fraction
	{

		private int numerator;
		private int denominator;

        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        public Fraction(int num, int den)
        {
            Numerator = num;
            Denominator = den;
        }

        public int Numerator
		{
			get { return numerator; }
			set { numerator = value; }
		}

        public int Denominator
        {
            get { return denominator; }
            set { if (value == 0) { denominator = 1; } else if (value < 0) { denominator *= -1; numerator *= -1; } else { denominator = value; } }
        }

		//Обычные операции

		public void Add(Fraction a)
		{
			if (Denominator == a.Denominator)
			{
				Numerator += a.Numerator;
			}
			else
			{
				Numerator = Denominator * a.Numerator + a.Denominator * Numerator;
				Denominator *= a.Denominator;
			}
		}

        public void Sub(Fraction a)
        {
            if (Denominator == a.Denominator)
            {
                Numerator -= a.Numerator;
            }
            else
            {
                Numerator = Denominator * a.Numerator - a.Denominator * Numerator;
                Denominator *= a.Denominator;
            }
        }

		public void Mul(Fraction a)
		{
			Numerator *= a.Numerator;
			Denominator *= a.Denominator;
		}

        public void Div(Fraction a)
        {
            Numerator *= a.Denominator;
            Denominator *= a.Numerator;
        }

        //Сокращение

        private int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b > 0)
            {
                a %= b;
                int v = b;
                b = a;
                a = v;
            }
            return a;
        }

        public void Reduction()
        {
            int a = GCD(Numerator, Denominator);
            Numerator /= a;
            Denominator /= a;
        }

        public string Info()
        {
            return $"{Numerator}/{Denominator}";
        }



        //Переопределение оперций

        public static Fraction operator+ (Fraction a,Fraction b)
        {
            return FractionSt.AddSt(a,b);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return FractionSt.SubSt(a, b);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return FractionSt.MulSt(a, b);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return FractionSt.DivSt(a, b);
        }
    }
}

