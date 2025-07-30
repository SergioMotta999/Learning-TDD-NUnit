using System;

namespace Demo_Asserts;

public class Calculadora
{
    public int SomarNumerosInteros(int a, int b)
    {
        return a + b;
    }

    public double SomarNumerosDecimais(double a, double b)
    {
        return a + b;
    }

    public int Dividir(int a, int b)
    {
        if (a > 100)
        {
            throw new ArgumentOutOfRangeException("a");
        }
        return a / b;
    }
}