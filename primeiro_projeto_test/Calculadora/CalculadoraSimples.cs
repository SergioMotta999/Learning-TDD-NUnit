namespace Calculadora;

public class CalculadoraSimples
{
    /* Metodo para adicionar dois numeros */
    public double Adicionar(double numero1, double numero2)
    {
        return numero1 + numero2;
    }

    /* Metodo para multiplicar dois numeros */
    public double Multiplicar(double numero1, double numero2)
    {
        /*para acontecer um bug, vamos retornar uma soma em vez de uma multiplicação */
        return numero1 * numero2; // Bug: deveria ser uma multiplicação
    }

    /* Metodo para subtrair dois numeros */
    public double Subtrair(double numero1, double numero2)
    {
        return numero1 - numero2;
    }

    /* Metodo para dividir dois numeros */
    public double Dividir(double numero1, double numero2)   
    {
        if (numero2 == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }
        return numero1 / numero2;
    }

     
}
