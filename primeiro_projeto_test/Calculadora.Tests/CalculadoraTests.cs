using NUnit.Framework; 

namespace Calculadora.Tests;


[TestFixture]
public class CalculadoraSimplesTests
{
    /*Teste Classe Adicionar 2 numeros*/
    [Test]
    public void deveadicionarDoisNumeros()
    {
        var sut = new CalculadoraSimples();
        var resultado = sut.Adicionar(5, 5);

        Assert.That(resultado, Is.EqualTo(10));
    }
    /*Teste Classe Multiplicar 2 numeros*/
    [Test]
    public void devemultiplicarDoisNumeros()
    {
        var sut = new CalculadoraSimples();
        var resultado = sut.Multiplicar(5, 3);

        Assert.That(resultado, Is.EqualTo(15));
    }

    /*Teste Classe Subtrair 2 numeros*/
    [Test]
    public void deveSubtrairDoisNumeros()
    {
        var sut = new CalculadoraSimples();
        var resultado = sut.Subtrair(10, 5);

        Assert.That(resultado, Is.EqualTo(5));
    }

    /*Teste Classe Dividir 2 numeros*/
    [Test]
    public void deveDividirDoisNumeros()
    {
        var sut = new CalculadoraSimples();
        var resultado = sut.Dividir(10, 2);

        Assert.That(resultado, Is.EqualTo(5));
    }
}


