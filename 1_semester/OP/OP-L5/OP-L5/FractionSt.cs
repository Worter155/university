using System;
namespace OP_L5
{
	public class FractionSt
	{
        static public Fraction AddSt(Fraction a, Fraction b)
        {
            if (a.Denominator == b.Denominator)
            {
                return new Fraction(a.Numerator + b.Numerator, a.Denominator);
            }
            else
            {
                return new Fraction(b.Denominator * a.Numerator + a.Denominator * b.Numerator, a.Denominator * b.Denominator);
            }
        }

        static public Fraction SubSt(Fraction a, Fraction b)
        {
            if (a.Denominator == b.Denominator)
            {
                return new Fraction(a.Numerator - b.Numerator, a.Denominator);
            }
            else
            {
                return new Fraction(b.Denominator * a.Numerator - a.Denominator * b.Numerator, a.Denominator * b.Denominator);
            }
        }

        static public Fraction MulSt(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        static public Fraction DivSt(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }
    }
}

