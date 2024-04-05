using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CommonFraction
    {
        private int Numerator { get; }
        private int Denominator { get; }

        public CommonFraction(int numerator, int denominator = 1)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }
            if (denominator < 0)
            {
                denominator = -denominator;
                numerator = -numerator;
            }
            int gcd = greatestCommonDivisor(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;

            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public static int greatestCommonDivisor(int a, int b)
        {
            int res = 1;
            for (int i = 1; i <= Math.Abs(a) && i <= Math.Abs(b); ++i)
            {
                if (a % i == 0 && b % i == 0) res = i;
            }
            return res;
        }/*

        public static int leastCommonMultiple(int a, int b)
        {
            return a * b / greatestCommonDivisor(a, b);
        }*/

        public static CommonFraction operator /(CommonFraction dividend, CommonFraction divider)
        {
            if (divider.Numerator == 0) throw new DivideByZeroException();
            return new CommonFraction(dividend.Numerator * divider.Denominator, dividend.Denominator * divider.Numerator);
        }

        public static CommonFraction operator *(CommonFraction multiplier1, CommonFraction multiplier2)
        {
            return new CommonFraction(multiplier1.Numerator * multiplier2.Numerator, multiplier1.Denominator * multiplier2.Denominator);
        }

        public static CommonFraction operator +(CommonFraction a, CommonFraction b)
        {
            return new CommonFraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        }

        public static CommonFraction operator -(CommonFraction a, CommonFraction b)
        {
            return a + -b;
        }

        public static CommonFraction operator -(CommonFraction a)
        {
            return new CommonFraction(-a.Numerator, a.Denominator);
        }

        public override string ToString()
        {
            if (Denominator == 0)
            {
                return "0/1";
            }

            if (Denominator == 1)
            {
                return Numerator + "";
            }
            return Numerator + "/" + Denominator;
        }
    }
}
