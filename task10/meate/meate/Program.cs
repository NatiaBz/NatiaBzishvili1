
public class Fraction
{
    private int _numerator; // numerator (mricxveli)
    private int _denominator; // denominator (mniSvneli)

    // 0 rom ar ikos
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        _numerator = numerator;
        _denominator = denominator;
    }

    // ToString saxelisa da wiladis formatireba
    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // wialdebis damateba
    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        // kalkulacia
        int commonDenominator = f1._denominator * f2._denominator;

        // daangarisheba numeratoris
        int numeratorResult = f1._numerator * f2._denominator + f2._numerator * f1._denominator;

        return new Fraction(numeratorResult, commonDenominator);
    }

    // == Sedareba
    public static bool operator ==(Fraction f1, Fraction f2)
    {
        return f1._numerator * f2._denominator == f2._numerator * f1._denominator;
    }

    // != overload
    public static bool operator !=(Fraction f1, Fraction f2)
    {
        return !(f1 == f2); 
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            // 1/2 da 3/4 wiladebi
            Fraction fraction1 = new Fraction(1, 2); // 1/2
            Fraction fraction2 = new Fraction(3, 4); // 3/4

            // ToString() metodis gamokeneba
            Console.WriteLine("Fraction 1: " + fraction1);
            Console.WriteLine("Fraction 2: " + fraction2);

            // + testireba damateba
            Fraction sum = fraction1 + fraction2;
            Console.WriteLine("Sum of Fraction 1 and Fraction 2: " + sum);

            // == da != test
            Console.WriteLine("Fraction 1 == Fraction 2? " + (fraction1 == fraction2));
            Console.WriteLine("Fraction 1 != Fraction 2? " + (fraction1 != fraction2));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message); // Secdoma
        }
    }
}
