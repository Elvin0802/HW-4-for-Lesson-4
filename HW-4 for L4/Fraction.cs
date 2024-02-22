﻿namespace HW4_L4;

public class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int n, int d)
    {
        Numerator= n; Denominator = d;
    }

    public Fraction Add(ref Fraction f)
    {
        int N, D;

        D = this.Denominator * f.Denominator;
        N = (this.Numerator*f.Denominator)+(this.Denominator*f.Numerator);

        return new Fraction(N, D);
    }

    public Fraction Multiply(ref Fraction f)
    {
        int N, D;

        N = (this.Numerator)*(f.Numerator);
        D = (this.Denominator)*(f.Denominator);

        return new Fraction(N, D);
    }

    public Fraction Minus(ref Fraction f)
    {
        int N, D;

        D = this.Denominator*f.Denominator;
        N = (this.Numerator*f.Denominator)-(this.Denominator*f.Numerator);

        return new Fraction(N, D);
    }

    public Fraction Divide(ref Fraction f)
    {
        int N, D;

        N = (this.Numerator) * (f.Denominator);
        D = (this.Denominator) * (f.Numerator);

        return new Fraction(N, D);
    }
    public void Simplify()
    {
        int gcd, copyD, temp;

        gcd = Numerator;
        copyD = Denominator;

        while (copyD!=0)
        {
            temp = copyD;
            copyD=gcd%copyD;
            gcd = temp;
        }

        Numerator=(Numerator/gcd);
        Denominator=(Denominator/gcd);
    }
}