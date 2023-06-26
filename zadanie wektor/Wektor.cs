using System;

public class Wektor
{
    private double[] współrzędne;

    public Wektor(byte wymiar)
    {
        współrzędne = new double[wymiar];
    }

    public Wektor(params double[] współrzędne)
    {
        this.współrzędne = współrzędne;
    }

    public double Długość
    {
        get { return Math.Sqrt(IloczynSkalarny(this, this)); }
    }

    public byte Wymiar
    {
        get { return (byte)współrzędne.Length; }
    }

    public double this[byte indeks]
    {
        get { return współrzędne[indeks]; }
        set { współrzędne[indeks] = value; }
    }

    public static double IloczynSkalarny(Wektor V, Wektor W)
    {
        if (V.Wymiar != W.Wymiar)
            throw new ArgumentException("Wektory mają różne wymiary.");

        double iloczyn = 0;
        for (byte i = 0; i < V.Wymiar; i++)
        {
            iloczyn += V[i] * W[i];
        }

        return iloczyn;
    }

    public static Wektor Suma(params Wektor[] Wektory)
    {
        if (Wektory.Length == 0)
            throw new ArgumentException("Nie podano żadnego wektora.");

        byte wymiar = Wektory[0].Wymiar;
        foreach (var wektor in Wektory)
        {
            if (wektor.Wymiar != wymiar)
                throw new ArgumentException("Wektory mają różne wymiary.");
        }

        Wektor suma = new Wektor(wymiar);
        for (byte i = 0; i < wymiar; i++)
        {
            foreach (var wektor in Wektory)
            {
                suma[i] += wektor[i];
            }
        }

        return suma;
    }

    public static Wektor operator +(Wektor v1, Wektor v2)
    {
        if (v1.Wymiar != v2.Wymiar)
            throw new ArgumentException("Wektory mają różne wymiary.");

        byte wymiar = v1.Wymiar;
        Wektor suma = new Wektor(wymiar);
        for (byte i = 0; i < wymiar; i++)
        {
            suma[i] = v1[i] + v2[i];
        }

        return suma;
    }

    public static Wektor operator -(Wektor v1, Wektor v2)
    {
        if (v1.Wymiar != v2.Wymiar)
            throw new ArgumentException("Wektory mają różne wymiary.");

        byte wymiar = v1.Wymiar;
        Wektor różnica = new Wektor(wymiar);
        for (byte i = 0; i < wymiar; i++)
        {
            różnica[i] = v1[i] - v2[i];
        }

        return różnica;
    }

    public static Wektor operator *(Wektor v, double skalar)
    {
        byte wymiar = v.Wymiar;
        Wektor iloczyn = new Wektor(wymiar);
        for (byte i = 0; i < wymiar; i++)
        {
            iloczyn[i] = v[i] * skalar;
        }

        return iloczyn;
    }

    public static Wektor operator *(double skalar, Wektor v)
    {
        return v * skalar;
    }

    public static Wektor operator /(Wektor v, double skalar)
    {
        byte wymiar = v.Wymiar;
        Wektor iloraz = new Wektor(wymiar);
        for (byte i = 0; i < wymiar; i++)
        {
            iloraz[i] = v[i] / skalar;
        }

        return iloraz;
    }

    public override string ToString()
    {
        return string.Join(", ", współrzędne);
    }
}
